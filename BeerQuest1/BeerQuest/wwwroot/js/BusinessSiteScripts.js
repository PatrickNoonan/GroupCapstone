﻿//$.ajax({
//    url: /ControllerName/ActionName
//        dataType: "json",
//    type: "GET",
//    contentType: 'application/json; charset=utf-8',
//    cache: false,
//    data: { test: comments },
//    success: function (data) {
//        if (data.success) {
//            alert(data.message);
//        }
//    },
//    error: function (xhr) {
//        alert('error');
//    }
//});

$.ajax({
    method: "GET",
    url: "/BusinessController/getData",
    dataType: "JSON"
})
    .done(function (data) {

        let datat = [
            { date: "6/12/2019", visitors: 30 },
            { date: "6/13/2019", visitors: 40 },
            { date: "6/14/2019", visitors: 50 },
            { date: "6/15/2019", visitors: 60 },
            { date: "6/16/2019", visitors: 70 },
            { date: "6/17/2019", visitors: 80 },
            { date: "6/18/2019", visitors: 90 },
        ];

        let chartData = [];
        let chartDates = [];

        for (let i = 0; i < data.length; i++) {
            chartData.push(data[i].visitors);
        }
        for (let i = 0; i < data.length; i++) {
            chartDates.push(data[i].date);
        }

        let margin = {
            top: 30,
            right: 10,
            bottom: 30,
            left: 50
        }

        let height = 400 - margin.top - margin.bottom;
        let width = 720 - margin.left - margin.right;
        let barWidth = 40;
        let barOffset = 20;

        let parseTime = d3.timeParse("%Y/%m/%d");

        let max = d3.max(data, function (d) { return parseTime(d.date) })
        let min = d3.min(data, function (d) { return parseTime(d.date) })

        let dynamicColor;

        let yScale = d3.scaleLinear()
            .domain([0, d3.max(chartData)])
            .range([0, height])

        // let yScale = d3.scaleLinear()
        // .domain(d3.extent(data, function (d) { return +d.visitors; }))
        // .rangeRound([0, height])

        let xScale = d3.scaleBand()
            .domain(d3.range(0, chartDates.length))
            .range([0, width])

        // let xScale = d3.scaleBand()
        //     .domain(data.map(function (d) { return d.date; }))
        //     .range([0, width])

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
            .on('mouseover', function (data) {
                dynamicColor = this.style.fill;
                d3.select(this)
                    .style('fill', '#3c763d')
            })

            .on('mouseout', function (data) {
                d3.select(this)
                    .style('fill', dynamicColor)
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
            .ticks(10)

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
            .ticks()

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