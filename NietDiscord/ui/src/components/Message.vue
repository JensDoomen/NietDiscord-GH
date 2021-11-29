<template>
<div class="card text-white bg-dark mb-3" style="height: 10hrem" v-for="message in Messages" :key="message">
  <div class="card-header">
    {{ message.sendfrom }}
  </div>
  <ul class="list-group list-group-flush  ">
    <li class="list-group-item text-white bg-dark mb-3">{{ message.messagecontents }}</li>
  </ul>
</div>
<!--<table class="table table-striped">
    <thead>
        <tr>
            <th>
                ID
            </th>
            <th>
                sendfrom
            </th>
             <th>
                sendto
            </th>
        </tr>
    <tbody>
        <tr v-for="message in Messages" :key="message">
            <td>{{message.ID}}</td>
            <td>{{message.sendfrom}}</td>
            <td>{{message.sendto}}</td>
            <td>
                <button type="button"
                class="btn btn-light mr-1">
                </button>
            </td>
        </tr>
    </tbody>
    </thead>
</table>-->

</template>

<script>
import axios from 'axios'
export default{

data(){
    return{
        Messages:[]
    }
},
methods:{
refreshData(){
    axios.get('https://localhost:44316/api/Message')
    .then((response)=>{
        console.log(response.data)
        this.Messages=response.data;
    }).catch(
        function(error){
            console.log("testerror")

        }
    )
   
}

    
},
mounted:function(){
    this.refreshData();
}
}

</script>

<style scoped>

.card{
    width: 100%;
    height: 15%;
    margin: 0%;
    
    
}
.list-group{
    width: 100%;
    height: 15%;
   
}
.card-header{
    object-fit: fill;
    height: 25%;
    width: 10%
    
}
</style>