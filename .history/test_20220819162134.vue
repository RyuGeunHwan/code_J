
    <template>
         <div id="app">
        <div>{{ msg }}</div>
        <div>{{ msgCaching }}</div>
        <div>{{ msgCaching }}</div>
    </div>
    </template>
   
    
    <script>
        const vm = new Vue({
            el: '#app',
            data: {
                msg: 'abc'
            },
            
            computed: {
                msgCaching : {
                    get () {
                        return this.msg.split('').reverse().join('')
                    },
                    set (value) {
                        this.msg = value
                    }
                }  
            }
        })
    </script>
