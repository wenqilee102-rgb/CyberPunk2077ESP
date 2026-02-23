using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemProgramData : IScriptable
	{
		private CInt32 _memoryCost;
		private CInt32 _baseCost;
		private CFloat _uploadTime;
		private CFloat _duration;
		private CFloat _cooldown;
		private CArray<CHandle<DamageEffectUIEntry>> _attackEffects;

		[Ordinal(0)] 
		[RED("MemoryCost")] 
		public CInt32 MemoryCost
		{
			get => GetProperty(ref _memoryCost);
			set => SetProperty(ref _memoryCost, value);
		}

		[Ordinal(1)] 
		[RED("BaseCost")] 
		public CInt32 BaseCost
		{
			get => GetProperty(ref _baseCost);
			set => SetProperty(ref _baseCost, value);
		}

		[Ordinal(2)] 
		[RED("UploadTime")] 
		public CFloat UploadTime
		{
			get => GetProperty(ref _uploadTime);
			set => SetProperty(ref _uploadTime, value);
		}

		[Ordinal(3)] 
		[RED("Duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("Cooldown")] 
		public CFloat Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(5)] 
		[RED("AttackEffects")] 
		public CArray<CHandle<DamageEffectUIEntry>> AttackEffects
		{
			get => GetProperty(ref _attackEffects);
			set => SetProperty(ref _attackEffects, value);
		}

		public UIInventoryItemProgramData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
