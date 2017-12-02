$(document).ready(function () {
    $(".date-time-picker").datepicker();
});

var pCalculator = {
    fnCommonService: function (url, data) {
        var returnResult;
        $.ajax({
            type: "POST",
            async: false,
            url: url,
            data: JSON.stringify(data),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                returnResult = response;
            },
            failure: function (response) {
                alert("failure:" + response.d);
            },
            error: function (response) {
                alert("error:" + response.d);
            }
        });
        return returnResult;
    },
    fnCommonDropdown: function (url, data) {
        var returnResult;
        $.ajax({
            type: "POST",
            async: false,
            url: url,
            data: JSON.stringify(data),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                returnResult = response;
            },
            failure: function (response) {
                alert("failure:" + response.d);
            },
            error: function (response) {
                alert("error:" + response.d);
            }
        });
        return returnResult;
    },
}