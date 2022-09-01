<template>
  <div id="app">
    <TodoHeader />
    <TodoInput v-on:addTodo="addTodo"></TodoInput>
    <TodoList :propsdata="todoItems"></TodoList>
    <TodoFooter />
  </div>
</template>

<script>
import TodoHeader from './components/TodoHeader.vue';
import TodoInput from './components/TodoInput.vue';
import TodoList from './components/TodoList.vue';
import TodoFooter from './components/TodoFooter.vue';

export default {
  data(){
    return{
      todoItems: []
    }
  },
 created(){
        if(localStorage.length > 0){
            for(var i = 0; i < localStorage.length; i++){
                this.todoItems.push(localStorage.key(i));
            }
        }
    },
  methods:{
    /** 데이터 추가와 전체삭제는 데이터가 있는 TodoList에 있지 않기에 새로고침을 해야 DOM이 변경된다.
     *  그런 문제점을 해결하기 위해 최상위 컴포넌트에 addTodo()라는 메소드 추가! */
    addTodo(todoItem){
      localStorage.setItem(todoItem. todoItem);
      this.todoItems.push(todoItem);
    }
  },
  components : {
    'TodoHeader' : TodoHeader,
    'TodoInput' : TodoInput,
    'TodoList' : TodoList,
    'TodoFooter' : TodoFooter,
  }
}
</script>

<style>

</style>


