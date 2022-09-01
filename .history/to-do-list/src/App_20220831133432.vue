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
        return {
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
    methods: {
        addTodo(todoItem){
            //로컬스토리지에 데이터를 추가하는 로직
            localStorage.setItem(todoItem, todoItem);
            this.todoItems.push(todoItem);
        }
    },    
    components: {
        'TodoHeader': TodoHeader,
        'TodoInput': TodoInput,
        'TodoList': TodoList,
        'TodoFooter': TodoFooter
    }
}
</script>

<style>

</style>


