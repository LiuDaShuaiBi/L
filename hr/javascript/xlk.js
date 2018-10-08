
                    $(function () {
                        var first = $("#firstKindId");
                        var second = $("#secondKindId");
                        var third = $("#thirdKindId");
                        first.change(function () {
                            second.html("");
                            $.ajax({
                                url: "er",
                                data: "id=" + first.val(),
                                success: function (data) {
                                    second.append("<option value='0' >请选择</option>");
                                    for (var i = 0; i < data.length; i++) {
                                        second.append("<option value='" + data[i].second_kind_id + "'>" + data[i].second_kind_name + "</option>");
                                    }
                                }
                            })
                            //$("#secondKindName").val();
                        });

                        second.change(function () {
                            third.html("");
                            $.ajax({
                                url: "san",
                                data: "id=" + second.val(),
                                success: function (data) {
                                    third.append("<option value='0' >请选择</option>");
                                    for (var i = 0; i < data.length; i++) {
                                        third.append("<option value='" + data[i].third_kind_id + "'>" + data[i].third_kind_name + "</option>");
                                    }
                                    //alert(data);
                                }
                            })
                        });

                        var seconds = $('#majorKindId');
                        var thirds = $('#majorId');
                        seconds.change(function () {
                            //$("#newMajorKindName").val($('#newMajorKindId option:selected').html());
                            thirds.html("");
                            $.ajax({
                                url: "zw",
                                data: "id=" + seconds.val(),
                                success: function (data) {
                                    thirds.append("<option value='0' >请选择</option>");
                                    for (var i = 0; i < data.length; i++) {
                                        thirds.append("<option value='" + data[i].major_id + "'>" + data[i].major_name + "</option>");
                                    }
                                }
                            })

                        });
                    });