
var euroRate;


function calcEurToUsd() {
    $.get("Currency/getEuroRate", function (data) {
        euroRate = data;
        var usd = $("#Euro").val() * euroRate;
        $(".usd").html("Usd is " + usd);
    });
}

function calcEurToUsdOnDate() {
    var date = $("#Date").val();
    const link = 'http://data.fixer.io/api/' + date + '?access_key=d60bb80ec704278f2ecbf9f18e0fdc6b&symbols=USD&format=1';
        $.getJSON(link, function (data) {

            var text = `${data.rates.USD}`

            $(".date").html("USD on " + date + ": " + text * $("#EuroDate").val());
        });
    }

