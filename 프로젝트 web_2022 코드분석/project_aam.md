# modal 관련 정리
```js
Modal Component하나로 n개의 창을 띄우기 위해서 n개의 컴포넌트의 data와 property를 modalComponent에 넘겨주어여한다.

	+ index.vue
	
		- @rowDoubleClicked="(row) => { handleOpenModalRef(this.$refs.modalTemplate, row[0], situationListProperty)
			
			1. this.$refs.modalTemplate = ModalTemplate에 접근하기위해 사용
			2. row[0] = 더블클릭한 로우의 객체 즉,데이터를 가져옴
			3. situationListProperty = situationList의 속성에 대한 정의를 가져옴
			
		- handleOpenModalRef(ref, param = {}, testData) { // param = {} 의미 파악하고 param에 들어오는 데이터 수정하기
			  ref.open({ param: param, testData: testData })
			}
			
			1. ref == this.$refs.modalTemplate
			2. param = {} == row[0]  :  데이터를 Object에 넣어서 param에 대입 / 각Comp안에 한줄의 데이터(row[0])를 의미 한다.
			3. testData == situationListProperty
			4. ref.open({ param: param, testData: testData }) 함수는 modal.js에 onOpen(model,actionMode)함수 참고
			5. { param: param, testData: testData } 객체로 넘겨주는 이유는 onopen함수에 model 한개로만 파라미터를 받기 때문에.
			
	
	+ ModalTemplate.vue
		- situationL
		- async onOpen(model, actionMode) {
			  this.situationL = model.testData
			  this.bladeInfo = await this._cloneDeep(model.param)
		  }
		  1. model안에 { param: param, testData: testData } 객체가 들어가 있는거임. 그래서 model.testData / model.param 사용가능
			1-1) modal.js에서 open, onOpen 함수 참고
```

# removeData 관련
```
+ map() 반복문
+ filter()
+ includes()

```
