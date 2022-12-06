using System;
using System.Collections.Generic;
using SqlSugar;
namespace Microvast.Model
{
	public class MicroVastProcessProperty
	{
		public MicroVastProcessProperty()
		{
		}
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        ///<summary>
        ///
        ///</summary>
        public int id { get; set; }
		
		///<summary>
		///条码
		///</summary>
		public string bar_no { get; set; }
		
		///<summary>
		///产品代码
		///</summary>
		public string item_no { get; set; }
		
		///<summary>
		///派工单号
		///</summary>
		public string vou_no { get; set; }
		
		///<summary>
		///工序号
		///</summary>
		public string process_no { get; set; }
		
		///<summary>
		///生产时间
		///</summary>
		public DateTime do_time { get; set; }
		
		///<summary>
		///合格标志(合格OK不合格NG )
		///</summary>
		public string ok_flag { get; set; }
		
		///<summary>
		///NG原因
		///</summary>
		public string ng_msg { get; set; }
		
		///<summary>
		///用户名
		///</summary>
		public string user_id { get; set; }
		
		///<summary>
		///调度标志 默认0
		///</summary>
		public int? flag { get; set; }
		
		///<summary>
		///设备子工位号
		///</summary>
		public string eqpt_loc_id { get; set; }
		
		///<summary>
		///主要状态(0 正常生产 1返工2维修 3设备调试 4故障)
		///</summary>
		public int? major_state { get; set; }
		
		///<summary>
		///副状态 0为无状态 副状态根据主状态决定
		///</summary>
		public int? second_state { get; set; }
		
		///<summary>
		///辅助状态 0为无状态
		///</summary>
		public int? aux_state { get; set; }
		
		///<summary>
		///参数1
		///</summary>
		public string data001 { get; set; }
		
		///<summary>
		///参数2
		///</summary>
		public string data002 { get; set; }
		
		///<summary>
		///参数3
		///</summary>
		public string data003 { get; set; }
		
		///<summary>
		///参数4
		///</summary>
		public string data004 { get; set; }
		
		///<summary>
		///参数5
		///</summary>
		public string data005 { get; set; }
		
		///<summary>
		///参数6
		///</summary>
		public string data006 { get; set; }
		
		///<summary>
		///参数7
		///</summary>
		public string data007 { get; set; }
		
		///<summary>
		///参数8
		///</summary>
		public string data008 { get; set; }
		
		///<summary>
		///参数9
		///</summary>
		public string data009 { get; set; }
		
		///<summary>
		///参数10
		///</summary>
		public string data010 { get; set; }
		
		///<summary>
		///参数11
		///</summary>
		public string data011 { get; set; }
		
		///<summary>
		///参数12
		///</summary>
		public string data012 { get; set; }
		
		///<summary>
		///参数13
		///</summary>
		public string data013 { get; set; }
		
		///<summary>
		///参数14
		///</summary>
		public string data014 { get; set; }
		
		///<summary>
		///参数15
		///</summary>
		public string data015 { get; set; }
		
		///<summary>
		///参数16
		///</summary>
		public string data016 { get; set; }
		
		///<summary>
		///参数17
		///</summary>
		public string data017 { get; set; }
		
		///<summary>
		///参数18
		///</summary>
		public string data018 { get; set; }
		
		///<summary>
		///参数19
		///</summary>
		public string data019 { get; set; }
		
		///<summary>
		///参数20
		///</summary>
		public string data020 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data021 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data022 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data023 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data024 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data025 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data026 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data027 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data028 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data029 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data030 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data031 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data032 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data033 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data034 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data035 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data036 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data037 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data038 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data039 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data040 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data041 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data042 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data043 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data044 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data045 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data046 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data047 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data048 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data049 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data050 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data051 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data052 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data053 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data054 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data055 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data056 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data057 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data058 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data059 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data060 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data061 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data062 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data063 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data064 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data065 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data066 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data067 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data068 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data069 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data070 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data071 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data072 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data073 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data074 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data075 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data076 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data077 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data078 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data079 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data080 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data081 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data082 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data083 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data084 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data085 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data086 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data087 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data088 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data089 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data090 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data091 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data092 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data093 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data094 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data095 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data096 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data097 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data098 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data099 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string data100 { get; set; }
		
	}
}
