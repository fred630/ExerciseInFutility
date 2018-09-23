// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function getTweets() {
    var newpath = "Tweets/?startDate=" + $('#startdate').val() + "&endDate=" + $('#enddate').val();
    location.pathname = newpath;
    location.assign(newpath);
}