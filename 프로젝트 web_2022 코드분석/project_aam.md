# compagGrid
```
+ @rowClicked="onRowClicked" : @rowClicked이벤트를 사용하면 click을 하게되면 row의 Node정보가 들어온다.
```


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

# JavaScript cellRenderer
```

```

# map() 반복문
```

```
# filter()
```

```
# includes()
```

```
# Reduce()
```

```

# Draggable (리스트 드래그로 순서 변경)
```
 참고사이트 : https://avengersrhydon1121.tistory.com/277
 속성 참고사이트 : https://theheydaze.tistory.com/316
```
# Transfer (데이터 이동 리스트)
```
 참고사이트 : https://element.eleme.io/#/en-US/component/transfer
```
# Dialog (Modal)
```

```
# Nested Dialog (중첩 모달)
```
 참고사이트 : https://element.eleme.io/#/en-US/component/dialog#attributes
```

# splitpanes(분할 창)
```
	+ 사용방법 = CDN 다운로드, 사용할 컴포넌트에 가져오기
		import { Splitpanes, Pane } from 'splitpanes'
		import 'splitpanes/dist/splitpanes.css'
	참고 사이트 => https://orefalo.github.io/svelte-splitpanes/?ref=madewithsvelte.com
```
# $nextTick()
```
	+ DOM이 변경되기도 전에 DOM에 접근하려고 하면 찾지 못하여 undefined 이슈 발생한다. $nextTick() 콜백 함수를 사용하면 데이터가 모두 갱신된 다음에 그 다음 함수를 수행한다.
	+ Javascript의 비동기 처리 특성때문에 DOM을 탐색하거나 수정하는 로직이 있을경우, DOM이 갱신 되기전에 DOM을 탐색해서 undefined나 null 에러가 발생하는 경우가 있다.
		이 때문에 DOM에 모든 변경사항이 완전히 반영된 후에 사용자 정의 로직을 실행할 수 있도록 하는 함수이다.(TIP : $nextTick은 모든 훅에 가능하지만 DOM이 모두 완성된 후인 mounted훅에 많이 사용한다.)
```

#component is속성
```
	<!-- is 속성에 해당되는 컴포넌트가 렌더링된다. -->
	<component :is="componentId"></component>

	<!-- 동적 컴포넌트는 등록된 컴포넌트나 prop로 전달된 컴포넌트를 렌더힝 할 수 있다. -->
	<component :is="$options.components.child"></component>

	<!-- 동적 컴포넌트는 문자열로 컴포넌트를 참조할 수 있다. -->
	<component :is="condition ? 'HeaderComp' : 'FooterComp'"></component> 

	<!-- 동적 컴포넌트는 네이티브 HTML 엘리먼트를 렌더링 할 수도 있다. -->
	<component :is="href ? 'a' : 'span'"></component>

+ TIP
	◽ keep-alive를 사용하는 동적 컴포넌트
		is 속성을 사용하는 경우 다시 돌아왔을 때 계속해서 재렌더링 되어 기존의 클릭값이나 기존 데이터가 유지되지 않는다.
		그래서 처음 생성된 컴포넌트 인스턴스가 캐시되기를 원하는 경우에 <keep-alive> 엘리먼트로 감싼다.
		
		ex) <keep-alive>
				<component :is="cntComponent"></component>
			</keep-alive>
```
# DevTools 명령어
```
	- ref.ref이름.gridApi.getSelectedRows(); : ref를 클릭하여 체크상태 rows의 데이터를 불러옴.
	- appOptions.setUntactMockMode(ture) : mockMode로 전환 ==> 단축키 Alt + 0 , 되돌아오기 Alt + 1
	- appOptions.project='서버 이름' : 해당 프로젝트로 전환
	- v.name : 해당 프로젝트 이름 가져오기 
	- s.l : 해당 서버 정보 확인할 수 있음.
	- s.s : 해당 서버 데이터 json파일 다운로드
	- appOtions.baseURL : 해당 URL주소를 확인 할 수 있다.

```

# tagviews에 새로운 라우터 연결하는 방법
```
++ 라우팅
1. router > aam > index.js 에서 
	children : path 하나 더 추가 해줌 

	ex)
	  {
			path: 'main-da',
			component: () => import('@/views-aam/main-da/index'),
			name: 'MainDa',
			meta: { title: '메인2', icon: 'el-icon-document', affix: true }
		  }

2. src > views-aam > main-da > index.vue

	해당프로젝트 폴더안에 라우팅할 폴더 하나 더 생성해주고 index.vue 파일 생성해서 넣어주기 

	=> 왼쪽 nav바에 main-da 라우팅 된 것을 확인할 수 있음(nav바에 보이는 이름은 path 추가시 title로 설정했음)

	메인2 라는 이름 설정은 title 에서 해주기 
```

# ModalTest
```
+  template ==> @rowClicked = "onSelectedRows"


	methods ==>	onSelectedRows(rowNode){
					this.selectedModal = rowNode.data
					this.handleOpenModal(this.selectedModal.modal_name, true)
				}
	
	// rowClicked = row를 클릭하게 되면 onSelectedRows(rowNode) 함수 실행하여
		해당 로우의 NodeData가 rowNode에 대입된다.
		rowNode.data를 이용하여 rowData에 접근할 수 있다.
		rowData를 이용하여 modal창을 열어주는 함수(handleOpenModal)에 접근할 수 있다.
		이렇게되면 클릭 한번으로 여러개의 이벤트를 사용할 수 있다.(단, 이벤트 안에 실행되는 이벤트의 함수는 존재 하여야한다.)
		
	// 한번의 이벤트 실행으로 n개의 함수를 실행하고 싶다면 메소드에 n개의 함수를 작성 후 이벤트실행 함수안에 n개의 함수를 넣어서 활용하라
```

# formatterTypeStyle(params) {}
```
+ Grid를 사용하는 곳에서 사용! 속성 설정에서 사용!
+ table의 속성에서 특정 cell의 원하는 이벤트 등을 함수로 설정해주어서 row 설정에 " cellStyle: this.formatterTypeStyle " 으로 작성하면 table의 정보가
	params(매개변수)에 들어가게 된다. ' params.원하는 정보 '를 설정해주어서 사용하면 된다.
	
	ex) formatterTypeStyle(params) {
		  if (params.data.related_alarm) {
			return { color: 'red !important', 'font-weight': 800 }
		  }
		}
```

