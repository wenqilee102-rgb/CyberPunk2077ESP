using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeTankEnemyController : gameuiarcadeTankDestroyableObjectController
	{
		private inkWidgetReference _headParent;
		private inkWidgetReference _head;

		[Ordinal(3)] 
		[RED("headParent")] 
		public inkWidgetReference HeadParent
		{
			get => GetProperty(ref _headParent);
			set => SetProperty(ref _headParent, value);
		}

		[Ordinal(4)] 
		[RED("head")] 
		public inkWidgetReference Head
		{
			get => GetProperty(ref _head);
			set => SetProperty(ref _head, value);
		}

		public gameuiarcadeTankEnemyController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
