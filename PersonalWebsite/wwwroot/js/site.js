function imageClick() {
    $.ajax({
        type: "GET",
        url: "/api/WebsiteAPI/GetImage",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

        }
    });
}
