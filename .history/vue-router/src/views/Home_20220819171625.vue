<!-- template태그 : HTML이 들어가는 구역  -->
<template>
  <div>
    <h1>This is Home Page</h1>
    <KossieCoder/>
    <h2>{{fullName}}</h2>
    <button @click="changeName">Click</button>
  </div>
</template>

<!-- script태그 : 옵션,데이터,computed,watch 등이 들어가는 구역 -->
<script>
import KossieCoder from '@/components/KossieCoder.vue';


export default {
  components: {
    // import한 컴포넌트를 사용하겠다는 설정
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
          alert('Setting new name: ' + newValue);
          var name = newValue.split(' '); //eslint-disable-line no-unused-vars
          this.firstName = name[0];
          this.lastName = name[1];
        }
      }
    }
}
</script>


<!-- style : CSS코드 -->
<!-- scoped를 넣어줘야 위에보이는 template의 html태그에 적용이 된다. scoped를 않넣으면 vue어플리케이션 전체에 적용이 된다.-->
<style scoped>
h1{
  color : red
}
</style>