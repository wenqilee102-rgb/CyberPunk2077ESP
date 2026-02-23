using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCursorInfo : inkUserData
	{
		private Vector2 _pos;
		private CBool _isVisible;
		private CName _cursorForDevice;

		[Ordinal(0)] 
		[RED("pos")] 
		public Vector2 Pos
		{
			get => GetProperty(ref _pos);
			set => SetProperty(ref _pos, value);
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}

		[Ordinal(2)] 
		[RED("cursorForDevice")] 
		public CName CursorForDevice
		{
			get => GetProperty(ref _cursorForDevice);
			set => SetProperty(ref _cursorForDevice, value);
		}

		public inkCursorInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
