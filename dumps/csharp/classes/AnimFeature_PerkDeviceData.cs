using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PerkDeviceData : animAnimFeature
	{
		private CBool _isUsed;

		[Ordinal(0)] 
		[RED("isUsed")] 
		public CBool IsUsed
		{
			get => GetProperty(ref _isUsed);
			set => SetProperty(ref _isUsed, value);
		}

		public AnimFeature_PerkDeviceData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
