const WebSocket = require('ws');

const PORT = 5000;

const wsServer = new WebSocket.Server({
    port: PORT
});

wsServer.on('connection', function (socket) {
    //feedback op de console
     console.log('A client just connected')

     //gedrag van de binnengekomensocket
     socket.on('message', function(msg) {
         console.log("Recieved message from client: " + msg);
         //socket.send("Take this back: " + msg);

         //Broadcast message to all connected clients
         wsServer.clients.forEach(function (client) {
             client.send("Someone said: " + msg);
         })

     })
})

console.log( (new Date()) + " Server is listening on port " + PORT)