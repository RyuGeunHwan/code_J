<template>
    <section>
        <ul>
            <li :key="todoItem" v-for="todoItem in todoItems">
            {{ todoItem }}
            <button @click="removeTodo(todoTem, index)">삭제</button>
            </li>
        </ul>
    </section>
</template>

<script>
export default {
    data(){
        return{
            todoItems:[]
        }
    },
    created(){
        if(localStorage.length>0){
            for(var i=0; i<localStorage.length; i++){
                this.todoItems.push(localStorage.key(i));
            }
        }
    },
    methods: {
        removeTodo(){

        }
    }
}
</script>

<style>

</style>



