# 배포PC 
	원격연결
		> mstsc /v 192.168.10.5
		> codej / codej12#$
	자료
		> explorer D:\인수인계\NIA

# 2021 KOREN 자율형 네트워크 고도화 (사업명:자율형 네트워크 기술 실증 2차)

### devTools 정보 조회 명령어 
$tools.store // SingletonStore 정보 조회
angular.element($0).scope() // scope info 조회
angular.element($0).controller().constructor.name //template name(route name) 조회

# 2022년 개발 우선순위
	> explorer  D:\Work\NIA\_2022_자료\10. 개발방향\KOREN 자율형 네트워크_AI NMS 기능 개략 설계.pptx
		 p14. iP SDN 장비 트래픽 감시 및 이력 조회
		 p15. iP SDN 장비 부하율 감시 및 이력 조회
		 p9. IP SDN 경로 조회 
		   & p28.	SOP 관리 항목 등로/수정/삭제 화면
				장애 대응 기능 개선 * 조치SOP 에 조회 쿼리 변경
		 p29.	SOP 관리 화면에서 이력 수정 


# 할당받은 IP
	사용가능IP 210.114.91.178~190
	서브넷 255.255.255.240
	게이트웨이	210.114.91.177
	KOREN DNS 	203.255.250.101 or 103

"SELECT DISTINCT
            to_timestamp(perf.INTTIMESTAMP) as collect_time
            , COALESCE(perf.fltbpsin, 0) as fltbpsin /* 입력 bps */
            , COALESCE(perf.fltbpsout, 0) as fltbpsout /* 출력 bps */
            , COALESCE(perf.fltppsin, 0) as fltppsin /* 입력 pps */
            , COALESCE(perf.fltppsout, 0)  as fltppsout /* 출력 pps */
            , COALESCE(perf.fltusage, 0) as fltusage/* 사용율 */
        FROM ip_yd.xe_cvnms_perf_if perf
        WHERE perf.strresid = ( SELECT DISTINCT node_num FROM resource.tb_node_mst WHERE node_id = 'seoul-5812')
        AND perf.strifid = ( SELECT DISTINCT if_num FROM resource.tb_port_mst WHERE node_id = 'seoul-5812' AND if_id = 'xe24' )
        AND to_timestamp(perf.INTTIMESTAMP) between '2022-09-22 06:02:07'::TIMESTAMP - interval '1 hour' AND '2022-09-22 06:02:07'::TIMESTAMP + interval '1 hour'
[SELECT_ATT_TRAFFIC_LIST] => list size: 27, Elapsed Time: 0.101 second"

4: {elapsed: '[SELECT_ATT_TRAFFIC_LIST] => list size: 27, Elapsed Time: 0.101 seconds', timestamp: '2022-09-22 15:39:06', service: 'SELECT_ATT_TRAFFIC_LIST', input: {…}, output: Array(27), …}

{
    "elapsed": "[SELECT_ATT_TRAFFIC_LIST] => list size: 27, Elapsed Time: 0.101 seconds",
    "timestamp": "2022-09-22 15:39:06",
    "service": "SELECT_ATT_TRAFFIC_LIST",
    "input": {
        "FAULT_TIME": "2022-09-22 06:02:07",
        "LVL": 7,
        "INTERFACE": "xe24",
        "service": "rca",
        "NODE": "seoul-5812",
        "action": "SELECT_ATT_TRAFFIC_LIST",
        "is_intercept_sql": true
    },
    "output": [
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:02:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:07:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:12:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:17:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:22:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:27:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:32:09",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:37:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:42:08",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:43:28",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:47:08",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:52:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 05:57:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:02:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:07:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:12:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:17:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:22:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:27:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:32:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:37:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:42:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:43:28",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:47:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:52:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 06:57:07",
            "fltppsout": 0
        },
        {
            "fltusage": 0,
            "fltppsin": 0,
            "fltbpsout": 0,
            "fltbpsin": 0,
            "collect_time": "2022-09-22 07:02:07",
            "fltppsout": 0
        }
    ]
}

# 코드
	https://github.com/codejone/2021_nia.git

## 수정요청사항
	+2022-09-06 
		- 노드관리 > 상세 수정불가
			포트 > 수정불가, 등록불가
		- 이용기관 > 상세
			고객ID	, 담당E-mail, IP등록	제외하고 수정불가
	
