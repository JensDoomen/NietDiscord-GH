<template>
<Nav
    :authorized="this.isAuthorized"
    v-on:clearToken="clearToken"
/>
<!--
  <div class="navContainer"></div>
  <div class="navBar"></div>
  <div class="logoContainer"></div>
<div class="logo"></div>
-->

<!-- <nav class="navContainer">
  <div class="container-fluid">
    <button><router-link class="nav-link" to="/Inlog">Sign in</router-link></button>
    <div class="logoContainer"><img class="logo" src="./assets/knipsel.png"></div>
   
  </div>
  
</nav> -->
 <main class="form-signin">
   <router-view
       v-on:setToken="setToken"
       v-on:clearToken="clearToken"
   />
  </main>
<!--<div class="listContainer">
  <List>

</List>
</div>


<TextBox></TextBox>-->

</template>

<script>
// import List from './components/List.vue'
// import TextBox from './components/TextBox.vue'
// import ChatBox from './components/ChatBox.vue'
// import Message from './components/Message.vue'
import Nav from './components/Nav.vue'

export default {
  name: 'App',
  // components: { List, TextBox, ChatBox, Message, Nav },
  components: { Nav },
  data(){
    hoverFriend: false
  },
  methods:{
    
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #212529;
  margin-top: 0px;
}
.listContainer{
 display: inline;
}
.navContainer{
 position: -webkit-sticky; /* Safari */
  position: sticky;
  top: 0;
  background-color: #fff;
  width: 100%;
}
.navBar{
display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: space-between;
  width: 100%;
  height: 50px;
  box-shadow: 0 2px 10px rgba(88, 88, 88, 0.16);
  overflow: hidden;
  align-content: center;
  background-color: white;
  
}
.logoContainer{
  background-color: white;
   max-width: 100px;
    width: 20%;
    height: 90%;
    margin: 0px;
    margin-left: 0px;
    cursor: pointer;
    display: flex;
    align-self: left  ;
    
}
.logo{
      height: 50px;
      width: 50px;
      margin: 0px;
      align-self: left ;
      padding: 0px;
}
.nav-link{
   height: 50px;
      width: 100px;
      margin: 0px;
      align-self: right ;
      padding: 0px;
}

</style>
