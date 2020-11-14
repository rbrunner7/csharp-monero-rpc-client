﻿using System;
using System.Collections.Generic;
using System.Text;

using Monero.Client.Daemon.POD.Requests;
using Monero.Client.Wallet.POD;
using Monero.Client.Wallet.POD.Requests;

namespace Monero.Client.Network
{
    internal class GenericRequestParameters
    {
        public uint? height { get; set; } = null;
        public string hash { get; set; } = null;
        public uint? start_height { get; set; } = null;
        public uint? end_height { get; set; } = null;
        public IEnumerable<string> txids { get; set; } = null;
        public IEnumerable<ulong> amounts { get; set; } = null;
        public uint? min_count { get; set; } = null;
        public uint? max_count { get; set; } = null;
        public bool? unlocked { get; set; } = null;
        public uint? recent_cutoff { get; set; } = null;
        public uint? count { get; set; } = null;
        public uint? grace_blocks { get; set; } = null;
        public bool? cumulative { get; set; } = null;
        public uint? from_height { get; set; } = null;
        public uint? to_height { get; set; } = null;
        public List<NodeBan> bans { get; set; } = null;
        public uint? account_index { get; set; } = null;
        public IEnumerable<uint> address_indices { get; set; } = null;
        public string address { get; set; } = null;
        public ulong? amount { get; set; } = null;
        public string label { get; set; } = null;
        public string tx_description { get; set; } = null;
        public string payment_id { get; set; } = null;
        public string recipient_name { get; set; } = null;
        public AddressIndexParameter index { get; set; } = null;
        public string tag { get; set; } = null;
        public IEnumerable<uint> entries { get; set; } = null;
        public IEnumerable<uint> accounts { get; set; } = null;
        public IEnumerable<string> multisig_info { get; set; } = null;
        public uint? threshold { get; set; } = null;
        public string description { get; set; } = null;
        public IEnumerable<FundTransferParameter> destinations { get; set; } = null;
        public IEnumerable<uint> subaddr_indices { get; set; } = null;
        public uint? priority { get; set; } = null;
        public uint? mixin { get; set; } = null;
        public uint? ring_size { get; set; } = null;
        public ulong? unlock_time { get; set; } = null;
        public bool? get_tx_key { get; set; } = null;
        public bool? get_tx_keys { get; set; } = null;
        public bool? get_tx_hex { get; set; } = null;
        public bool? get_tx_metadata { get; set; } = null;
        public bool? new_algorithm { get; set; } = null;
        public string unsigned_txset { get; set; } = null;
        public bool? export_raw { get; set; } = null;
        public string tx_data_hex { get; set; } = null;
        public bool? do_not_relay { get; set; } = null;
        public ulong? below_amount { get; set; } = null;
        public string transfer_type { get; set; } = null;
        public bool? verbose { get; set; } = null;
        public string key_type { get; set; } = null;
        public IEnumerable<string> notes { get; set; } = null;
        public string txid { get; set; } = null;
        public bool? @in { get; set; } = null;
        public bool? @out { get; set; } = null;
        public bool? pending { get; set; } = null;
        public bool? failed { get; set; } = null;
        public bool? pool { get; set; } = null;
        public uint? min_height { get; set; } = null;
        public uint? max_height { get; set; } = null;
        public bool? filter_by_height { get; set; } = null;
        public string data { get; set; } = null;
        public string signature { get; set; } = null;
        public List<SignedKeyImage> signed_key_images { get; set; } = null;
        public string uri { get; set; } = null;
        public string filename { get; set; } = null;
        public string password { get; set; } = null;
        public string language { get; set; } = null;
        public string old_password { get; set; } = null;
        public string new_password { get; set; } = null;
    }
}