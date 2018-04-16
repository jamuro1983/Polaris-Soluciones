$(document).ready(function () {

});





$(function () {
    $("#btnCrearPalabra").click(function () {


        var IdPalabra = $("#SelectPais").val();
        var IdIdioma = $("#SelectIdioma").val();
        var Palabra = $("#Palabra_DescripcionPalabra").val();
        var Definicion = $("#Definicion1").val();

        $.post("/Definicion/Crear", {
            idPais: IdPalabra,
            idIdioma: IdIdioma,
            palabra: Palabra,
            definicion: Definicion
        }, function (data) {
            alert(data.toString());
        }, "text");

    });
});



//$('#btnCrearPalabra').click(function () {


//    //var Descripcion = {
//    //    IdPais: $("#SelectPais").val(),
//    //    IdIdioma: $("#SelectIdioma").val(),
//    //    DescripcionPalabra: $("#Palabra_DescripcionPalabra").val(),
//    //    Definicion1: $("#Definicion1").val()
//    //};

//    //var formContainer = $('frmCrearPalabra');  

//    //var idPais = $("#SelectPais").val();



//        var IdPalabra = $("#SelectPais").val();
//        var IdIdioma= $("#SelectIdioma").val();
//        var Palabra = $("#Palabra_DescripcionPalabra").val();
//        var Definicion = $("#Definicion1").val();


//    $.ajax({
//        url: '@Url.Action("Crear", "Definicion")',
//        type: 'POST',
//        //cache: false,
//        data: {
//                idPais: IdPalabra,
//                idIdioma: IdIdioma,
//                palabra : Palabra,
//                definicion: Definicion
//        },
//        success: function (result) {
//        //var modelStatus = $(‘.model - status’);
//        //if (result) modelStatus.text(“Estado: Enviado con éxito”);
//        //else modelStatus.text(“Estado: Enviado con error.Compruebe que ha rellenado todos los campos”);
//        },
//        error: function (jqXHR, textStatus, error) {
//        //$(‘.model - status’).text(“Estado: Error inesperado”);
//        }  
//    });  
//});


