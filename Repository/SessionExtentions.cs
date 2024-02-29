using Newtonsoft.Json;
namespace nguyenthaominhaspnet.Repository
{
	public static class SessionExtentions
	{
		public static void SetJson(this ISession sesstion, string key, object value)
		{
		sesstion.SetString(key, JsonConvert.SerializeObject(value));
		}
		public static T GetJson<T>(this ISession session, string key){
			var sessionData= session.GetString(key);
			return sessionData == null ? default(T) : JsonConvert.DeserializeObject<T>(sessionData);
		}
	}
}
