using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_KnockOffData : animAnimFeature
	{
		private CBool _knockedOff;
		private CInt32 _direction;
		private CFloat _force;
		private CBool _draggedOff;

		[Ordinal(0)] 
		[RED("knockedOff")] 
		public CBool KnockedOff
		{
			get => GetProperty(ref _knockedOff);
			set => SetProperty(ref _knockedOff, value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CInt32 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(2)] 
		[RED("force")] 
		public CFloat Force
		{
			get => GetProperty(ref _force);
			set => SetProperty(ref _force, value);
		}

		[Ordinal(3)] 
		[RED("draggedOff")] 
		public CBool DraggedOff
		{
			get => GetProperty(ref _draggedOff);
			set => SetProperty(ref _draggedOff, value);
		}

		public AnimFeature_KnockOffData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
