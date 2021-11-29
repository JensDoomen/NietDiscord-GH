<template>
    <!--<div id="chatbox">
        
    </div>-->

    <div class = "ChatBox mb-2 bg-dark text-white" >
      <h1> Xander </h1>
      <Message>

      </Message>
      <!-- <TextBox>

      </TextBox> -->


    </div>
    <!--<table class="table table-dark">
  <thead>
    <tr>
      <th scope="col">Friend</th>
      
     
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row"></th>
      <Message>

      </Message>
    </tr>
  </tbody>
</table>-->

</template>

<script>

import Message from '@/components/Message.vue'
import TextBox from '@/components/TextBox.vue'
export default{
  components:{
    Message,
    TextBox
  }
}


</script>

<style>
#chatbox{
position:absolute;
  bottom: 20%;
  left: 25%;
  width: 40%;
  height: 30%;
  background-color: white;
  border: black;
}
.table{
  background-color: white;
  position: absolute;
  bottom: 10%;
  left: 25%;
  width: 75%;
  height: 80%;
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
