<template>
    <section>
    <ul>
        <!-- v-for대상을 propsdata로 변경 -->
        <li v-for="(todoItem, index) in propsdata" :key="todoItem">
            {{ todoItem }}
            <button type="button" v-on:click="removeTodo(todoItem, index)">삭제</button>
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



