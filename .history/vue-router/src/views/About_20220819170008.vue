<template>
  <div class="about">
    <h1>This is an about page</h1>
    <h2>이곳은 어바웃 페이지입니다.</h2>
    <KossieCoder/>
    <h1>{{message}}</h1>
    <button @click="changeName">Click</button>
  </div>
</template>

<script>
import KossieCoder from '@/components/KossieCoder.vue';

export default {
  components:{
    KossieCoder
  },
  name : 'App',
  data(){
    return{ 
      firstName : 'Ryu',
      lastName : 'geunhwan',
    };
  },
  methods : {
    changeName(){
      this.fullName = "nin ano";
    }
  },
  computed:{
    fullName: {
        get:function(){
          console.log('3번');
          return this.firstName+''+this.lastName;
        },
        set: function(newValue){
          var name = newValue.split(' ');
        }
      }
    }
  }

</script>