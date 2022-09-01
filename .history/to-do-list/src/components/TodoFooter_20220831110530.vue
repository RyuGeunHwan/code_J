<template>
    <button type="button" @click="clearTodo">전체삭제</button>
</template>

<script>
export default {
    methods : {
        clearTodo(){
            localStorage.clear();
        }
    }
}
</script>

<style>

</style>



