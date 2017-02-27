$("document").ready(function () {

    $("#roomQty").change(function () {
        var value = jQuery(this).val();
        var repeatDiv = $("#repeatDiv");
        // alert(repeatDiv);
        // console.log(repeatDiv);
        for (var i = 1; i < value; i++) {
            repeatDiv.after(repeatDiv.clone().attr("id", "repeatDiv" + i + 1));

        }
    });

    $(function () {
        $("#chkIn").datepicker({
            minDate: 0, dateFormat: 'yy-mm-dd',
            onSelect: function (obj, event) {
                var from_date = $("#chkIn").datepicker("getDate", "+1d");
                from_date.setDate(from_date.getDate() + 1);
                $("#chkOut").datepicker("option", "minDate", from_date);
            }
        });
        $("#chkOut").datepicker({ dateFormat: 'yy-mm-dd' });
    });

});