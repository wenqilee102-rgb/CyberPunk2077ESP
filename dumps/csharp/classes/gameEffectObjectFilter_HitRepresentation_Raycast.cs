using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_HitRepresentation_Raycast : gameEffectObjectFilter_HitRepresentation
	{
		private CBool _isPreview;
		private CBool _fillNearlyHitData;

		[Ordinal(0)] 
		[RED("isPreview")] 
		public CBool IsPreview
		{
			get => GetProperty(ref _isPreview);
			set => SetProperty(ref _isPreview, value);
		}

		[Ordinal(1)] 
		[RED("fillNearlyHitData")] 
		public CBool FillNearlyHitData
		{
			get => GetProperty(ref _fillNearlyHitData);
			set => SetProperty(ref _fillNearlyHitData, value);
		}

		public gameEffectObjectFilter_HitRepresentation_Raycast(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
