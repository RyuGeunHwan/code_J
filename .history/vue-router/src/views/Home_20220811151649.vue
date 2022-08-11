<!-- template태그 : HTML이 들어가는 구역  -->
<template>
  <div>
    <h1>This is Home Page</h1>
    <p>{{name}}</p>
    <KossieCoder>
  </div>
</template>

<!-- script태그 : 옵션,데이터,computed,watch 등이 들어가는 구역 -->
<script>
import KossieCoder from '@/components/KossiCoder.vue';


export default {
  components: {
    // import한 컴포넌트를 사용하겠다는 설정
    KossieCoder
  },
  data(){
    return{
      name : 'Kossie Coder'
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