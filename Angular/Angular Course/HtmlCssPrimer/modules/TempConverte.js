"use strict";
var TempConverter = (function () {
    function TempConverter() {
    }
    TempConverter.converterFtoC = function (temp) {
        var value = temp.toPrecision
            ? temp : parseFloat(temp);
        return ((parseFloat(value.toPrecision(2)) - 32) / 1.8).toFixed(1);
    };
    return TempConverter;
}());
exports.TempConverter = TempConverter;