## 발표자료
	https://youtu.be/TMsRTBLisEM

## GIT
	https://github.com/codejone/2021_nia.git
	D:\Work\NIA\workspace\2021_nia
	
# Nia 임시 외부 포트 전달드립니다 2022-04-04 15:53:38
	SSH 	codej.iptime.org:9999
	DB	codej.iptime.org:9998
	MQ 	codej.iptime.org:9997
	MQ UI 	codej.iptime.org:9996
	UI1(8080)	codej.iptime.org:9995
	UI2(8081)	codej.iptime.org:9994
	UI3(8082)	codej.iptime.org:9993
	
## 향지PC 
	192.168.10.7
	codej / codej12#$

## WEB 접속
	### 2022-03-14일 이후 버전
	IP: 116.89.191.47
	계정: codej8888
	비번: zhfps! // 코렌!
	포트: 16891
	
	116.89.191.47:8080
	admin / admin

	mq 포트: 6786
	db 포트: 6544
	
	* 방화벽
		$ sudo su //코렌!
		$ [방화벽 설정:] 참고
		
	/*
	### 2022-03-14일 이전 버전
	내부접속: //10.81.192.18:8080/
	외부접속: //210.114.91.190:8080
	ETRI: //116.89.186.194:8080 
	admin/admin
	
	# NIA 외부 접속 URL
	url: 210.114.91.190:8080
	id: admin
	pw: admin
	
	+ NIA 서버
	10.81.192.18
	10.81.192.19
	10.81.192.20
	user: root
	passwd: gideoddl0913 (향댕이0913)
	*/
		
## NIA Server Start
	$ sudo su
	코렌!
	$ service rabbitmq-server start
	$ cd /home/codej8888/server/bin
	$ sh aiPerformanceLinkage.sh start; sh aiResultLinkage.sh start; sh aiServer.sh start; sh cluster.sh start; sh djangServer.sh start; sh engine.sh start; sh ipAiTrafficePreprocessor.sh start; sh ipAlarmLinkage.sh start; sh ipEquipLinkage.sh start; sh ipPerfLinkage.sh start; sh ipPreprocessor.sh start; sh ipSflowLinkage.sh start; sh ipSimulator.sh start; sh ipSyslogLinkage.sh start; sh performanceAp.sh start; sh pingPreprocessor.sh start; sh potnAlarmLinkage.sh start; sh preprocessor.sh start; sh rcaToAiDataLinkage.sh start; sh simulator.sh start; sh emsLinkageLog.sh start; sh emsLinkageMonitoring.sh start; sh emsLinkage.sh start;
	$ cd ../logs; ll *06-29*
	$ ps -elf | grep java
		
# console debug
{
	 angular.element($0).scope()
	 angular.element($0).injector().get('$state')
	 angular.element($0).injector().get('$state').go('some-state')
	 angular.element($0).controller().constructor.name
	 
	 $tools.statego('rca.monitoring_tt');
	 $tools.statego('road_show');
	 
}

# 그래프
	안녕하세요 김영민 대표님
	제로원에이아이 임세규 연구원입니다.

	지난 회의에서 말한 UI에 추가할 그래프 iframe 입니다
	### 파일 이상 여부(사이즈 한정)를 시각화 및 실시간
	<iframe src="http://211.253.28.146:3000/d-solo/LBlvJ7p7z/server_status?orgId=1&refresh=1m&panelId=4" width="1200" height="200" frameborder="0"></iframe>
	#### memory 사용량
	<iframe src="http://211.253.28.146:3000/d-solo/LBlvJ7p7z/server_status?orgId=1&refresh=1m&panelId=6" width="1200" height="200" frameborder="0"></iframe>
	#### ip 시설 정보 
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=1" width="450" height="200" frameborder="0"></iframe>
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=5" width="450" height="200" frameborder="0"></iframe>
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=7" width="450" height="200" frameborder="0"></iframe>
	#### 전송 시설 정보
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=2" width="450" height="200" frameborder="0"></iframe>
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=3" width="450" height="200" frameborder="0"></iframe>
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=4" width="450" height="200" frameborder="0"></iframe>
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=8" width="450" height="200" frameborder="0"></iframe>
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=9" width="450" height="200" frameborder="0"></iframe>
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=10" width="450" height="200" frameborder="0"></iframe>
	#### sflow
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=12" width="450" height="200" frameborder="0"></iframe>
	#### 광세기
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=6" width="450" height="200" frameborder="0"></iframe>
	#### 트래픽
	<iframe src="http://211.253.28.146:3000/d-solo/n1t_aBK7k/file_size?orgId=1&panelId=11" width="450" height="200" frameborder="0"></iframe>


	### 데이터 Value 시각화 및 실시간
	#### 광세기
	<iframe src="http://211.253.28.146:3000/d-solo/XB7JYac7z/koren_data_all?orgId=1&panelId=6" width="1200" height="200" frameborder="0"></iframe>
	#### 트래픽
	<iframe src="http://211.253.28.146:3000/d-solo/XB7JYac7z/koren_data_all?orgId=1&panelId=4" width="1200" height="200" frameborder="0"></iframe>
	#### sflow
	<iframe src="http://211.253.28.146:3000/d-solo/XB7JYac7z/koren_data_all?orgId=1&panelId=2" width="1200" height="200" frameborder="0"></iframe>

