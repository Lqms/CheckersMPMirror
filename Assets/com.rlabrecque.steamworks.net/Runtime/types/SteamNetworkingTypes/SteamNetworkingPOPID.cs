// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2021 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

#if !(UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX || STEAMWORKS_WIN || STEAMWORKS_LIN_OSX)
	#define DISABLESTEAMWORKS
#endif

#if !DISABLESTEAMWORKS

using System.Runtime.InteropServices;
using IntPtr = System.IntPtr;

namespace Steamworks {
	[System.Serializable]
	public struct SteamNetworkingPOPID : System.IEquatable<SteamNetworkingPOPID>, System.IComparable<SteamNetworkingPOPID> {
		public uint m_SteamNetworkingPOPID;

		public SteamNetworkingPOPID(uint value) {
			m_SteamNetworkingPOPID = value;
		}

		public override string ToString() {
			return m_SteamNetworkingPOPID.ToString();
		}

		public override bool Equals(object other) {
			return other is SteamNetworkingPOPID && this == (SteamNetworkingPOPID)other;
		}

		public override int GetHashCode() {
			return m_SteamNetworkingPOPID.GetHashCode();
		}

		public static bool operator ==(SteamNetworkingPOPID x, SteamNetworkingPOPID y) {
			return x.m_SteamNetworkingPOPID == y.m_SteamNetworkingPOPID;
		}

		public static bool operator !=(SteamNetworkingPOPID x, SteamNetworkingPOPID y) {
			return !(x == y);
		}

		public static explicit operator SteamNetworkingPOPID(uint value) {
			return new SteamNetworkingPOPID(value);
		}

		public static explicit operator uint(SteamNetworkingPOPID that) {
			return that.m_SteamNetworkingPOPID;
		}

		public bool Equals(SteamNetworkingPOPID other) {
			return m_SteamNetworkingPOPID == other.m_SteamNetworkingPOPID;
		}

		public int CompareTo(SteamNetworkingPOPID other) {
			return m_SteamNetworkingPOPID.CompareTo(other.m_SteamNetworkingPOPID);
		}
	}
}

#endif // !DISABLESTEAMWORKS
