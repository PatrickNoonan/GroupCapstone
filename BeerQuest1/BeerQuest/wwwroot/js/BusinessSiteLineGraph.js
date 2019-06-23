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
        let monthlyVisits = [];
        for (let i = 0; i < data.length; i++) {
            let count = 0;
            if (data[i].date.getMonth() == Jan)
                switch (month) {
                    case '01'
                }
        }

        
    });

