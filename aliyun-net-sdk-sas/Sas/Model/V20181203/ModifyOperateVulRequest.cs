/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class ModifyOperateVulRequest : RpcAcsRequest<ModifyOperateVulResponse>
    {
        public ModifyOperateVulRequest()
            : base("Sas", "2018-12-03", "ModifyOperateVul", "sas", "openAPI")
        {
        }

		private string reason;

		private string sourceIp;

		private string operateType;

		private string type;

		private string info;

		public string Reason
		{
			get
			{
				return reason;
			}
			set	
			{
				reason = value;
				DictionaryUtil.Add(QueryParameters, "Reason", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string OperateType
		{
			get
			{
				return operateType;
			}
			set	
			{
				operateType = value;
				DictionaryUtil.Add(QueryParameters, "OperateType", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string Info
		{
			get
			{
				return info;
			}
			set	
			{
				info = value;
				DictionaryUtil.Add(QueryParameters, "Info", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyOperateVulResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyOperateVulResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
