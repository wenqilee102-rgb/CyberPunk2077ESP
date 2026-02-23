using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseVisibilityPartsEvent : redEvent
	{
		private wCHandle<gameObject> _target;
		private CBool _isPrimaryVisible;
		private CBool _isSecondaryVisible;
		private CName _description;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("isPrimaryVisible")] 
		public CBool IsPrimaryVisible
		{
			get => GetProperty(ref _isPrimaryVisible);
			set => SetProperty(ref _isPrimaryVisible, value);
		}

		[Ordinal(2)] 
		[RED("isSecondaryVisible")] 
		public CBool IsSecondaryVisible
		{
			get => GetProperty(ref _isSecondaryVisible);
			set => SetProperty(ref _isSecondaryVisible, value);
		}

		[Ordinal(3)] 
		[RED("description")] 
		public CName Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		public senseVisibilityPartsEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