# TODO
	+ 쿼리정리
		1. SELECT_NIA_CABLE_ALARM_LIST 는 왜 하드 코딩인지?
		2. SELECT_NIA_ALARM_LIST 결과에서는 왜 2번째 데이터를 related_alarm 로 하는지?
		3. SELECT_NIA_TOPOLOGY_CABLE_LIST 나 SELECT_NIA_PF_TOPOLOGY_CABLE_LIST 의 결과가 없으면 어떤 장애를 표시해야 하는지?
	+ 갈곳 없는 전표 -  전국표시
		10877 : daejeon-n9k
		10888 : 192.168.200.216	, 선로장애, document.getElementById('node_192.168.200.216')

	+ n9k 처리
	+ 이용고객 처리
	+ IP 장비에 대한 형상정보 처리
		1. 형상 이미지 작업
		2. 장애 슬롯 정보??  rca.tb_alarm_cur_mst의 alarmloc, slot 에는 정보가 없다
	+ node / link db 데이터 처리

# 토폴로지 쿼리2 
	select * from TB_TOLOLOGY

	/* 토폴로지 노드 조회 */
	select 	--7712/5812 장비 
		nm.node_id 
		, nm.node_nm 
		, '4' device_type
		, row_number() over () as index
		, 420 fx
		, 420 fy
	from resource.tb_node_mst nm
	where nm.node_id like '%7712' or nm.node_id  like '%5812'or nm.node_id  like '%n9k%'
	union all  
	select 	--n9k 장비 
		nm.node_id id
		, nm.node_nm device_name
		, '4' device_type
		, 100 + row_number() over () as index
		, 420 fx
		, 420 fy
	from resource.tb_node_mst nm
	where nm.node_id  like '%n9k%'
	union all 
	select -- 전송장비 (POTN/ROADM)
		em.tid
		, em.sysname 
		, case model when 'Utrans-6300p-H3' then '1' when 'Utrans-6300p-V9' then '0' else '2' end device_type
		, 100 + row_number() over () as index
		, 420 fx
		, 420 fy
	from nia.tb_equip_mst em

	/* 토폴로지 링크 조회 (전송) */
	select 
		row_number() over () as id
		, es.sysname as source_name
		, es.tid as source_id
		, et.sysname as target_name
		, et.tid as target_id
		, 'UP' as status
		, tp.equip_type as equip_type
		, ptpnamea_bau as source_port_disp
		, ptpnamez_bau as target_port_disp
	from NIA.tb_topology tp
	inner join nia.tb_equip_mst es on replace (tp.sysnamea,'-SH1','') = es.tid
	inner join nia.tb_equip_mst et on replace (tp.sysnamez,'-SH1','') = et.tid
	;

	/* 토폴로지 링크 조회 (IP) */
	select
		  100 + row_number() over () as id
		, bl.src_node_id as source_name 
		, bl.src_node_id as source_id
		, bl.dest_node_id as target_name
		, bl.dest_node_id as target_id
		, 'UP' as status
		, '' as equip_type
		, src_if_id as source_port_disp
		, dest_if_id as target_port_disp
		, 1 as linkDistance
	from resource.tb_backbone_link bl
	inner join resource.tb_node_mst ns on ns.node_id = bl.src_node_id
	--inner join resource.tb_node_mst nd on nd.node_id = bl.dest_node_id
	where ns.node_id like '%7712' or ns.node_id  like '%5812' or ns.node_id  like '%n9k'
	order by id

	select * from resource.tb_node_mst ns
	where ns.node_id like '%7712' or ns.node_id  like '%5812' or ns.node_id  like '%n9k'

	select * from resource.tb_backbone_link bl
	where src_node_id like '%7712' or src_node_id  like '%5812' or src_node_id  like '%n9k'

	/* 토폴로지 링크 조회 (IP-전송POTN) */
	select * from nia.tb_e2e_topology teet 



	/* 티켓별 tb_alarm_cur_mst (RELATED_ALARM 필드 추가) */
	WITH sub_ticket_alarm AS
			( SELECT T.*,
					AL.ticket_al_id,
					AL.root_cause_alarm_noa,
					AL.root_cause_alarm_noz
			FROM    RCA.TB_RCA_TICKET_CURRENT T
			LEFT OUTER JOIN
					( SELECT SUB_AL.* ,
							ROW_NUMBER() OVER (PARTITION BY SUB_AL.TICKET_ID ORDER BY TICKET_AL_ID DESC) AS ORDER_NUM
					FROM    RCA.TB_RCA_TICKET_AL_CURRENT SUB_AL ) AL ON T.TICKET_ID = AL.TICKET_ID AND AL.ORDER_NUM = 1
			)
	SELECT  T.ALARMNO AS ALARMNO,
			T.CLUSTERNO AS CLUSTERNO,
			T.TMP_CLUSTER_NO AS TMP_CLUSTER_NO,
			T.SYSNAME AS SYSNAME,
			T.EQUIPTYPE AS EQUIPTYPE,
			T.ALARMTIME AS ALARMTIME,
			T.RECEIVETIME AS RECEIVETIME,
			T.ALARMLOC AS ALARMLOC,
			T.ALARMMSG AS ALARMMSG,
			T.UNIT AS UNIT,
			T.ALARMLEVEL AS ALARMLEVEL,
			T.CLUSTERNO_ORIGINAL AS CLUSTERNO_ORIGINAL,
			T.CLEARTIME AS CLEARTIME,
			T.PTPNAME AS PTPNAME,
			T.SLOT AS SLOT,
			T.PORT AS PORT,
			CASE WHEN ta.root_cause_alarm_noa IS NULL AND ta.root_cause_alarm_noz IS NULL THEN true ELSE false
			END RELATED_ALARM
	FROM    rca.tb_alarm_cur_mst T
	LEFT OUTER JOIN sub_ticket_alarm ta ON T.clusterno = ta.cluster_no
	WHERE   T.CLUSTERNO = '18762'
	

