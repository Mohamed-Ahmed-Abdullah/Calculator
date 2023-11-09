// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    //$("#myForm").submit(function (event) {
    //    event.preventDefault();

    //    // Perform POST request using jQuery
    //    $.post({
    //        url: $(this).attr("action"),
    //        data: $(this).serialize(),
    //        dataType: 'json',
    //        success: function (data) {
    //            console.log(data);
    //            // Handle the response as needed
    //        },
    //        error: function (error) {
    //            console.error('Error calling controller action:', error);
    //        }
    //    });
    //});

    $(document).ready(function () {
        $("#myForm").submit(function (event) {
            event.preventDefault();

            // Perform POST request using jQuery $.ajax()
            $.ajax({
                type: "POST",
                url: $(this).attr("action"),
                data: $(this).serialize(),
                dataType: 'json',
                success: function (data) {
                    console.log(data);
                    // Handle the response as needed
                },
                error: function (error) {
                    console.error('Error calling controller action:', error);
                }
            });
        });
    });
});