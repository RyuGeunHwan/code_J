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
            if(this.newTodoItem !== ''){
                var value = this.newTodoItem && this.newTodoItem.trim();
                localStorage.setItem(value, value);
                this.clearInputbox();
            }else{
                console.log('빈칸빈칸');
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



