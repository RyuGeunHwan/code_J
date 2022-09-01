<template>
    <section>
        <ul>
            <li :key="todoItem" v-for="(todoItem, index) in todoItems">
            {{ todoItem }}
            <button type="button" @click="removeTodo(todoItem, index)">삭제</button>
            </li>
        </ul>
    </section>
</template>

<script>
export default {
    created(){
        if(localStorage.length > 0){
            for(var i = 0; i < localStorage.length; i++){
                this.todoItems.push(localStorage.key(i));
            }
        }
    },
    //props속성 추가
    props: ['propsdata'],
    methods: {
    	removeTodo(todoItem, index){
            localStorage.removeItem(todoItem);
            this.todoItems.splice(index, 1);
        }
    }    
}
</script>

<style>

</style>



