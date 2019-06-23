$.ajax({
    url: '/Businesses/GetData',
    data: "",
    dataType: "json",
    type: "POST",
    contentType: "application/json; chartset=utf-8",
})
    .done(function (data) {
        //data brings back a date and a number of visits for that date

        let width = window.innerWidth * 0.8 // svg width
        let height = 400 // svg height
        let padding = 80
        let months = [
            'Jan', 'Feb', 'Mar', 'Apr', 'May',
            'Jun', 'Jul', 'Aug', 'Sep',
            'Oct', 'Nov', 'Dec'
        ];
        // data
        //let monthlyvisits = [
        //    { "month": 1, "visits": 100 },
        //    { "month": 2, "visits": 130 },
        //    { "month": 3, "visits": 250 },
        //    { "month": 4, "visits": 300 },
        //    { "month": 5, "visits": 265 },
        //    { "month": 6, "visits": 225 },
        //    { "month": 7, "visits": 180 },
        //    { "month": 8, "visits": 120 },
        //    { "month": 9, "visits": 145 },
        //    { "month": 10, "visits": 130 },
        //    { "month": 11, "visits": 80 },
        //    { "month": 12, "visits": 40 }
        //]
        // data
        let monthlyvisits = [
            { "month": 1, "visits": 0 },
            { "month": 2, "visits": 0 },
            { "month": 3, "visits": 0 },
            { "month": 4, "visits": 0 },
            { "month": 5, "visits": 0 },
            { "month": 6, "visits": 0 },
            { "month": 7, "visits": 0 },
            { "month": 8, "visits": 0 },
            { "month": 9, "visits": 0 },
            { "month": 10, "visits": 0 },
            { "month": 11, "visits": 0 },
            { "month": 12, "visits": 0 }
        ]

        for (let i = 0; i < data.length; i++) {
            let count = 0;
            let month = data[i].getMonthFromNum();

            switch (month) {
                case '01': monthlyvisits[0].visits++;
                    break;
                case '02': monthlyvisits[1].visits++;
                    break;
                case '03': monthlyvisits[2].visits++;
                    break;
                case '04': monthlyvisits[3].visits++;
                    break;
                case '05': monthlyvisits[4].visits++;
                    break;
                case '06': monthlyvisits[5].visits++;
                    break;
                case '07': monthlyvisits[6].visits++;
                    break;
                case '08': monthlyvisits[7].visits++;
                    break;
                case '09': monthlyvisits[8].visits++;
                    break;
                case '10': monthlyvisits[9].visits++;
                    break;
                case '11': monthlyvisits[10].visits++;
                    break;
                case '12': monthlyvisits[11].visits++;
                    break;
                
                }
        }

       
    });

