//上传图片的点击事件
function Up() {
    $(f1).ajaxSubmit({
        url: "/Upload/Files",
        type: "post",
        success: function (a, b, c) {
            $("#FileUrl").val(a);
            $("#Files").empty();
            $("#Files").append("<img src='" + a + "' style='width:100px;height:100px;'/>");
        }
    })
}
//三级联动 js代码
//市级数据
$("#ProvinceId").change(
    function () {
        var Id = $("#ProvinceId").val();
        $.ajax({
            url: "/Register/GetCity/" + Id,
            type: "post",
            dataType: "json",
            success: function (a, b, c) {
                $("#CityId").empty();
                $("#CityId").append("<option>--请选择市级地区--</option>");
                for (var i in a) {
                    $("#CityId").append("<option value='" + a[i].Id + "'>" + a[i].Name + "</option>");
                }
            }

        })
    }
    );
//县级数据
$("#CityId").change(
    function () {
        var Id = $("#CityId").val();
        $.ajax({
            url: "/Register/GetArea/" + Id,
            type: "post",
            dataType: "json",
            success: function (a, b, c) {
                $("#AreaId").empty();
                $("#AreaId").append("<option>--请选择县级地区--</option>");
                for (var i in a) {
                    $("#AreaId").append("<option value='" + a[i].Id + "'>" + a[i].Name + "</option>");
                }
            }
        })
    }
    );
function success(a) {
    if (a > 0) {
        alert("添加成功")
        location.href = '/Register/Index';
    }
}