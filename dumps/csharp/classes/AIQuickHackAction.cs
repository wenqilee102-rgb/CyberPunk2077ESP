using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIQuickHackAction : PuppetAction
	{
		private wCHandle<gameObject> _target;
		private CBool _scaleUploadTime;
		private HUDProgressBarData _hUDData;

		[Ordinal(39)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(40)] 
		[RED("scaleUploadTime")] 
		public CBool ScaleUploadTime
		{
			get => GetProperty(ref _scaleUploadTime);
			set => SetProperty(ref _scaleUploadTime, value);
		}

		[Ordinal(41)] 
		[RED("HUDData")] 
		public HUDProgressBarData HUDData
		{
			get => GetProperty(ref _hUDData);
			set => SetProperty(ref _hUDData, value);
		}

		public AIQuickHackAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
