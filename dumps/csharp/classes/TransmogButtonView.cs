using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TransmogButtonView : BaseButtonView
	{
		private inkWidgetReference _container;
		private CBool _isActive;

		[Ordinal(5)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(6)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		public TransmogButtonView(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
