$.ajax({
    url: '/Businesses/GetData',
    data: "",
    dataType: "json",
    type: "POST",
    contentType: "application/json; chartset=utf-8",
})
    .done(function (data) {
        let chartData = [];
        let chartDates = [];
        let pastSevenDays = [];
        let pastThirtyData = checkPastThirty();
        let allTimeVisitors = checkAllTime();     

        for (let i = data.length - 7; i < data.length; i++) {
            chartData.push(data[i].count);
        }

        for (let i = 0; i < 7; i++) {
            let d = new Date();
            d.setDate(d.getDate() - i);
            let dString = (d.getMonth() + "-" + d.getDate());
            pastSevenDays.unshift(dString)
        }

        for (let i = data.length - 7; i < data.length; i++) {
            chartDates.push(data[i].date);
        }

        function checkPastThirty() {
            let pastThirtyArray = [];
            if (data.length < 30) {
                for (let i = 0; i < data.length; i++) {
                    pastThirtyArray.push(data[i].count);
                }
            } else {
                for (let i = data.length - 30; i < data.length; i++) {
                    pastThirtyArray.push(data[i].count);
                }
            }
            return pastThirtyArray;
        }

        function checkAllTime() {
            let allTimeArray = [];
            for (let i = 0; i < data.length; i++) {
                allTimeArray.push(data[i].count);
            }
            return allTimeArray;
        }

        document.getElementById("past7Total").innerHTML = chartData.reduce(pastSevenTotal);
        function pastSevenTotal(total, num) {
            return total + num;
        }
        document.getElementById("past30Total").innerHTML = pastThirtyData.reduce(pastThirtyTotal);
        function pastThirtyTotal(total, num) {
            return total + num;
        }
        document.getElementById("allTimeTotal").innerHTML = allTimeVisitors.reduce(allTimeTotal);
        function allTimeTotal(total, num) {
            return total + num;
        }        

        //----------------------------------------Bar Chart-----------------------------

        function BarChart() {

            let margin = {
                top: 30,
                right: 10,
                bottom: 30,
                left: 50
            }

            let height = 300 - margin.top - margin.bottom;
            let width = 620 - margin.left - margin.right;

            let dynamicColor;

            let yScale = d3.scaleLinear()
                .domain([0, d3.max(chartData)])
                .range([0, height])

            let xScale = d3.scaleBand()
                .domain(d3.range(0, 7))
                .range([0, width])

            let colors = d3.scaleLinear()
                .domain([0, chartData.length * .33, chartData.length * .66, chartData.length])
                .range(['#d6e9c6', '#bce8f1', '#faebcc', '#ebccd1'])

            let awesome = d3.select('#bar-chart').append('svg')
                .attr('width', width + margin.left + margin.right)
                .attr('height', height + margin.top + margin.bottom)

                .append('g')
                .attr('transform', 'translate(' + margin.left + ', ' + margin.top + ')')
                .selectAll('rect').data(chartData)
                .enter().append('rect')
                .styles({
                    'fill': function (data, i) {
                        return colors(i);
                    },
                    'stroke': '#31708f',
                    'stroke-width': '1'
                })

                .attr('width', xScale.bandwidth())
                .attr('x', function (data, i) {
                    return xScale(i);
                })

                .attr('height', 0)
                .attr('y', height)
                //.append('svg:title')
                //        .text(function (data, i) { return i.count; })
                //        .text("hello")

                .on('mouseover', function (data) {
                    dynamicColor = this.style.fill;
                    d3.select(this)
                        .style('fill', '#3c763d')

                })

                .on('mouseout', function (data) {
                    d3.select(this)
                        .style('fill', dynamicColor)
                    $('svg.title').remove();
                })


            awesome.transition()
                .attr('height', function (data) {
                    return yScale(data);
                })
                .attr('y', function (data) {
                    return height - yScale(data);
                })
                .delay(function (data, i) {
                    return i * 20;
                })

                .duration(2000)
                .ease(d3.easeElastic)
            let verticalGuideScale = d3.scaleLinear()
                .domain([0, d3.max(chartData)])
                .range([height, 0])

            let vAxis = d3.axisLeft(verticalGuideScale)
                .ticks()

            let verticalGuide = d3.select('svg').append('g')
            vAxis(verticalGuide)
            verticalGuide.attr('transform', 'translate(' + margin.left + ', ' + margin.top + ')')
            verticalGuide.selectAll('path')
                .styles({
                    fill: 'none',
                    stroke: "#3c763d"
                })

            verticalGuide.selectAll('line')
                .styles({
                    stroke: "#3c763d"
                })

            let horizontalGuideScale = d3.scaleLinear()
                .domain([0, d3.max(chartDates)])
                .range([width, 0])

            let hAxis = d3.axisBottom(xScale)
                .tickFormat(function (d, i) {
                    return pastSevenDays[i];
                })

            let horizontalGuide = d3.select('svg').append('g')

            hAxis(horizontalGuide)
            horizontalGuide.attr('transform', 'translate(' + margin.left + ', ' + (height + margin.top) + ')')
            horizontalGuide.selectAll('path')
                .styles({
                    fill: 'none',
                    stroke: "#3c763d"
                })
            horizontalGuide.selectAll('line')
                .styles({
                    stroke: "#3c763d"
                });
        }
        BarChart();
    });

