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
    methods:{
        addTodo(){
            console.log(this.newTodoItem);
        }
    }
}
</script>

<style>

</style>



