<template>
<!--
  <div id="messageBox">
  <input type="text" ref="message" class="textBox">
  
 </div>-->
<div class = "ChatBox mb-2 bg-dark text-white" id="log" >
      <h1> group1 </h1>
      <!-- {{ messages[0] }}  -->
      <li v-for="item in messages" :key="item.data">
       {{ item }}
      </li>
     


    </div>

<div class="input">
  <input type="text" class="form-control" placeholder="message" aria-label="Message" id ="text" v-model="message" @keyup.enter="sendMessage">
  <button type="button" class="btn btn-secondary" v-on:click="sendMessage">Send</button>
  <!--<button class="btn btn-outline-secondary" type="button" id="button">Send</button>-->
</div>
</template>
 
 
<script>


   

import { Text } from '@vue/runtime-core';
//import func from 'vue-editor-bridge';
   export default {
  name: 'TextBox',
  
  data(){
   return{
     
     //log: document.getElementById('log'),
     //message: document.getElementById('message').value,
       message: '',
       messages: [],
     //name: prompt('your name?'),
     //ws: null
     socketOpen: false,
     connection: null,
     

   }
  },
  mounted: function(){
      const ws = new WebSocket("ws://localhost:5002")
      this.ws = ws
      this.ws.addEventListener("open", () => {
        console.log("We are connected!");
        this.ws.addEventListener("message", e => {
      //   var reader = new FileReader();
      //   reader.onload = function() {
      //   alert(reader.result);
      // }
      // var text = reader.readAsText(e.data);
      // console.log(e.data)

        console.log(e)
        //this.messages.push(this.name +":"+" " + this.message)
        if(this.message !== ''){
          // this.messages.push(this.message)
           this.message = '';
        }
      if(this.message !== e.data){
        this.messages.push(e.data)

      }
        
      })

      })},
  

  methods: {
    
    sendMessage(e){
      e.preventDefault();

      console.log(this.messages)
      console.log(this.message)
      console.log(this.name)

      // this.ws.onopen = function () {
      //   console.log("Websocket connectie open")
      //  this.ws.send(this.message)
      // }
      this.ws.send(this.message);

      

      this.ws.onmessage = (event)=>{
        //this.socketOpen = true;
        this.message = event.data
        console.log(event.data)
      }

      //alert(this.message);
      //console.log(this.message)
      //console.log(this.name)
      //this.messages.push(this.message)
      //axios.post('https://localhost:44316/api/Message')
       
  
        //this.ws.send(this.message);
  
    //this.ws.addEventListener("message", e => {
       // console.log(e);
      //console.log(e)
      //this.messages.push(e.data)

    //})
  //     var sock = new WebSocket("ws://localhost:5002");
  //     var log = document.getElementById('log');
  //      sock.onopen = function() {
  //       sock.send(JSON.stringify({
  //         type: "name",
  //         data: name
  //       }))
  //     }
    
    //  this.ws.onmessage = (event) =>{
    //  console.log(event.data);
     //var json = JSON.parse(event.data);
     //this.message=event.data
    // }

  //    log.innerHTMl +=json.name+ ": " + json.data+"<br>";
  //   }
    
  //   document.querySelector('button').onclick = function(){
  //   var text = document.getElementById('text').value;
  //   //sock.send(message);
  //   sock.send(JSON.stringify({
  //     type: "message",
  //     data: text
    
   
  //   }));
  //   log.innerHTMl +="You:" + text+"<br>";
  //   // const message = "You:" + this.message;
  //   // this.messages.push(message)
  // };
   }
   }
   }
   
</script>

<style>
#messageBox{
  position:absolute;
  bottom: 2%;
  left: 25%;

}
.input{
  position:absolute;
  bottom: 3%;
  left: 25%;
  width: 75%;
}

.textBox{
  width: 700%;
  height: 1000%;
}
#chatbox{
position:absolute;
  bottom: 20%;
  left: 25%;
  width: 40%;
  height: 30%;
  background-color: white;
  border: black;
}
.ChatBox{
  background-color: white;
  position: absolute;
  bottom: 10%;
  left: 25%;
  width: 75%;
  height: 83.8%;
}

</style>