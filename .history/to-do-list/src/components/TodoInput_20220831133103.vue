<template>
    <div>
        <input type="text" v-model="newTodoItem">
        <button @click="addTodo()">추가</button>
    </div>
</template>

<script>
export default {
    data(){
        return{
            newTodoItem:''
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
        addTodo(){
            if(this.newTodoItem !== ''){
                var value = this.newTodoItem && this.newTodoItem.trim();
                this.$emit('addTodo', value);
                this.clearInputbox();
            }
        },
        clearInputbox(){
            this.newTodoItem = '';
        }
    }
}
</script>

<style>

</style>



