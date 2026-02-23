using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AgentBase : IScriptable
	{
		private entEntityID _id;
		private wCHandle<gameObject> _gameObject;
		private CEnum<gameDynamicVehicleType> _spawnedType;

		[Ordinal(0)] 
		[RED("id")] 
		public entEntityID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("gameObject")] 
		public wCHandle<gameObject> GameObject
		{
			get => GetProperty(ref _gameObject);
			set => SetProperty(ref _gameObject, value);
		}

		[Ordinal(2)] 
		[RED("spawnedType")] 
		public CEnum<gameDynamicVehicleType> SpawnedType
		{
			get => GetProperty(ref _spawnedType);
			set => SetProperty(ref _spawnedType, value);
		}

		public AgentBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
