using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatPoolModifierEffector : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private entEntityID _ownerEntityID;
		private CEnum<gamedataStatPoolType> _poolType;
		private CEnum<gameStatPoolModificationTypes> _modType;
		private TweakDBID _recordId;
		private gameStatPoolModifier _cachedModifier;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get => GetProperty(ref _ownerEntityID);
			set => SetProperty(ref _ownerEntityID, value);
		}

		[Ordinal(2)] 
		[RED("poolType")] 
		public CEnum<gamedataStatPoolType> PoolType
		{
			get => GetProperty(ref _poolType);
			set => SetProperty(ref _poolType, value);
		}

		[Ordinal(3)] 
		[RED("modType")] 
		public CEnum<gameStatPoolModificationTypes> ModType
		{
			get => GetProperty(ref _modType);
			set => SetProperty(ref _modType, value);
		}

		[Ordinal(4)] 
		[RED("recordId")] 
		public TweakDBID RecordId
		{
			get => GetProperty(ref _recordId);
			set => SetProperty(ref _recordId, value);
		}

		[Ordinal(5)] 
		[RED("cachedModifier")] 
		public gameStatPoolModifier CachedModifier
		{
			get => GetProperty(ref _cachedModifier);
			set => SetProperty(ref _cachedModifier, value);
		}

		public ModifyStatPoolModifierEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