//---------------------------------------end Bar Chart--------------------------------------------

function startPie(dayNum) {
    $.ajax({
        url: '/Businesses/GetPieData',
        data: "",
        dataType: "json",
        type: "POST",
        contentType: "application/json; chartset=utf-8",
    })
        .done(function (data) { 
            let names = [];
            let namesBeforeThisWeek = [];
            let namesBeforeThisMonth = [];
            let namesThisWeek = [];
            let namesThisMonth = [];
            let uniqueNamesThisWeek = namesBeforeThisWeek.filter(function (val) {
                console.log(namesThisWeek.indexOf(val));
                return namesThisWeek.indexOf(val) == -1;
            });
            //let getUnique = namesBeforeThisWeek.filter(function (el) { return namesThisWeek.indexOf(el) == -1; });
            let uniqueNamesThisMonth = namesBeforeThisMonth.filter(function (val) {
                console.log(namesThisMonth.indexOf(val));
                return namesThisMonth.indexOf(val) == -1;
            });
            let now = moment().format('MM/DD/YYYY');
            let dateWeekAgo = moment().subtract(7, 'd').format('MM/DD/YYYY');
            let dateMonthAgo = moment().subtract(1, 'months').format('MM/DD/YYYY');
            let dateReg = [];     
            

            for (let i = 0; i < data.length; i++) {
                names.push(data[i].currentMember);
                dateReg.push(moment(data[i].currentDay).format('MM/DD/YYYY'));                
            }

            for (let i = 0; i < dateReg.length; i++) {
                if (dateReg[i] <= dateWeekAgo) {
                    namesBeforeThisWeek.push(names[i]);
                }
            }

            for (let i = 0; i < dateReg.length; i++) {
                if (dateReg[i] > dateWeekAgo) {
                    namesThisWeek.push(names[i]);
                }
            }

            for (let i = 0; i < dateReg.length; i++) {
                if (dateReg[i] <= dateMonthAgo) {
                    namesBeforeThisMonth.push(names[i]);
                }
            }

            for (let i = 0; i < dateReg.length; i++) {
                if (dateReg[i] > dateMonthAgo) {
                    namesThisMonth.push(names[i]);
                }
            }

            let singles = function (array) {
                for (let i = 0, single = []; i < names.length; i++) {
                    if (names.indexOf(names[i], names.indexOf(names[i]) + 1) == -1) single.push(names[i]);
                };
                return single;
            };         

            let duplicates = names.reduce(function (list, item, index, array) {
                if (array.indexOf(item, index + 1) !== -1 && list.indexOf(item) === -1) {
                    list.push(item);
                }
                return list;
            }, []);

            let returners = function (array) {
                for (let i = 0, single = []; i < names.length; i++) {
                    if (names.indexOf(duplicates[i], duplicates.indexOf(duplicates[i]) + 1) == -1) single.push(duplicates[i]);
                };
                return single;
            };        

            dateA = moment(dateReg.reduce(function (a, b) { return a < b ? a : b; }));
            let daysSinceRegistration = dateA.diff(now, 'days');

            document.getElementById("totalUnique").innerHTML = singles.length;
            document.getElementById("totalReturning").innerHTML = returners.length;
            document.getElementById("registrationDays").innerHTML = -daysSinceRegistration;



            //-------------------------------------------------Pie Chart----------------------------
            let pieData1 = { a: namesThisWeek.length, b: namesBeforeThisWeek.length } //a = customers who have never been to this bar before this week
            let pieData2 = { a: namesThisMonth.length, b: namesBeforeThisMonth.length }

            if (dayNum == "seven") {
                makePie(pieData1);
            } else if (dayNum == "thirty") {
                makePie(pieData2);
            }     

            function makePie(data) {
                $('#pie-chart').empty();

                let width = 200
                height = 200
                margin = 5

                //the radius of the pieplot is half the width or half the height (smallest one)
                let radius = Math.min(width, height) / 2 - margin

                let svg = d3.select("#pie-chart")
                    .append("svg")
                    .attr("width", width)
                    .attr("height", height)
                    .append("g")
                    .attr("transform", "translate(" + width / 2 + "," + height / 2 + ")");

                let color = d3.scaleOrdinal()
                    .domain(data)
                    .range(d3.schemeSet2);

                let pie = d3.pie()
                    .value(function (d) { return d.value; })
                let data_ready = pie(d3.entries(data))
                //now I know that group A goes from 0 degrees to x degrees and so on

                let arcGenerator = d3.arc()
                    .innerRadius(0)
                    .outerRadius(radius)

                svg
                    .selectAll('mySlices')
                    .data(data_ready)
                    .enter()
                    .append('path')
                    .attr('d', arcGenerator)
                    .attr('fill', function (d) { return (color(d.data.key)) })
                    .attr("stroke", "black")
                    .style("stroke-width", "2px")
                    .style("opacity", 0.85)

                svg
                    .selectAll('mySlices')
                    .data(data_ready)
                    .enter()
                    .append('text')
                    .text(function (d) { return d.data.value })
                    .attr("transform", function (d) { return "translate(" + arcGenerator.centroid(d) + ")"; })
                    .style("text-anchor", "middle")
                    .style("font-size", 17)
            }            
        });
}

startPie("seven");