# 토폴로지 쿼리
	select * from TB_TOLOLOGY

	select 
		nm.node_id as id
		, nm.node_nm as sysname
		, nm.ip_addr as ip_addr
		, '4' as node_type
	--	, np.node_type 
		, np.node_image_path
		, np.fx 
		, np.fy
	from resource.tb_node_mst nm
	inner join resource.tb_node_position_info np on np.node_id = nm.node_id and np.topology_type ='1'
	where nm.node_id like '%7712' or nm.node_id  like '%5812'
	union all 
	select 
		em.tid	as id
		, em.sysname  as sysname
		, em.tid as ip_addr
		, case model when 'Utrans-6300p-H3' then '1' when 'Utrans-6300p-V9' then '0' else '2' end as node_type
	--	, np.node_type 
		, np.node_image_path 
		, np.fx 
		, np.fy
	from nia.tb_equip_mst em
	inner join resource.tb_node_position_info np on np.node_id = em.tid and np.topology_type='2'
	; 

	/* IP 링크 */
	select
		  row_number() over () as id
		, concat('link_',row_number() over ()) as element_id
		, bl.src_node_id as source_name 
		, bl.src_node_id as source_id
		, row_number() over (partition by bl.src_node_id order by bl.src_node_id, bl.src_if_id) source_dir
		, bl.src_if_id as source_bau 
		, bl.src_if_id as source_pau
		, bl.dest_node_id as target_name
		, bl.dest_node_id as target_id
		, row_number() over (partition by bl.dest_node_id order by bl.dest_node_id, bl.dest_if_id) target_dir
		, bl.dest_if_id as target_bau
		, bl.dest_if_id as target_pau
		, 'UP' as state
		, '' as equip_type
		, ''
	from resource.tb_backbone_link bl
	inner join resource.tb_node_mst ns on ns.node_id = bl.src_node_id
	inner join resource.tb_node_mst nd on nd.node_id = bl.dest_node_id
	where NS.node_id like '%7712' or ns.node_id  like '%5812'
	; 

	select 
		row_number() over () as id
		, concat('link_',row_number() over ()) as element_id
		, es.sysname as source_name
		, es.tid as source_id
		, row_number() over (partition by tp.sysnamea order by tp.sysnamea, tp.ptpnamea_bau) source_dir
		, tp.ptpnamea_bau as source_bau 
		, tp.ptpnamea_pau as source_pau
		, et.sysname as target_name
		, et.tid as target_id
		, row_number() over (partition by tp.sysnamez order by tp.sysnamez, tp.ptpnamea_bau) target_dir
		, tp.ptpnamea_bau as target_bau 
		, tp.ptpnamea_pau as target_pau
		, 'UP' as state
		, tp.equip_type as equip_type
		, ''
	from NIA.tb_topology tp
	inner join nia.tb_equip_mst es on replace (tp.sysnamea,'-SH1','') = es.tid
	inner join nia.tb_equip_mst et on replace (tp.sysnamez,'-SH1','') = et.tid
	;

