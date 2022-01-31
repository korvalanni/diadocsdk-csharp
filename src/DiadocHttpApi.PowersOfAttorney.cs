﻿using Diadoc.Api.Http;
using Diadoc.Api.Proto;
using Diadoc.Api.Proto.PowersOfAttorney;

namespace Diadoc.Api
{
	public partial class DiadocHttpApi
	{
		public AsyncMethodResult RegisterPowerOfAttorney(
			string authToken,
			string boxId,
			PowerOfAttorneyToRegister powerOfAttorneyToRegister)
		{
			var queryString = new PathAndQueryBuilder("/RegisterPowerOfAttorney");
			queryString.AddParameter("boxId", boxId);
			return PerformHttpRequest<PowerOfAttorneyToRegister, AsyncMethodResult>(authToken, queryString.BuildPathAndQuery(), powerOfAttorneyToRegister);
		}

		public PowerOfAttorneyRegisterResult RegisterPowerOfAttorneyResult(
			string authToken,
			string boxId,
			string taskId)
		{
			var queryString = new PathAndQueryBuilder("/RegisterPowerOfAttorneyResult");
			queryString.AddParameter("boxId", boxId);
			queryString.AddParameter("taskId", taskId);
			return PerformHttpRequest<PowerOfAttorneyRegisterResult>(authToken, "GET", queryString.BuildPathAndQuery());
		}

		public PowerOfAttorneyPrevalidateResult PrevalidatePowerOfAttorney(
			string authToken,
			string boxId,
			string registrationNumber,
			string issuerInn,
			PowerOfAttorneyPrevalidateRequest request)
		{
			var queryString = new PathAndQueryBuilder("/PrevalidatePowerOfAttorney");
			queryString.AddParameter("boxId", boxId);
			queryString.AddParameter("registrationNumber", registrationNumber);
			queryString.AddParameter("issuerInn", issuerInn);
			return PerformHttpRequest<PowerOfAttorneyPrevalidateRequest, PowerOfAttorneyPrevalidateResult>(authToken, queryString.BuildPathAndQuery(), request);
		}

		public PowerOfAttorney GetPowerOfAttorneyInfo(
			string authToken,
			string boxId,
			string messageId,
			string entityId)
		{
			var queryString = new PathAndQueryBuilder("/GetPowerOfAttorneyInfo");
			queryString.AddParameter("boxId", boxId);
			queryString.AddParameter("messageId", messageId);
			queryString.AddParameter("entityId", entityId);
			return PerformHttpRequest<PowerOfAttorney>(authToken, "GET", queryString.BuildPathAndQuery());
		}
	}
}
