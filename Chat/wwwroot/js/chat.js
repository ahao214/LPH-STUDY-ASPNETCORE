// 创建并启动连接
let conn = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
$("#btnSend").attr("disabled", true);
conn.start().then(function () {
    $("#btnSend").attr("disabled", false);
}).catch(function (err) {
    alert("链接signalR服务器失败")
    return console.log(err)
})


// 发送信息
$("#btnSend").click(function () {
    let user = $("#user").val()
    let msg = $("#msg").val()
    conn.invoke("SendMsg", user, msg).catch(function (err) {
        return console.log(err)
    })
})


// 接收信息
conn.on("Receivemsg", function (user, msg) {
    let li = `<li>${user}:${msg}</li>`
    $("#msgs").append(li)

})