# 핑시험 #PING TEST
	<dependency>
		<groupId>com.jcraft</groupId>
		<artifactId>jsch</artifactId>
		<version>0.1.55</version>
	</dependency>

	sshSession.init();
	System.out.println(sshSession.exec("ping 116.89.161.220 -c 5"));
	sshSession.disconnection();

# NIA 진행 사항
7. 조치 프로파일 관리 (신규)
	7.1 조치 프로파일 조회 및 등  50%
		메일자동발송 - 신규티켓 발생 시 메일 보냄
		설정 항목 - 어떠한 티켓발생(조건) 시  누구(대상)에게 메일 발송
	7.2 자가 회복을 위한 프로파일 관리(공사 구분 포함) 30% 
	7.3 자가 구성을 위한 프로파일 관리(공사 구분 포함) 30%
8. 이력조회 (수정)
	8.1 장애 대응 Process (수동-자가구성) 0%
		시험 - NOC API 호출. 구체적인 방안은 NOC에서 주기로 함
	8.2 장애 대응 Process (수동-자가회복) 0%
	8.3 장애 대응 Process(Ticket 마감) 0%
	8.4 처리결과(SOP) 조회 0%
9. 데이터 관리 (신규)
	9.1 데이터 스냅샷 - 없음
	9.2 노드 리스트 100%
		대상 : IPSDN 연동(수정삭제 불가) + 사용자 등록(수정삭제 가능)
		토폴로지 표시 - 위치정보??
	9.3 노드 등록 100%
	9.4 노드 상세보기 100%
	9.5 포트 상세보기 80%
	9.6 링크 리스트 100%
		토폴로지 표시
	9.7 링크 등록 100%
	9.8 링크 상세보기 100%
	9.9 이용기관 리스트 100%
		티켓정보 표시에 이용
		티켓 데이터와 맵핑 방법?
	9.10 이용기관 등록 100%
	9.11 이용기관 상세보기 100%
10. 토폴로지 수정
	기존 전송레이어 + IP 레이어
	토폴로지 레이어 구성 ? 
	노드위치수정 방법 ?
	
## 목표
KOREN IP 백본망 트래픽 감시 및 장애 분석을 위한 AI 관제 시스템 구축
 - KOREN IP 백본망 장애 발생 시 운용자 개입없이 신속한 장애 감지와 근원장애 원인과 발생위치를 분석하는 자가 회복(Self-Healing) 기반 구축
 - 운용자 개입없이 IP 백본망의 이상 트래픽을 탐지하고 장애 발생 시 기 구축된 IP-SDN과의 연계를 통해 스스로 조치가 가능한 자가 구성(Self-Configuration) 기반 구축
 - KOREN 전송망과 IP 백본망 통합 감시를 위한 AI기반 통합 장애 대응 프로세스 구축

