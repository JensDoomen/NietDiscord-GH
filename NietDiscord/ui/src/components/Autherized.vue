<template>
<h1>Am i Autherized?</h1>
  <button @click="submitToken">Autherize</button>
  <div class="listContainer">
  <List>

</List>
</div>


<TextBox></TextBox>
</template>

<script>
import axios from 'axios'
import List from '@/components/List.vue'
import TextBox from '@/components/TextBox.vue'
import ChatBox from '@/components/ChatBox.vue'
import Message from '@/components/Message.vue'
import Nav from '@/components/Nav.vue'


export default {
  name: "Autherized",
  components: { List, TextBox, ChatBox, Message, Nav },
  data(){
    hoverFriend: false
  },
  methods:{
   submitToken(){

     const token = localStorage.getItem("token");

     const config = {
       headers: { Authorization: `Bearer ` + token }
     };

     axios.get("https://localhost:44347/Authentication/auth",  config)
         .then((response) => {
           console.log(response.data);
         })
   }
  }
}
</script>

<style scoped>

</style>