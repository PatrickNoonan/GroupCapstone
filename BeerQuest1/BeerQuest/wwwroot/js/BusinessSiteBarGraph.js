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

        document.getElementById("past7Total").innerHTML = chartData.reduce(pastSevenTotal);
        function pastSevenTotal(total, num) {
            return total + num;
        }
        document.getElementById("past30Total").innerHTML = pastThirtyData.reduce(pastThirtyTotal);
        function pastThirtyTotal(total, num) {
            return total + num;
        }

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
            //.style('background', '#bce8f1')                    

            .append('g')
            .attr('transform', 'translate(' + margin.left + ', ' + margin.top + ')')
            .selectAll('rect').data(chartData)
            .enter().append('rect')
            .attr('title', "Hello")
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
    });