## 수행 내용 상세
1. KOREN IP 백본망 운용 데이터 분석 및 원천 데이터 저장 기능 개발
      - AI 데이터 처리를 위한 KOREN IP 백본망 화이트 장비의 경보(알람,syslog), 트래픽 데이터 분석 및 수집체계 구축
      - KOREN IP 백본망 화이트 장비의 시설 데이터 분석 및 수집 체계 구축
      - 시설 데이터 분석을 통한 토플로지 구축
      - 구축된 시설, 토플로지, 경보, 트레픽 데이터를 빅데이터 플랫폼에 제공
2. AI 기반 IP 백본망 장애 분석 엔진 개발(self-healing 기반 구축)
      - 화이트박스 장비의 경보 데이터 정규화 및 시간 정보를 활용한 경보 그룹핑 기능 개발
      - 그룹핑 경보의 장애 패턴 분석 및 근원장애 추출을 위한 비학습형 Analytics AI 모델 개발
      - KOREN 전송망과 IP 백본망 멀티 도메인 근원장애 분석 엔진 개발 
      - KOREN AI 관제 시스템 내 IP 백본망의 실시간 경보 분석을 위한 근원장애 분석 AI 모델 통합 운용 체계 구축
3. AI 기반 IP 백본망 트래픽 감시 엔진 개발(Self-configuration 기반 구축)
      - AI 기반 화이트박스 장비 트래픽 감시를 위한 데이터 전처리 기능 개발
      - KOREN IP 백본망 이상 트래픽 탐지를 위한 AI 모델 개발
      - KOREN AI 관제 시스템 내 IP 백본망의 실시간 트래픽 이상탐지를 위한 성능 감시 AI 모델 운용 체계 구축 
4. KOREN 전송망과 IP 백본망 통합 감시를 위한 AI기반 통합 장애 대응 프로세스 구축 
     - AI 장애 분석 결과에 대한 운용자 조치 가이드 제공 및  Knowledge DB 구축 (조치 SOP 구축)
     - IP 백본망에서 이상 트래픽 탐지 시 KOREN IP-SDN 연동을 통한 서비스 패스 재설정 및 자동 절체 알고리즘 개발
     - IP-SDN에서 임시 루트 회복 시 원복 알고리즘 개발
     - NOC 운용자 및 장비 관리 업체 담당자에게 이메일 발송 기능 개발
5. KOREN 전송망과 IP 백본망 통합 관제를 위한 상용 AI기반 관제 시스템 개발
      - KOREN 전송망과 IP 백본망 통합 관제용 Web Client 개발 
      - KOREN 전송망과 IP 백본망을 통합한 토플로지 기반 관제 UI 개발
      - 전송망 관리대상 장비(ROADM, POTN)와 IP 백본망 관리대상 장비(화이트박스)에 대한 시설 관리 기능 개발
      - IP 백본망 화이트박스 장비의 구성 정보 관리 기능 개발
      - 장비간 연결정보 관리 기능 개발
      - KOREN 서비스 이용 기관 관리 기능 개발
      - 실시간 경보 감시 및 이력 조회 기능 개발 
      - 실시간 IP백본망 트래픽 감시 및 이력 조회 기능 개발
  
## UI 작업내용 TODO
1. IP / 전송 레이어 표현할 토폴로지 설계가 필요
2. IP-SDN/T-SDN 연동 
3. 1차에 토폴로지/장비/링크 안 보게 되어있는데, 이 부분도 데이터 기반으로 수정 등

## 디버깅 티켓 
	12816
	12835

## sql
/* 토폴로지 노드 조회 */
select 	--7712/5812 장비 
	nm.node_id 
	, nm.node_nm 
	, '4' device_type
	, row_number() over () as index
	, 420 fx
	, 420 fy
from resource.tb_node_mst nm
where nm.node_id like '%7712' or nm.node_id  like '%5812'or nm.node_id  like '%n9k%'
union all  
select 	--n9k 장비 
	nm.node_id id
	, nm.node_nm device_name
	, '4' device_type
	, 100 + row_number() over () as index
	, 420 fx
	, 420 fy
