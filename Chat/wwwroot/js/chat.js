// 创建并启动连接
let conn = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
conn.start();


// 发送信息


// 接收信息