from resource.tb_node_mst nm
where nm.node_id  like '%n9k%'
union all 
select -- 전송장비 (POTN/ROADM)
	em.tid
	, em.sysname 
	, case model when 'Utrans-6300p-H3' then '1' when 'Utrans-6300p-V9' then '0' else '2' end device_type
	, 100 + row_number() over () as index
	, 420 fx
	, 420 fy
from nia.tb_equip_mst em


/* 토폴로지 링크 조회 (전송) */
select 
	row_number() over () as id
	, es.sysname as source_name
	, es.tid as source_id
	, et.sysname as target_name
	, et.tid as target_id
	, 'UP' as status
	, tp.equip_type as equip_type
	, ptpnamea_bau as source_port_disp
	, ptpnamez_bau as target_port_disp
from NIA.tb_topology tp
inner join nia.tb_equip_mst es on replace (tp.sysnamea,'-SH1','') = es.tid
inner join nia.tb_equip_mst et on replace (tp.sysnamez,'-SH1','') = et.tid
;

/* 토폴로지 링크 조회 (IP) */
select
	  100 + row_number() over () as id
	, bl.src_node_id as source_name 
	, bl.src_node_id as source_id
	, bl.dest_node_id as target_name
	, bl.dest_node_id as target_id
	, 'UP' as status
	, '' as equip_type
	, src_if_id as source_port_disp
	, dest_if_id as target_port_disp
	, 1 as linkDistance
from resource.tb_backbone_link bl
inner join resource.tb_node_mst ns on ns.node_id = bl.src_node_id
--inner join resource.tb_node_mst nd on nd.node_id = bl.dest_node_id
where ns.node_id like '%7712' or ns.node_id  like '%5812' or ns.node_id  like '%n9k'
order by id

/* 토폴로지 링크 조회 (IP-전송POTN) */
select
	  200 + row_number() over () as id
	, bl.node_ida as source_name 
	, bl.node_ida as source_id
	, bl.node_idz as target_name
	, bl.node_idz as target_id
	, 'UP' as status
	, '' as equip_type
	, porta as source_port_disp
	, portz as target_port_disp
from nia.tb_e2e_topology bl	


/* 티켓별 tb_alarm_cur_mst (RELATED_ALARM 필드 추가) */
WITH sub_ticket_alarm AS
        ( SELECT T.*,
                AL.ticket_al_id,
                AL.root_cause_alarm_noa,
                AL.root_cause_alarm_noz
        FROM    RCA.TB_RCA_TICKET_CURRENT T
        LEFT OUTER JOIN
                ( SELECT SUB_AL.* ,
                        ROW_NUMBER() OVER (PARTITION BY SUB_AL.TICKET_ID ORDER BY TICKET_AL_ID DESC) AS ORDER_NUM
                FROM    RCA.TB_RCA_TICKET_AL_CURRENT SUB_AL ) AL ON T.TICKET_ID = AL.TICKET_ID AND AL.ORDER_NUM = 1
        )
SELECT  T.ALARMNO AS ALARMNO,
        T.CLUSTERNO AS CLUSTERNO,
        T.TMP_CLUSTER_NO AS TMP_CLUSTER_NO,
        T.SYSNAME AS SYSNAME,
        T.EQUIPTYPE AS EQUIPTYPE,
        T.ALARMTIME AS ALARMTIME,
        T.RECEIVETIME AS RECEIVETIME,
        T.ALARMLOC AS ALARMLOC,
        T.ALARMMSG AS ALARMMSG,
        T.UNIT AS UNIT,
        T.ALARMLEVEL AS ALARMLEVEL,
        T.CLUSTERNO_ORIGINAL AS CLUSTERNO_ORIGINAL,
        T.CLEARTIME AS CLEARTIME,
        T.PTPNAME AS PTPNAME,
        T.SLOT AS SLOT,
        T.PORT AS PORT,
        CASE WHEN ta.root_cause_alarm_noa IS NULL AND ta.root_cause_alarm_noz IS NULL THEN true ELSE false
        END RELATED_ALARM
FROM    rca.tb_alarm_cur_mst T
LEFT OUTER JOIN sub_ticket_alarm ta ON T.clusterno = ta.cluster_no
WHERE   T.CLUSTERNO = '18762'