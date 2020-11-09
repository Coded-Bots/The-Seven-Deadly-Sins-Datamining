using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiceStack;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace LocalAssetsManager
{
    public class DBAniLocalizeRow
    {
        public int id { get; set; } // 0x10
        public string matching_db_name { get; set; } // 0x18
        public string matching_id_array { get; set; } // 0x20
        public int weapon_on { get; set; } // 0x28
        public int prop_on { get; set; } // 0x2C
        public string ani_path_1 { get; set; } // 0x30
        public string ani_path_2 { get; set; } // 0x38
        public int ani_on { get; set; } // 0x40
        public string facial_on { get; set; } // 0x48
        public string ani_local_name { get; set; } // 0x50
        public string ani_clip_1 { get; set; } // 0x58
        public string ani_clip_2 { get; set; } // 0x60
        public string ani_clip_3 { get; set; } // 0x68
        public string ani_clip_4 { get; set; } // 0x70
        public string ani_clip_5 { get; set; } // 0x78
        public string ani_clip_6 { get; set; } // 0x80
        public List<string> list_ani_path = new List<string>(); // 0x88
        public List<string> list_ani_clip = new List<string>(); // 0x90
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            matching_db_name = reader.ReadString();
            matching_id_array = reader.ReadString();
            weapon_on = reader.ReadInt32();
            prop_on = reader.ReadInt32();
            ani_path_1 = reader.ReadString();
            ani_path_2 = reader.ReadString();
            ani_on = reader.ReadInt32();
            facial_on = reader.ReadString();
            ani_local_name = reader.ReadString();
            ani_clip_1 = reader.ReadString();
            ani_clip_2 = reader.ReadString();
            ani_clip_3 = reader.ReadString();
            ani_clip_4 = reader.ReadString();
            ani_clip_5 = reader.ReadString();
            ani_clip_6 = reader.ReadString();
            return true;
        }
    }
    public class DBAniRetryRow
    {
        public int id { get; set; } // 0x10
        public string matcing_db_name { get; set; } // 0x18
        public int matcing_id_1 { get; set; } // 0x20
        public int check_version { get; set; } // 0x24
        public int retry_on { get; set; } // 0x28
        public List<int> list_matcing_id = new List<int>(); // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            matcing_db_name = reader.ReadString();
            matcing_id_1 = reader.ReadInt32();
            check_version = reader.ReadInt32();
            retry_on = reader.ReadInt32();
            return true;
        }
    }
    public class DBArCharactersRow
    {
        public int id { get; set; } // 0x10
        public string character_base { get; set; } // 0x18
        public int unlock_quest_id { get; set; } // 0x20
        public string icon_1 { get; set; } // 0x28
        public string head_1 { get; set; } // 0x30
        public string body_1 { get; set; } // 0x38
        public string icon_2 { get; set; } // 0x40
        public string head_2 { get; set; } // 0x48
        public string body_2 { get; set; } // 0x50
        public string dance_bgm { get; set; } // 0x58
        public string anim_emotion_idle { get; set; } // 0x60
        public string anim_emotion_1 { get; set; } // 0x68
        public string anim_emotion_2 { get; set; } // 0x70
        public string anim_emotion_3 { get; set; } // 0x78
        public string anim_emotion_4 { get; set; } // 0x80
        public string anim_emotion_5 { get; set; } // 0x88
        public string anim_emotion_icon_1 { get; set; } // 0x90
        public string anim_emotion_icon_2 { get; set; } // 0x98
        public string anim_emotion_icon_3 { get; set; } // 0xA0
        public string anim_emotion_icon_4 { get; set; } // 0xA8
        public string anim_emotion_icon_5 { get; set; } // 0xB0
        public string anim_dance_idle { get; set; } // 0xB8
        public string anim_dance_1 { get; set; } // 0xC0
        public string anim_dance_2 { get; set; } // 0xC8
        public string anim_dance_3 { get; set; } // 0xD0
        public string anim_dance_4 { get; set; } // 0xD8
        public string anim_dance_5 { get; set; } // 0xE0
        public string anim_dance_icon_1 { get; set; } // 0xE8
        public string anim_dance_icon_2 { get; set; } // 0xF0
        public string anim_dance_icon_3 { get; set; } // 0xF8
        public string anim_dance_icon_4 { get; set; } // 0x100
        public string anim_dance_icon_5 { get; set; } // 0x108
        public List<string> list_icon = new List<string>(); // 0x110
        public List<string> list_head = new List<string>(); // 0x118
        public List<string> list_body = new List<string>(); // 0x120
        public List<string> list_anim_emotion = new List<string>(); // 0x128
        public List<string> list_anim_emotion_icon = new List<string>(); // 0x130
        public List<string> list_anim_dance = new List<string>(); // 0x138
        public List<string> list_anim_dance_icon = new List<string>(); // 0x140
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            character_base = reader.ReadString();
            unlock_quest_id = reader.ReadInt32();
            icon_1 = reader.ReadString();
            head_1 = reader.ReadString();
            body_1 = reader.ReadString();
            icon_2 = reader.ReadString();
            head_2 = reader.ReadString();
            body_2 = reader.ReadString();
            dance_bgm = reader.ReadString();
            anim_emotion_idle = reader.ReadString();
            anim_emotion_1 = reader.ReadString();
            anim_emotion_2 = reader.ReadString();
            anim_emotion_3 = reader.ReadString();
            anim_emotion_4 = reader.ReadString();
            anim_emotion_5 = reader.ReadString();
            anim_emotion_icon_1 = reader.ReadString();
            anim_emotion_icon_2 = reader.ReadString();
            anim_emotion_icon_3 = reader.ReadString();
            anim_emotion_icon_4 = reader.ReadString();
            anim_emotion_icon_5 = reader.ReadString();
            anim_dance_idle = reader.ReadString();
            anim_dance_1 = reader.ReadString();
            anim_dance_2 = reader.ReadString();
            anim_dance_3 = reader.ReadString();
            anim_dance_4 = reader.ReadString();
            anim_dance_5 = reader.ReadString();
            anim_dance_icon_1 = reader.ReadString();
            anim_dance_icon_2 = reader.ReadString();
            anim_dance_icon_3 = reader.ReadString();
            anim_dance_icon_4 = reader.ReadString();
            anim_dance_icon_5 = reader.ReadString();
            return true;
        }
    }
    public class DBArDevicesRow
    {
        public int id { get; set; } // 0x10
        public string device_model_name { get; set; } // 0x18
        public int device_min_api_level { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            device_model_name = reader.ReadString();
            device_min_api_level = reader.ReadInt32();
            return true;
        }
    }
    public class DBAreaRow
    {
        public int id { get; set; } // 0x10
        public int region { get; set; } // 0x14
        public int area { get; set; } // 0x18
        public int side { get; set; } // 0x1C
        public int index_basepoint { get; set; } // 0x20
        public string area_name { get; set; } // 0x28
        public string area_type { get; set; } // 0x30
        public int basepoint_Info_UIIndex { get; set; } // 0x38
        public string array_extra_group_id { get; set; } // 0x40
        public List<int> list_array_extra_group_id = new List<int>(); // 0x48
        public int end_extra_group_id { get; set; } // 0x50
        public int warp_region_id { get; set; } // 0x54
        public int warp_area_index { get; set; } // 0x58
        public string area_icon { get; set; } // 0x60
        public int area_large_icon { get; set; } // 0x68
        public string change_area_icon { get; set; } // 0x70
        public string change_area_name { get; set; } // 0x78
        public int change_quest_id { get; set; } // 0x80
        public string map_resource_path { get; set; } // 0x88
        public string map_resource { get; set; } // 0x90
        public string change_map_resource { get; set; } // 0x98
        public int group_clear_stage_id { get; set; } // 0xA0
        public int need_start_quest_id { get; set; } // 0xA4
        public int need_end_quest_id { get; set; } // 0xA8
        public int need_base_fellow_id { get; set; } // 0xAC
        public int need_base_fellow_level { get; set; } // 0xB0
        public int play_quest_id { get; set; } // 0xB4
        public int need_start_item_id { get; set; } // 0xB8
        public string area_open_notice { get; set; } // 0xC0
        public int need_stage_side { get; set; } // 0xC8
        public int need_area_id { get; set; } // 0xCC
        public int need_stage_id { get; set; } // 0xD0
        public int start_story_cut { get; set; } // 0xD4
        public int change_story_cut { get; set; } // 0xD8
        public int end_story_cut { get; set; } // 0xDC
        public int end_acquire_story_cut { get; set; } // 0xE0
        public int before_loading_tip { get; set; } // 0xE4
        public int after_loading_tip { get; set; } // 0xE8
        public string town_emblem { get; set; } // 0xF0
        public int basepoint_fellow_open { get; set; } // 0xF8
        public string town_minimap_resource { get; set; } // 0x100
        public int root_basepoint_id { get; set; } // 0x108
        public int bgm_sound_id { get; set; } // 0x10C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            region = reader.ReadInt32();
            area = reader.ReadInt32();
            side = reader.ReadInt32();
            index_basepoint = reader.ReadInt32();
            area_name = reader.ReadString();
            area_type = reader.ReadString();
            basepoint_Info_UIIndex = reader.ReadInt32();
            //array_extra_group_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_extra_group_id.Add(reader.ReadInt32());
                v0--;
            }
            end_extra_group_id = reader.ReadInt32();
            warp_region_id = reader.ReadInt32();
            warp_area_index = reader.ReadInt32();
            area_icon = reader.ReadString();
            area_large_icon = reader.ReadInt32();
            change_area_icon = reader.ReadString();
            change_area_name = reader.ReadString();
            change_quest_id = reader.ReadInt32();
            map_resource_path = reader.ReadString();
            map_resource = reader.ReadString();
            change_map_resource = reader.ReadString();
            group_clear_stage_id = reader.ReadInt32();
            need_start_quest_id = reader.ReadInt32();
            need_end_quest_id = reader.ReadInt32();
            need_base_fellow_id = reader.ReadInt32();
            need_base_fellow_level = reader.ReadInt32();
            play_quest_id = reader.ReadInt32();
            need_start_item_id = reader.ReadInt32();
            area_open_notice = reader.ReadString();
            need_stage_side = reader.ReadInt32();
            need_area_id = reader.ReadInt32();
            need_stage_id = reader.ReadInt32();
            start_story_cut = reader.ReadInt32();
            change_story_cut = reader.ReadInt32();
            end_story_cut = reader.ReadInt32();
            end_acquire_story_cut = reader.ReadInt32();
            before_loading_tip = reader.ReadInt32();
            after_loading_tip = reader.ReadInt32();
            town_emblem = reader.ReadString();
            basepoint_fellow_open = reader.ReadInt32();
            town_minimap_resource = reader.ReadString();
            root_basepoint_id = reader.ReadInt32();
            bgm_sound_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBArSystemsRow
    {
        public int id { get; set; } // 0x10
        public int is_unlocked_lobby_ar_ios { get; set; } // 0x14
        public int is_unlocked_lobby_ar_aos { get; set; } // 0x18
        public int is_unlocked_ingame_ar_ios { get; set; } // 0x1C
        public int is_unlocked_ingame_ar_aos { get; set; } // 0x20
        public int is_unlocked_lobby_ar_record { get; set; } // 0x24
        public int android_min_api_level { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            is_unlocked_lobby_ar_ios = reader.ReadInt32();
            is_unlocked_lobby_ar_aos = reader.ReadInt32();
            is_unlocked_ingame_ar_ios = reader.ReadInt32();
            is_unlocked_ingame_ar_aos = reader.ReadInt32();
            is_unlocked_lobby_ar_record = reader.ReadInt32();
            android_min_api_level = reader.ReadInt32();
            return true;
        }
    }
    public class DBAttendancePackageRow
    {
        public int id { get; set; } // 0x10
        public int product_id { get; set; } // 0x14
        public int day { get; set; } // 0x18
        public int reward_item_id_1 { get; set; } // 0x1C
        public int reward_item_count_1 { get; set; } // 0x20
        public int reward_item_id_2 { get; set; } // 0x24
        public int reward_item_count_2 { get; set; } // 0x28
        public List<int> list_reward_item_id = new List<int>(); // 0x30
        public List<int> list_reward_item_count = new List<int>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            product_id = reader.ReadInt32();
            day = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            reward_item_id_2 = reader.ReadInt32();
            reward_item_count_2 = reader.ReadInt32();
            return true;
        }
    }
    public class DBBasepointCollisionNpcRow
    {
        public int id { get; set; } // 0x10
        public int basepoint_id { get; set; } // 0x14
        public int collision_index { get; set; } // 0x18
        public int collision_count { get; set; } // 0x1C
        public string collision_resource { get; set; } // 0x20
        public string open_type { get; set; } // 0x28
        public int open_value { get; set; } // 0x30
        public string close_type { get; set; } // 0x38
        public int close_value { get; set; } // 0x40
        public string npc_role { get; set; } // 0x48
        public int npc_content_id { get; set; } // 0x50
        public int npc_cinema_id { get; set; } // 0x54
        public string guide_local { get; set; } // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            basepoint_id = reader.ReadInt32();
            collision_index = reader.ReadInt32();
            collision_count = reader.ReadInt32();
            collision_resource = reader.ReadString();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            close_type = reader.ReadString();
            close_value = reader.ReadInt32();
            npc_role = reader.ReadString();
            npc_content_id = reader.ReadInt32();
            npc_cinema_id = reader.ReadInt32();
            guide_local = reader.ReadString();
            return true;
        }
    }
    public class DBBasepointDropRow
    {
        public int id { get; set; } // 0x10
        public int drop_npc_id { get; set; } // 0x14
        public int box_spawn_min { get; set; } // 0x18
        public string drop_type { get; set; } // 0x20
        public int drop_percent_1 { get; set; } // 0x28
        public int drop_item_id_1 { get; set; } // 0x2C
        public int drop_count_min_1 { get; set; } // 0x30
        public int drop_count_max_1 { get; set; } // 0x34
        public int drop_percent_2 { get; set; } // 0x38
        public int drop_item_id_2 { get; set; } // 0x3C
        public int drop_count_min_2 { get; set; } // 0x40
        public int drop_count_max_2 { get; set; } // 0x44
        public int drop_percent_3 { get; set; } // 0x48
        public int drop_item_id_3 { get; set; } // 0x4C
        public int drop_count_min_3 { get; set; } // 0x50
        public int drop_count_max_3 { get; set; } // 0x54
        public List<int> list_drop_percent = new List<int>(); // 0x58
        public List<int> list_drop_item_id = new List<int>(); // 0x60
        public List<int> list_drop_count_min = new List<int>(); // 0x68
        public List<int> list_drop_count_max = new List<int>(); // 0x70
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            drop_npc_id = reader.ReadInt32();
            box_spawn_min = reader.ReadInt32();
            drop_type = reader.ReadString();
            drop_percent_1 = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_count_min_1 = reader.ReadInt32();
            drop_count_max_1 = reader.ReadInt32();
            drop_percent_2 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_count_min_2 = reader.ReadInt32();
            drop_count_max_2 = reader.ReadInt32();
            drop_percent_3 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_count_min_3 = reader.ReadInt32();
            drop_count_max_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBBasepointFellowRewardRow
    {
        public int id { get; set; } // 0x10
        public int basepoint_id { get; set; } // 0x14
        public string array_contents_check { get; set; } // 0x18
        public List<string> list_array_contents_check = new List<string>(); // 0x20
        public int fellow_level { get; set; } // 0x28
        public int fellow_exp { get; set; } // 0x2C
        public string fellow_string { get; set; } // 0x30
        public int npc_id { get; set; } // 0x38
        public string talk_string { get; set; } // 0x40
        public string donation_talking_string { get; set; } // 0x48
        public string donation_talking2_string { get; set; } // 0x50
        public string donation_talking3_string { get; set; } // 0x58
        public int exchange_add_rate { get; set; } // 0x60
        public int world_fellow_reward_1 { get; set; } // 0x64
        public int world_fellow_reward_count_1 { get; set; } // 0x68
        public int world_fellow_reward_2 { get; set; } // 0x6C
        public int world_fellow_reward_count_2 { get; set; } // 0x70
        public int world_fellow_reward_3 { get; set; } // 0x74
        public int world_fellow_reward_count_3 { get; set; } // 0x78
        public int world_fellow_reward_4 { get; set; } // 0x7C
        public int world_fellow_reward_count_4 { get; set; } // 0x80
        public int fellow_reward_1 { get; set; } // 0x84
        public int fellow_reward_count_1 { get; set; } // 0x88
        public int fellow_reward_2 { get; set; } // 0x8C
        public int fellow_reward_count_2 { get; set; } // 0x90
        public int over_donation_condition { get; set; } // 0x94
        public int over_donation_passive_id { get; set; } // 0x98
        public List<int> list_world_fellow_reward = new List<int>(); // 0xA0
        public List<int> list_world_fellow_reward_count = new List<int>(); // 0xA8
        public List<int> list_fellow_reward = new List<int>(); // 0xB0
        public List<int> list_fellow_reward_count = new List<int>(); // 0xB8
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            basepoint_id = reader.ReadInt32();
            //array_contents_check = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_contents_check.Add(reader.ReadString());
                v0--;
            }
            fellow_level = reader.ReadInt32();
            fellow_exp = reader.ReadInt32();
            fellow_string = reader.ReadString();
            npc_id = reader.ReadInt32();
            talk_string = reader.ReadString();
            donation_talking_string = reader.ReadString();
            donation_talking2_string = reader.ReadString();
            donation_talking3_string = reader.ReadString();
            exchange_add_rate = reader.ReadInt32();
            world_fellow_reward_1 = reader.ReadInt32();
            world_fellow_reward_count_1 = reader.ReadInt32();
            world_fellow_reward_2 = reader.ReadInt32();
            world_fellow_reward_count_2 = reader.ReadInt32();
            world_fellow_reward_3 = reader.ReadInt32();
            world_fellow_reward_count_3 = reader.ReadInt32();
            world_fellow_reward_4 = reader.ReadInt32();
            world_fellow_reward_count_4 = reader.ReadInt32();
            fellow_reward_1 = reader.ReadInt32();
            fellow_reward_count_1 = reader.ReadInt32();
            fellow_reward_2 = reader.ReadInt32();
            fellow_reward_count_2 = reader.ReadInt32();
            over_donation_condition = reader.ReadInt32();
            over_donation_passive_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBBasepointInteractiveAniRow
    {
        public int id { get; set; } // 0x10
        public int basepoint_id { get; set; } // 0x14
        public int quest_character_id { get; set; } // 0x18
        public string open_type { get; set; } // 0x20
        public int open_value { get; set; } // 0x28
        public string close_type { get; set; } // 0x30
        public int close_value { get; set; } // 0x38
        public string basepoint_action_ani { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            basepoint_id = reader.ReadInt32();
            quest_character_id = reader.ReadInt32();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            close_type = reader.ReadString();
            close_value = reader.ReadInt32();
            basepoint_action_ani = reader.ReadString();
            return true;
        }
    }
    public class DBBasepointNpcRow
    {
        public int id { get; set; } // 0x10
        public int npc_info_id { get; set; } // 0x14
        public string npc_name { get; set; } // 0x18
        public string npc_role { get; set; } // 0x20
        public string array_link_npc_id { get; set; } // 0x28
        public List<int> list_array_link_npc_id = new List<int>(); // 0x30
        public int hero_group { get; set; } // 0x38
        public int guest_id { get; set; } // 0x3C
        public int basepoint_id { get; set; } // 0x40
        public int basepoint_index { get; set; } // 0x44
        public int npc_skin_change { get; set; } // 0x48
        public int open_basepoint_fellow { get; set; } // 0x4C
        public string open_type { get; set; } // 0x50
        public int open_value { get; set; } // 0x58
        public string close_type { get; set; } // 0x60
        public int close_value { get; set; } // 0x68
        public int position_id { get; set; } // 0x6C
        public string contents_menu_1 { get; set; } // 0x70
        public string contents_menu_2 { get; set; } // 0x78
        public string contents_menu_3 { get; set; } // 0x80
        public string contents_menu_4 { get; set; } // 0x88
        public string contents_menu_5 { get; set; } // 0x90
        public string contents_menu_6 { get; set; } // 0x98
        public string contents_menu_7 { get; set; } // 0xA0
        public int active_quest_id { get; set; } // 0xA8
        public int stage_quest_id { get; set; } // 0xAC
        public int quest_count_group { get; set; } // 0xB0
        public int reward_id_1 { get; set; } // 0xB4
        public int reward_count_1 { get; set; } // 0xB8
        public int daily_reward_index { get; set; } // 0xBC
        public int daily_reward_id_1 { get; set; } // 0xC0
        public int daily_reward_count_1 { get; set; } // 0xC4
        public List<string> list_contents_menu = new List<string>(); // 0xC8
        public List<int> list_reward_id = new List<int>(); // 0xD0
        public List<int> list_reward_count = new List<int>(); // 0xD8
        public List<int> list_daily_reward_id = new List<int>(); // 0xE0
        public List<int> list_daily_reward_count = new List<int>(); // 0xE8
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            npc_info_id = reader.ReadInt32();
            npc_name = reader.ReadString();
            npc_role = reader.ReadString();
            //array_link_npc_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_link_npc_id.Add(reader.ReadInt32());
                v0--;
            }
            hero_group = reader.ReadInt32();
            guest_id = reader.ReadInt32();
            basepoint_id = reader.ReadInt32();
            basepoint_index = reader.ReadInt32();
            npc_skin_change = reader.ReadInt32();
            open_basepoint_fellow = reader.ReadInt32();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            close_type = reader.ReadString();
            close_value = reader.ReadInt32();
            position_id = reader.ReadInt32();
            contents_menu_1 = reader.ReadString();
            contents_menu_2 = reader.ReadString();
            contents_menu_3 = reader.ReadString();
            contents_menu_4 = reader.ReadString();
            contents_menu_5 = reader.ReadString();
            contents_menu_6 = reader.ReadString();
            contents_menu_7 = reader.ReadString();
            active_quest_id = reader.ReadInt32();
            stage_quest_id = reader.ReadInt32();
            quest_count_group = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            daily_reward_index = reader.ReadInt32();
            daily_reward_id_1 = reader.ReadInt32();
            daily_reward_count_1 = reader.ReadInt32();
            return true;
        }
    }
    public class DBBasepointNpcMoveRow
    {
        public int id { get; set; } // 0x10
        public string move_name { get; set; } // 0x18
        public int basepoint_id { get; set; } // 0x20
        public int basepoint_npc_id { get; set; } // 0x24
        public string move_condition { get; set; } // 0x28
        public int condition_id { get; set; } // 0x30
        public string move_type { get; set; } // 0x38
        public int wait_time_min { get; set; } // 0x40
        public int wait_time_max { get; set; } // 0x44
        public string wait_time_ani { get; set; } // 0x48
        public string move_ani { get; set; } // 0x50
        public float walk_speed { get; set; } // 0x58
        public float run_speed { get; set; } // 0x5C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            move_name = reader.ReadString();
            basepoint_id = reader.ReadInt32();
            basepoint_npc_id = reader.ReadInt32();
            move_condition = reader.ReadString();
            condition_id = reader.ReadInt32();
            move_type = reader.ReadString();
            wait_time_min = reader.ReadInt32();
            wait_time_max = reader.ReadInt32();
            wait_time_ani = reader.ReadString();
            move_ani = reader.ReadString();
            walk_speed = reader.ReadSingle();
            run_speed = reader.ReadSingle();
            return true;
        }
    }
    public class DBBasepointNpcTalkRow
    {
        public int id { get; set; } // 0x10
        public int npc_id { get; set; } // 0x14
        public string open_type { get; set; } // 0x18
        public string start_quest_step { get; set; } // 0x20
        public int start_quest_id { get; set; } // 0x28
        public string end_quest_step { get; set; } // 0x30
        public int end_quest_id { get; set; } // 0x38
        public string talk_string { get; set; } // 0x40
        public string animation { get; set; } // 0x48
        public int voice_sound_id { get; set; } // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            npc_id = reader.ReadInt32();
            open_type = reader.ReadString();
            start_quest_step = reader.ReadString();
            start_quest_id = reader.ReadInt32();
            end_quest_step = reader.ReadString();
            end_quest_id = reader.ReadInt32();
            talk_string = reader.ReadString();
            animation = reader.ReadString();
            voice_sound_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBBasepointRandomShopRow
    {
        public int id { get; set; } // 0x10
        public int basepoint_id { get; set; } // 0x14
        public int item_id { get; set; } // 0x18
        public string slot_type { get; set; } // 0x20
        public int item_per_rate { get; set; } // 0x28
        public int shop_cost_gold_per { get; set; } // 0x2C
        public int shop_cost_dia_per { get; set; } // 0x30
        public int shop_cost_gold { get; set; } // 0x34
        public int shop_cost_dia { get; set; } // 0x38
        public int product_count { get; set; } // 0x3C
        public int buy_limited_count { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            basepoint_id = reader.ReadInt32();
            item_id = reader.ReadInt32();
            slot_type = reader.ReadString();
            item_per_rate = reader.ReadInt32();
            shop_cost_gold_per = reader.ReadInt32();
            shop_cost_dia_per = reader.ReadInt32();
            shop_cost_gold = reader.ReadInt32();
            shop_cost_dia = reader.ReadInt32();
            product_count = reader.ReadInt32();
            buy_limited_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBBasepointShopRow
    {
        public int id { get; set; } // 0x10
        public int basepoint_id { get; set; } // 0x14
        public int npc_id { get; set; } // 0x18
        public int product_id { get; set; } // 0x1C
        public int need_fellow_level { get; set; } // 0x20
        public int product_count { get; set; } // 0x24
        public int price_id { get; set; } // 0x28
        public int price_count { get; set; } // 0x2C
        public int buy_limited_count { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            basepoint_id = reader.ReadInt32();
            npc_id = reader.ReadInt32();
            product_id = reader.ReadInt32();
            need_fellow_level = reader.ReadInt32();
            product_count = reader.ReadInt32();
            price_id = reader.ReadInt32();
            price_count = reader.ReadInt32();
            buy_limited_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBBirthdayRow
    {
        public int id { get; set; } // 0x10
        public int guest_id { get; set; } // 0x14
        public int birthday_month { get; set; } // 0x18
        public int birthday_day { get; set; } // 0x1C
        public int fellowship_multiple_value { get; set; } // 0x20
        public string birthday_comment { get; set; } // 0x28
        public string illust_id { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            guest_id = reader.ReadInt32();
            birthday_month = reader.ReadInt32();
            birthday_day = reader.ReadInt32();
            fellowship_multiple_value = reader.ReadInt32();
            birthday_comment = reader.ReadString();
            illust_id = reader.ReadString();
            return true;
        }
    }
    public class DBBlindContentRow
    {
        public int id { get; set; } // 0x10
        public string content_type { get; set; } // 0x18
        public int content_id { get; set; } // 0x20
        public string taget_type { get; set; } // 0x28
        public int target_id { get; set; } // 0x30
        public string blind_off_type { get; set; } // 0x38
        public int blind_off_value { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            content_type = reader.ReadString();
            content_id = reader.ReadInt32();
            taget_type = reader.ReadString();
            target_id = reader.ReadInt32();
            blind_off_type = reader.ReadString();
            blind_off_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBBoxItemInfoRow
    {
        public int item_id { get; set; }// 0x10
        public byte box_type { get; set; }// 0x14
        public string box_render_type { get; set; }// 0x18
        public string box_render_open_ani_type { get; set; }// 0x20
        public string box_render_fail_ani_type { get; set; }// 0x28
        public byte box_code_type { get; set; }// 0x30
        public string box_code_answer { get; set; }// 0x38
        public List<int> list_array_weapon_set_id = new List<int>();// 0x40
        public List<int> list_array_weapon_rating = new List<int>();// 0x48
        public List<int> list_array_weapon_part = new List<int>();// 0x50
        public byte box_inventory_popup { get; set; }// 0x58
        public int item_id_1 { get; set; }// 0x5C
        public int item_count_1 { get; set; }// 0x60
        public int item_rate_1 { get; set; }// 0x64
        public int item_id_2 { get; set; }// 0x68
        public int item_count_2 { get; set; }// 0x6C
        public int item_rate_2 { get; set; }// 0x70
        public int item_id_3 { get; set; }// 0x74
        public int item_count_3 { get; set; }// 0x78
        public int item_rate_3 { get; set; }// 0x7C
        public int item_id_4 { get; set; }// 0x80
        public int item_count_4 { get; set; }// 0x84
        public int item_rate_4 { get; set; }// 0x88
        public int item_id_5 { get; set; }// 0x8C
        public int item_count_5 { get; set; }// 0x90
        public int item_rate_5 { get; set; }// 0x94
        public int item_id_6 { get; set; }// 0x98
        public int item_count_6 { get; set; }// 0x9C
        public int item_rate_6 { get; set; }// 0xA0
        public int item_id_7 { get; set; }// 0xA4
        public int item_count_7 { get; set; }// 0xA8
        public int item_rate_7 { get; set; }// 0xAC
        public int item_id_8 { get; set; }// 0xB0
        public int item_count_8 { get; set; }// 0xB4
        public int item_rate_8 { get; set; }// 0xB8
        public int item_id_9 { get; set; }// 0xBC
        public int item_count_9 { get; set; }// 0xC0
        public int item_rate_9 { get; set; }// 0xC4
        public int item_id_10 { get; set; }// 0xC8
        public int item_count_10 { get; set; }// 0xCC
        public int item_rate_10 { get; set; }// 0xD0
        public int item_id_11 { get; set; }// 0xD4
        public int item_count_11 { get; set; }// 0xD8
        public int item_rate_11 { get; set; }// 0xDC
        public int item_id_12 { get; set; }// 0xE0
        public int item_count_12 { get; set; }// 0xE4
        public int item_rate_12 { get; set; }// 0xE8
        public List<int> list_item_id = new List<int>();// 0xF0
        public List<int> list_item_count = new List<int>();// 0xF8
        public List<int> list_item_rate = new List<int>();// 0x100
        public bool ReadToStream(BinaryReader reader)
        {
            item_id = reader.ReadInt32();
            box_type = reader.ReadByte();
            box_render_type = reader.ReadString();
            box_render_open_ani_type = reader.ReadString();
            box_render_fail_ani_type = reader.ReadString();
            box_code_type = reader.ReadByte();
            box_code_answer = reader.ReadString();
            //array_weapon_set_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_weapon_set_id.Add(reader.ReadInt32());
                v0--;
            }
            //array_weapon_rating = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_weapon_rating.Add(reader.ReadInt32());
                v1--;
            }
            //array_weapon_part = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_weapon_part.Add(reader.ReadInt32());
                v2--;
            }
            box_inventory_popup = reader.ReadByte();
            item_id_1 = reader.ReadInt32();
            item_count_1 = reader.ReadInt32();
            item_rate_1 = reader.ReadInt32();
            item_id_2 = reader.ReadInt32();
            item_count_2 = reader.ReadInt32();
            item_rate_2 = reader.ReadInt32();
            item_id_3 = reader.ReadInt32();
            item_count_3 = reader.ReadInt32();
            item_rate_3 = reader.ReadInt32();
            item_id_4 = reader.ReadInt32();
            item_count_4 = reader.ReadInt32();
            item_rate_4 = reader.ReadInt32();
            item_id_5 = reader.ReadInt32();
            item_count_5 = reader.ReadInt32();
            item_rate_5 = reader.ReadInt32();
            item_id_6 = reader.ReadInt32();
            item_count_6 = reader.ReadInt32();
            item_rate_6 = reader.ReadInt32();
            item_id_7 = reader.ReadInt32();
            item_count_7 = reader.ReadInt32();
            item_rate_7 = reader.ReadInt32();
            item_id_8 = reader.ReadInt32();
            item_count_8 = reader.ReadInt32();
            item_rate_8 = reader.ReadInt32();
            item_id_9 = reader.ReadInt32();
            item_count_9 = reader.ReadInt32();
            item_rate_9 = reader.ReadInt32();
            item_id_10 = reader.ReadInt32();
            item_count_10 = reader.ReadInt32();
            item_rate_10 = reader.ReadInt32();
            item_id_11 = reader.ReadInt32();
            item_count_11 = reader.ReadInt32();
            item_rate_11 = reader.ReadInt32();
            item_id_12 = reader.ReadInt32();
            item_count_12 = reader.ReadInt32();
            item_rate_12 = reader.ReadInt32();
            return true;
        }
    }
    public class DBChapterRow
    {
        public int id { get; set; } // 0x10
        public int chapter_group { get; set; } // 0x14
        public string chapter_title_info { get; set; } // 0x18
        public string chapter_name { get; set; } // 0x20
        public string chapter_resource { get; set; } // 0x28
        public string chapter_type { get; set; } // 0x30
        public string blind_open_type { get; set; } // 0x38
        public int blind_open_value { get; set; } // 0x40
        public int matching_id { get; set; } // 0x44
        public int chapter_season { get; set; } // 0x48
        public int matching_region { get; set; } // 0x4C
        public string array_matching_id_link { get; set; } // 0x50
        public List<int> list_array_matching_id_link = new List<int>(); // 0x58
        public int first_matching_area { get; set; } // 0x60
        public int open_matching_area { get; set; } // 0x64
        public int move_matching_area { get; set; } // 0x68
        public int capital_icon_matching_area { get; set; } // 0x6C
        public string open_type { get; set; } // 0x70
        public int open_value { get; set; } // 0x78
        public string close_type { get; set; } // 0x80
        public int close_value { get; set; } // 0x88
        public int chapter_clear_index { get; set; } // 0x8C
        public int reward_item_id { get; set; } // 0x90
        public int reward_item_count { get; set; } // 0x94
        public int region_bgm { get; set; } // 0x98
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            chapter_group = reader.ReadInt32();
            chapter_title_info = reader.ReadString();
            chapter_name = reader.ReadString();
            chapter_resource = reader.ReadString();
            chapter_type = reader.ReadString();
            blind_open_type = reader.ReadString();
            blind_open_value = reader.ReadInt32();
            matching_id = reader.ReadInt32();
            chapter_season = reader.ReadInt32();
            matching_region = reader.ReadInt32();
            //array_matching_id_link = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_matching_id_link.Add(reader.ReadInt32());
                v0--;
            }
            first_matching_area = reader.ReadInt32();
            open_matching_area = reader.ReadInt32();
            move_matching_area = reader.ReadInt32();
            capital_icon_matching_area = reader.ReadInt32();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            close_type = reader.ReadString();
            close_value = reader.ReadInt32();
            chapter_clear_index = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            region_bgm = reader.ReadInt32();
            return true;
        }
    }
    public class DBChapterChangeRow
    {
        public int id { get; set; } // 0x10
        public int chapter_id { get; set; } // 0x14
        public int change_move_matching_area { get; set; } // 0x18
        public int change_capital_icon_matching_area { get; set; } // 0x1C
        public string change_chapter_name { get; set; } // 0x20
        public string change_chapter_resource { get; set; } // 0x28
        public string open_type { get; set; } // 0x30
        public int open_value { get; set; } // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            chapter_id = reader.ReadInt32();
            change_move_matching_area = reader.ReadInt32();
            change_capital_icon_matching_area = reader.ReadInt32();
            change_chapter_name = reader.ReadString();
            change_chapter_resource = reader.ReadString();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBChapterGroupRow
    {
        public int group_id { get; set; } // 0x10
        public string group_name { get; set; } // 0x18
        public string renderer_name { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            group_id = reader.ReadInt32();
            group_name = reader.ReadString();
            renderer_name = reader.ReadString();
            return true;
        }
    }
    public class DBCharacterLocalizeInfoRow
    {
        public int id { get; set; } // 0x10
        public string base_id { get; set; } // 0x18
        public string localize { get; set; } // 0x20
        public string icon { get; set; } // 0x28
        public string icon_type { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            base_id = reader.ReadString();
            localize = reader.ReadString();
            icon = reader.ReadString();
            icon_type = reader.ReadString();
            return true;
        }
    }
    public class DBCheckHeroResourceRow
    {
        public int id { get; set; } // 0x10
        public int portrait_on { get; set; } // 0x14
        public int facial_on { get; set; } // 0x18
        public int skill_preview_on { get; set; } // 0x1C
        public int matching_hero_id { get; set; } // 0x20
        public string matching_skin_array { get; set; } // 0x28
        public string hero_name_localize { get; set; } // 0x30
        public float hero_portrait_size { get; set; } // 0x38
        public string hero_potrait_base { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            portrait_on = reader.ReadInt32();
            facial_on = reader.ReadInt32();
            skill_preview_on = reader.ReadInt32();
            matching_hero_id = reader.ReadInt32();
            matching_skin_array = reader.ReadString();
            hero_name_localize = reader.ReadString();
            hero_portrait_size = reader.ReadSingle();
            hero_potrait_base = reader.ReadString();
            return true;
        }
    }
    public class DBCheckMonsterResourceRow
    {
        public int id { get; set; } // 0x10
        public int portrait_on { get; set; } // 0x14
        public int facial_on { get; set; } // 0x18
        public int skill_preview_on { get; set; } // 0x1C
        public string character_base { get; set; } // 0x20
        public string matching_body_array { get; set; } // 0x28
        public string skill_body_array { get; set; } // 0x30
        public string monster_name_localize { get; set; } // 0x38
        public float monster_portrait_size { get; set; } // 0x40
        public string monster_portrait_base { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            portrait_on = reader.ReadInt32();
            facial_on = reader.ReadInt32();
            skill_preview_on = reader.ReadInt32();
            character_base = reader.ReadString();
            matching_body_array = reader.ReadString();
            skill_body_array = reader.ReadString();
            monster_name_localize = reader.ReadString();
            monster_portrait_size = reader.ReadSingle();
            monster_portrait_base = reader.ReadString();
            return true;
        }
    }
    public class DBCheckNpcResourceRow
    {
        public int id { get; set; } // 0x10
        public int npc_id { get; set; } // 0x14
        public int portrait_on { get; set; } // 0x18
        public int facial_on { get; set; } // 0x1C
        public string npc_name_localize { get; set; } // 0x20
        public float npc_portrait_size { get; set; } // 0x28
        public string npc_portrait_base { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            npc_id = reader.ReadInt32();
            portrait_on = reader.ReadInt32();
            facial_on = reader.ReadInt32();
            npc_name_localize = reader.ReadString();
            npc_portrait_size = reader.ReadSingle();
            npc_portrait_base = reader.ReadString();
            return true;
        }
    }
    public class DBCheckStoryRow
    {
        public int id { get; set; } // 0x10
        public int story_id { get; set; } // 0x14
        public int story_type { get; set; } // 0x18
        public int order { get; set; } // 0x1C
        public int director_type { get; set; } // 0x20
        public int story_on { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            story_id = reader.ReadInt32();
            story_type = reader.ReadInt32();
            order = reader.ReadInt32();
            director_type = reader.ReadInt32();
            story_on = reader.ReadInt32();
            return true;
        }
    }
    public class DBCoinShopEventRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int product_sale { get; set; } // 0x18
        public int product_id { get; set; } // 0x1C
        public int product_count { get; set; } // 0x20
        public int product_type { get; set; } // 0x24
        public string price_coin_item_type { get; set; } // 0x28
        public int price_coin_type { get; set; } // 0x30
        public int price_count { get; set; } // 0x34
        public int skin_discount { get; set; } // 0x38
        public int buy_limited_count { get; set; } // 0x3C
        public int sale_limited_group { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            product_sale = reader.ReadInt32();
            product_id = reader.ReadInt32();
            product_count = reader.ReadInt32();
            product_type = reader.ReadInt32();
            price_coin_item_type = reader.ReadString();
            price_coin_type = reader.ReadInt32();
            price_count = reader.ReadInt32();
            skin_discount = reader.ReadInt32();
            buy_limited_count = reader.ReadInt32();
            sale_limited_group = reader.ReadInt32();
            return true;
        }
    }
    public class DBCoinShopLimitedRow
    {
        public int id { get; set; } // 0x10
        public int product_sale { get; set; } // 0x14
        public int product_id { get; set; } // 0x18
        public int product_count { get; set; } // 0x1C
        public string price_coin_item_type { get; set; } // 0x20
        public int price_coin_type { get; set; } // 0x28
        public int price_count { get; set; } // 0x2C
        public int skin_discount { get; set; } // 0x30
        public int buy_limited_count { get; set; } // 0x34
        public int sale_limited_group { get; set; } // 0x38
        public string buy_limited_start { get; set; } // 0x40
        public string buy_limited_end { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            product_sale = reader.ReadInt32();
            product_id = reader.ReadInt32();
            product_count = reader.ReadInt32();
            price_coin_item_type = reader.ReadString();
            price_coin_type = reader.ReadInt32();
            price_count = reader.ReadInt32();
            skin_discount = reader.ReadInt32();
            buy_limited_count = reader.ReadInt32();
            sale_limited_group = reader.ReadInt32();
            buy_limited_start = reader.ReadString();
            buy_limited_end = reader.ReadString();
            return true;
        }
    }
    public class DBCoinShopOnceRow
    {
        public int id { get; set; } // 0x10
        public int product_sale { get; set; } // 0x14
        public int product_id { get; set; } // 0x18
        public int product_count { get; set; } // 0x1C
        public string price_coin_item_type { get; set; } // 0x20
        public int price_coin_type { get; set; } // 0x28
        public int price_count { get; set; } // 0x2C
        public int skin_discount { get; set; } // 0x30
        public int buy_limited_count { get; set; } // 0x34
        public string sale_start_date { get; set; } // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            product_sale = reader.ReadInt32();
            product_id = reader.ReadInt32();
            product_count = reader.ReadInt32();
            price_coin_item_type = reader.ReadString();
            price_coin_type = reader.ReadInt32();
            price_count = reader.ReadInt32();
            skin_discount = reader.ReadInt32();
            buy_limited_count = reader.ReadInt32();
            sale_start_date = reader.ReadString();
            return true;
        }
    }
    public class DBCoinShopOrdinaryRow
    {
        public int id { get; set; } // 0x10
        public int product_sale { get; set; } // 0x14
        public int product_id { get; set; } // 0x18
        public int product_count { get; set; } // 0x1C
        public int product_free_count { get; set; } // 0x20
        public string price_coin_item_type { get; set; } // 0x28
        public int price_coin_type { get; set; } // 0x30
        public int price_count { get; set; } // 0x34
        public int skin_discount { get; set; } // 0x38
        public int buy_limited_count { get; set; } // 0x3C
        public int ad_info { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            product_sale = reader.ReadInt32();
            product_id = reader.ReadInt32();
            product_count = reader.ReadInt32();
            product_free_count = reader.ReadInt32();
            price_coin_item_type = reader.ReadString();
            price_coin_type = reader.ReadInt32();
            price_count = reader.ReadInt32();
            skin_discount = reader.ReadInt32();
            buy_limited_count = reader.ReadInt32();
            ad_info = reader.ReadInt32();
            return true;
        }
    }
    public class DBCoinShopSettingRow
    {
        public int id { get; set; } // 0x10
        public string item_type { get; set; } // 0x18
        public int rate { get; set; } // 0x20
        public int sale_days { get; set; } // 0x24
        public string item_icon { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            item_type = reader.ReadString();
            rate = reader.ReadInt32();
            sale_days = reader.ReadInt32();
            item_icon = reader.ReadString();
            return true;
        }
    }
    public class DBContentAdRow
    {
        public int id { get; set; } // 0x10
        public string ad_type { get; set; } // 0x18
        public int ad_count { get; set; } // 0x20
        public int value_type_1 { get; set; } // 0x24
        public int value_type_2 { get; set; } // 0x28
        public List<int> list_value_type = new List<int>(); // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            ad_type = reader.ReadString();
            ad_count = reader.ReadInt32();
            value_type_1 = reader.ReadInt32();
            value_type_2 = reader.ReadInt32();
            return true;
        }
    }
    public class DBContentAdRouletteRow
    {
        public int id { get; set; } // 0x10
        public string ad_type { get; set; } // 0x18
        public int item_id { get; set; } // 0x20
        public int item_count { get; set; } // 0x24
        public int rate { get; set; } // 0x28
        public int grade { get; set; } // 0x2C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            ad_type = reader.ReadString();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            rate = reader.ReadInt32();
            grade = reader.ReadInt32();
            return true;
        }
    }
    public class DBContentControlRow
    {
        public int id { get; set; } // 0x10
        public string contents { get; set; } // 0x18
        public int value_int_1 { get; set; } // 0x20
        public List<int> list_value_int = new List<int>(); // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            contents = reader.ReadString();
            value_int_1 = reader.ReadInt32();
            return true;
        }
    }
    public class DBContentCostRow
    {
        public int id { get; set; } // 0x10
        public int item_storage_add_price_cost { get; set; } // 0x14
        public int item_storage_add_value { get; set; } // 0x18
        public int weapon_storage_add_price_cost { get; set; } // 0x1C
        public int weapon_storage_add_value { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            item_storage_add_price_cost = reader.ReadInt32();
            item_storage_add_value = reader.ReadInt32();
            weapon_storage_add_price_cost = reader.ReadInt32();
            weapon_storage_add_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBContentLinkRow
    {
        public int id { get; set; } // 0x10
        public string quicklink_name { get; set; } // 0x18
        public string quicklink_icon { get; set; } // 0x20
        public string content_type { get; set; } // 0x28
        public int region { get; set; } // 0x30
        public int area_id { get; set; } // 0x34
        public string content_menu { get; set; } // 0x38
        public int matching_area_end_id { get; set; } // 0x40
        public int npc_id { get; set; } // 0x44
        public int weapon_item_id { get; set; } // 0x48
        public int content_link_check { get; set; } // 0x4C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            quicklink_name = reader.ReadString();
            quicklink_icon = reader.ReadString();
            content_type = reader.ReadString();
            region = reader.ReadInt32();
            area_id = reader.ReadInt32();
            content_menu = reader.ReadString();
            matching_area_end_id = reader.ReadInt32();
            npc_id = reader.ReadInt32();
            weapon_item_id = reader.ReadInt32();
            content_link_check = reader.ReadInt32();
            return true;
        }
    }
    public class DBContentsPassiveRow
    {
        public int id { get; set; } // 0x10
        public int reward_mark { get; set; } // 0x14
        public string icon { get; set; } // 0x18
        public string name { get; set; } // 0x20
        public string explain { get; set; } // 0x28
        public string explain_guest { get; set; } // 0x30
        public string effect_keyword { get; set; } // 0x38
        public int effect_per { get; set; } // 0x40
        public int use_time_min { get; set; } // 0x44
        public int target_item_id { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            reward_mark = reader.ReadInt32();
            icon = reader.ReadString();
            name = reader.ReadString();
            explain = reader.ReadString();
            explain_guest = reader.ReadString();
            effect_keyword = reader.ReadString();
            effect_per = reader.ReadInt32();
            use_time_min = reader.ReadInt32();
            target_item_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBControlAnotherRow
    {
        public int id { get; set; } // 0x10
        public int need_story_quest_id { get; set; } // 0x14
        public string quest_alarm_name { get; set; } // 0x18
        public string quest_alarm_desc { get; set; } // 0x20
        public string large_popup_name { get; set; } // 0x28
        public int direct_selector_id { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            need_story_quest_id = reader.ReadInt32();
            quest_alarm_name = reader.ReadString();
            quest_alarm_desc = reader.ReadString();
            large_popup_name = reader.ReadString();
            direct_selector_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBCookingListRow
    {
        public int id { get; set; } // 0x10
        public int material_id_1 { get; set; } // 0x14
        public int material_id_2 { get; set; } // 0x18
        public int material_id_3 { get; set; } // 0x1C
        public int reward_id_1 { get; set; } // 0x20
        public int reward_count_min_1 { get; set; } // 0x24
        public int reward_count_max_1 { get; set; } // 0x28
        public int reward_count_min_2 { get; set; } // 0x2C
        public int reward_count_max_2 { get; set; } // 0x30
        public int quest_index { get; set; } // 0x34
        public int quest_item_count { get; set; } // 0x38
        public List<int> list_material_id = new List<int>(); // 0x40
        public List<int> list_reward_id = new List<int>(); // 0x48
        public List<int> list_reward_count_min = new List<int>(); // 0x50
        public List<int> list_reward_count_max = new List<int>(); // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            material_id_1 = reader.ReadInt32();
            material_id_2 = reader.ReadInt32();
            material_id_3 = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_count_min_1 = reader.ReadInt32();
            reward_count_max_1 = reader.ReadInt32();
            reward_count_min_2 = reader.ReadInt32();
            reward_count_max_2 = reader.ReadInt32();
            quest_index = reader.ReadInt32();
            quest_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBCookingMaterialRow
    {
        public int id { get; set; } // 0x10
        public string category { get; set; } // 0x18
        public string category_string { get; set; } // 0x20
        public int sub_category { get; set; } // 0x28
        public int sub_category_type { get; set; } // 0x2C
        public int type { get; set; } // 0x30
        public int quest_type { get; set; } // 0x34
        public string array_quest_index { get; set; } // 0x38
        public List<int> list_array_quest_index = new List<int>(); // 0x40
        public int material_id { get; set; } // 0x48
        public string renderer_icon { get; set; } // 0x50
        public int object_type { get; set; } // 0x58
        public int recipe_link { get; set; } // 0x5C
        public int recipe_exp { get; set; } // 0x60
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            category = reader.ReadString();
            category_string = reader.ReadString();
            sub_category = reader.ReadInt32();
            sub_category_type = reader.ReadInt32();
            type = reader.ReadInt32();
            quest_type = reader.ReadInt32();
            //array_quest_index = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_quest_index.Add(reader.ReadInt32());
                v0--;
            }
            material_id = reader.ReadInt32();
            renderer_icon = reader.ReadString();
            object_type = reader.ReadInt32();
            recipe_link = reader.ReadInt32();
            recipe_exp = reader.ReadInt32();
            return true;
        }
    }
    public class DBCookingRecipeRow
    {
        public int id { get; set; } // 0x10
        public string icon { get; set; } // 0x18
        public int max_exp { get; set; } // 0x20
        public int material_id { get; set; } // 0x24
        public int cost_time { get; set; } // 0x28
        public int reward_id { get; set; } // 0x2C
        public int reward_count_1 { get; set; } // 0x30
        public int reward_count_2 { get; set; } // 0x34
        public int reward_count_3 { get; set; } // 0x38
        public int reward_count_4 { get; set; } // 0x3C
        public int reward_count_5 { get; set; } // 0x40
        public int cooking_list_link { get; set; } // 0x44
        public int cooking_item_view { get; set; } // 0x48
        public int cooking_pvp_top_100_def_team_buff { get; set; } // 0x4C
        public List<int> list_reward_count = new List<int>(); // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            icon = reader.ReadString();
            max_exp = reader.ReadInt32();
            material_id = reader.ReadInt32();
            cost_time = reader.ReadInt32();
            reward_id = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            reward_count_2 = reader.ReadInt32();
            reward_count_3 = reader.ReadInt32();
            reward_count_4 = reader.ReadInt32();
            reward_count_5 = reader.ReadInt32();
            cooking_list_link = reader.ReadInt32();
            cooking_item_view = reader.ReadInt32();
            cooking_pvp_top_100_def_team_buff = reader.ReadInt32();
            return true;
        }
    }
    public class DBCostumeBaseRow
    {
        public int id { get; set; } // 0x10
        public string costume_name { get; set; } // 0x18
        public string array_costume_hide_hero_id { get; set; } // 0x20
        public List<int> list_array_costume_hide_hero_id = new List<int>(); // 0x28
        public string array_matching_hero_id { get; set; } // 0x30
        public List<int> list_array_matching_hero_id = new List<int>(); // 0x38
        public int hero_group { get; set; } // 0x40
        public int costume_group { get; set; } // 0x44
        public int costume_type { get; set; } // 0x48
        public int costume_combination { get; set; } // 0x4C
        public int costume_sorting { get; set; } // 0x50
        public int story_id { get; set; } // 0x54
        public int costume_tier { get; set; } // 0x58
        public int costume_stat_type { get; set; } // 0x5C
        public float atk { get; set; } // 0x60
        public float fixed_atk_per { get; set; } // 0x64
        public float crit_per { get; set; } // 0x68
        public float crit_atk_per { get; set; } // 0x6C
        public float def { get; set; } // 0x70
        public float fixed_def_per { get; set; } // 0x74
        public float crit_res_per { get; set; } // 0x78
        public float crit_def_per { get; set; } // 0x7C
        public float hp { get; set; } // 0x80
        public float hp_regen_per { get; set; } // 0x84
        public float hp_recovery_per { get; set; } // 0x88
        public float hp_steal_per { get; set; } // 0x8C
        public int auto_sell_item_id { get; set; } // 0x90
        public int auto_sell_item_count { get; set; } // 0x94
        public int event_reward_index { get; set; } // 0x98
        public int set_costume_id { get; set; } // 0x9C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            costume_name = reader.ReadString();
            //array_costume_hide_hero_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_costume_hide_hero_id.Add(reader.ReadInt32());
                v0--;
            }
            //array_matching_hero_id = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_matching_hero_id.Add(reader.ReadInt32());
                v1--;
            }
            hero_group = reader.ReadInt32();
            costume_group = reader.ReadInt32();
            costume_type = reader.ReadInt32();
            costume_combination = reader.ReadInt32();
            costume_sorting = reader.ReadInt32();
            story_id = reader.ReadInt32();
            costume_tier = reader.ReadInt32();
            costume_stat_type = reader.ReadInt32();
            atk = reader.ReadSingle();
            fixed_atk_per = reader.ReadSingle();
            crit_per = reader.ReadSingle();
            crit_atk_per = reader.ReadSingle();
            def = reader.ReadSingle();
            fixed_def_per = reader.ReadSingle();
            crit_res_per = reader.ReadSingle();
            crit_def_per = reader.ReadSingle();
            hp = reader.ReadSingle();
            hp_regen_per = reader.ReadSingle();
            hp_recovery_per = reader.ReadSingle();
            hp_steal_per = reader.ReadSingle();
            auto_sell_item_id = reader.ReadInt32();
            auto_sell_item_count = reader.ReadInt32();
            event_reward_index = reader.ReadInt32();
            set_costume_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBCostumeChangeSfxRow
    {
        public int id { get; set; } // 0x10
        public int costume_id { get; set; } // 0x14
        public int sfx_id { get; set; } // 0x18
        public string change_effect_filename { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            costume_id = reader.ReadInt32();
            sfx_id = reader.ReadInt32();
            change_effect_filename = reader.ReadString();
            return true;
        }
    }
    public class DBCostumeShopRow
    {
        public int id { get; set; } // 0x10
        public int costume_shop_type { get; set; } // 0x14
        public int show_index { get; set; } // 0x18
        public string array_show_hero_name { get; set; } // 0x20
        public List<string> list_array_show_hero_name = new List<string>(); // 0x28
        public int costume_shop_group { get; set; } // 0x30
        public string shop_display_image { get; set; } // 0x38
        public string event_banner_image { get; set; } // 0x40
        public int reward_costume_id { get; set; } // 0x48
        public int price_id_1 { get; set; } // 0x4C
        public int price_count_1 { get; set; } // 0x50
        public int price_id_2 { get; set; } // 0x54
        public int price_count_2 { get; set; } // 0x58
        public int price_view_type { get; set; } // 0x5C
        public int buy_limited_count { get; set; } // 0x60
        public int product_type { get; set; } // 0x64
        public int product_condition { get; set; } // 0x68
        public int new_apparel { get; set; } // 0x6C
        public int next_sale_view { get; set; } // 0x70
        public string buy_start_date { get; set; } // 0x78
        public string buy_limited_date { get; set; } // 0x80
        public float hero_portrait_rotation { get; set; } // 0x88
        public List<int> list_price_id = new List<int>(); // 0x90
        public List<int> list_price_count = new List<int>(); // 0x98
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            costume_shop_type = reader.ReadInt32();
            show_index = reader.ReadInt32();
            //array_show_hero_name = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_show_hero_name.Add(reader.ReadString());
                v0--;
            }
            costume_shop_group = reader.ReadInt32();
            shop_display_image = reader.ReadString();
            event_banner_image = reader.ReadString();
            reward_costume_id = reader.ReadInt32();
            price_id_1 = reader.ReadInt32();
            price_count_1 = reader.ReadInt32();
            price_id_2 = reader.ReadInt32();
            price_count_2 = reader.ReadInt32();
            price_view_type = reader.ReadInt32();
            buy_limited_count = reader.ReadInt32();
            product_type = reader.ReadInt32();
            product_condition = reader.ReadInt32();
            new_apparel = reader.ReadInt32();
            next_sale_view = reader.ReadInt32();
            buy_start_date = reader.ReadString();
            buy_limited_date = reader.ReadString();
            hero_portrait_rotation = reader.ReadSingle();
            return true;
        }
    }
    public class DBCostumeShopGroupRow
    {
        public int id { get; set; } // 0x10
        public string menu_type { get; set; } // 0x18
        public string menu_title { get; set; } // 0x20
        public string scroll_type { get; set; } // 0x28
        public int shop_type { get; set; } // 0x30
        public string banner_image { get; set; } // 0x38
        public int costume_story_id { get; set; } // 0x40
        public int costume_resale { get; set; } // 0x44
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            menu_type = reader.ReadString();
            menu_title = reader.ReadString();
            scroll_type = reader.ReadString();
            shop_type = reader.ReadInt32();
            banner_image = reader.ReadString();
            costume_story_id = reader.ReadInt32();
            costume_resale = reader.ReadInt32();
            return true;
        }
    }
    public class DBCostumeShopPackageRow
    {
        public int id { get; set; } // 0x10
        public int costume_shop_type { get; set; } // 0x14
        public int costume_shop_group { get; set; } // 0x18
        public int product_id { get; set; } // 0x1C
        public int price_id { get; set; } // 0x20
        public int price_count { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            costume_shop_type = reader.ReadInt32();
            costume_shop_group = reader.ReadInt32();
            product_id = reader.ReadInt32();
            price_id = reader.ReadInt32();
            price_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBCostumeShopSettingRow
    {
        public int id { get; set; } // 0x10
        public int costume_banner_group { get; set; } // 0x14
        public int story_id { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            costume_banner_group = reader.ReadInt32();
            story_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBCostumeStatRow
    {
        public int id { get; set; } // 0x10
        public int costume_type { get; set; } // 0x14
        public int upgrade_level { get; set; } // 0x18
        public int costume_rating { get; set; } // 0x1C
        public int costume_stat_type { get; set; } // 0x20
        public int upgrade_stat_tier_1 { get; set; } // 0x24
        public int upgrade_material_id_tier_1 { get; set; } // 0x28
        public int upgrade_material_count_tier_1 { get; set; } // 0x2C
        public int upgrade_price_id_tier_1 { get; set; } // 0x30
        public int upgrade_price_count_tier_1 { get; set; } // 0x34
        public int upgrade_stat_tier_2 { get; set; } // 0x38
        public int upgrade_material_id_tier_2 { get; set; } // 0x3C
        public int upgrade_material_count_tier_2 { get; set; } // 0x40
        public int upgrade_price_id_tier_2 { get; set; } // 0x44
        public int upgrade_price_count_tier_2 { get; set; } // 0x48
        public int upgrade_stat_tier_3 { get; set; } // 0x4C
        public int upgrade_material_id_tier_3 { get; set; } // 0x50
        public int upgrade_material_count_tier_3 { get; set; } // 0x54
        public int upgrade_price_id_tier_3 { get; set; } // 0x58
        public int upgrade_price_count_tier_3 { get; set; } // 0x5C
        public int upgrade_stat_tier_4 { get; set; } // 0x60
        public int upgrade_material_id_tier_4 { get; set; } // 0x64
        public int upgrade_material_count_tier_4 { get; set; } // 0x68
        public int upgrade_price_id_tier_4 { get; set; } // 0x6C
        public int upgrade_price_count_tier_4 { get; set; } // 0x70
        public List<int> list_upgrade_stat_tier = new List<int>(); // 0x78
        public List<int> list_upgrade_material_id_tier = new List<int>(); // 0x80
        public List<int> list_upgrade_material_count_tier = new List<int>(); // 0x88
        public List<int> list_upgrade_price_id_tier = new List<int>(); // 0x90
        public List<int> list_upgrade_price_count_tier = new List<int>(); // 0x98
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            costume_type = reader.ReadInt32();
            upgrade_level = reader.ReadInt32();
            costume_rating = reader.ReadInt32();
            costume_stat_type = reader.ReadInt32();
            upgrade_stat_tier_1 = reader.ReadInt32();
            upgrade_material_id_tier_1 = reader.ReadInt32();
            upgrade_material_count_tier_1 = reader.ReadInt32();
            upgrade_price_id_tier_1 = reader.ReadInt32();
            upgrade_price_count_tier_1 = reader.ReadInt32();
            upgrade_stat_tier_2 = reader.ReadInt32();
            upgrade_material_id_tier_2 = reader.ReadInt32();
            upgrade_material_count_tier_2 = reader.ReadInt32();
            upgrade_price_id_tier_2 = reader.ReadInt32();
            upgrade_price_count_tier_2 = reader.ReadInt32();
            upgrade_stat_tier_3 = reader.ReadInt32();
            upgrade_material_id_tier_3 = reader.ReadInt32();
            upgrade_material_count_tier_3 = reader.ReadInt32();
            upgrade_price_id_tier_3 = reader.ReadInt32();
            upgrade_price_count_tier_3 = reader.ReadInt32();
            upgrade_stat_tier_4 = reader.ReadInt32();
            upgrade_material_id_tier_4 = reader.ReadInt32();
            upgrade_material_count_tier_4 = reader.ReadInt32();
            upgrade_price_id_tier_4 = reader.ReadInt32();
            upgrade_price_count_tier_4 = reader.ReadInt32();
            return true;
        }
    }
    public class DBDailyAttendanceRow
    {
        public int id { get; set; } // 0x10
        public string attendance_type { get; set; } // 0x18
        public int group { get; set; } // 0x20
        public int day { get; set; } // 0x24
        public int item_id { get; set; } // 0x28
        public int item_count { get; set; } // 0x2C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            attendance_type = reader.ReadString();
            group = reader.ReadInt32();
            day = reader.ReadInt32();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventAdditionalPaymentRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int product_id { get; set; } // 0x18
        public int reward_item_id { get; set; } // 0x1C
        public int reward_item_count { get; set; } // 0x20
        public int mailbox_id { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            product_id = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            mailbox_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBDirectSelectorRow
    {
        public int id { get; set; } // 0x10
        public int rec_group { get; set; } // 0x14
        public string type { get; set; } // 0x18
        public int format_type { get; set; } // 0x20
        public int target_id { get; set; } // 0x24
        public int before_loading_scene_id { get; set; } // 0x28
        public int after_loading_scene_id { get; set; } // 0x2C
        public int battle_Scene { get; set; } // 0x30
        public int story_chapter { get; set; } // 0x34
        public int story_type { get; set; } // 0x38
        public int story_region { get; set; } // 0x3C
        public string story_chapter_name { get; set; } // 0x40
        public string story_replay_name { get; set; } // 0x48
        public int story_replay_step { get; set; } // 0x50
        public int story_replay_title { get; set; } // 0x54
        public string skip_summary { get; set; } // 0x58
        public int dlg_next_episode { get; set; } // 0x60
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            rec_group = reader.ReadInt32();
            type = reader.ReadString();
            format_type = reader.ReadInt32();
            target_id = reader.ReadInt32();
            before_loading_scene_id = reader.ReadInt32();
            after_loading_scene_id = reader.ReadInt32();
            battle_Scene = reader.ReadInt32();
            story_chapter = reader.ReadInt32();
            story_type = reader.ReadInt32();
            story_region = reader.ReadInt32();
            story_chapter_name = reader.ReadString();
            story_replay_name = reader.ReadString();
            story_replay_step = reader.ReadInt32();
            story_replay_title = reader.ReadInt32();
            skip_summary = reader.ReadString();
            dlg_next_episode = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventRow
    {
        public int id { get; set; }// 0x10
        public string event_name { get; set; }// 0x18
        public string event_desc { get; set; }// 0x20
        public List<int> list_array_event_item = new List<int>();// 0x28
        public int event_type { get; set; }// 0x30
        public int event_sub_index { get; set; }// 0x34
        public int event_quick_link { get; set; }// 0x38
        public int rate_type_check { get; set; }// 0x3C
        public int mission_group { get; set; }// 0x40
        public List<int> list_array_exchange_event_group = new List<int>();// 0x48
        public int event_chapter { get; set; }// 0x50
        public int region { get; set; }// 0x54
        public int area { get; set; }// 0x58
        public int world_banner_on { get; set; }// 0x5C
        public string event_icon_info { get; set; }// 0x60
        public string lobby_event_icon_name { get; set; }// 0x68
        public int world_direct_move { get; set; }// 0x70
        public int stage_direct_move { get; set; }// 0x74
        public string event_first_time_main_title { get; set; }// 0x78
        public string event_first_time_desc_title { get; set; }// 0x80
        public string event_first_time_desc_sub { get; set; }// 0x88
        public int event_first_time_link { get; set; }// 0x90
        public int event_first_time_link_id { get; set; }// 0x94
        public string event_large_popup_name { get; set; }// 0x98
        public int event_video_link_id { get; set; }// 0xA0
        public int event_quest_video { get; set; }// 0xA4
        public string event_ui_slot_name { get; set; }// 0xA8
        public int content_open_popup { get; set; }// 0xB0
        public string content_open_popup_icon { get; set; }// 0xB8
        public string content_open_popup_local { get; set; }// 0xC0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_name = reader.ReadString();
            event_desc = reader.ReadString();
            //array_event_item = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_event_item.Add(reader.ReadInt32());
                v0--;
            }
            event_type = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            event_quick_link = reader.ReadInt32();
            rate_type_check = reader.ReadInt32();
            mission_group = reader.ReadInt32();
            //array_exchange_event_group = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_exchange_event_group.Add(reader.ReadInt32());
                v1--;
            }
            event_chapter = reader.ReadInt32();
            region = reader.ReadInt32();
            area = reader.ReadInt32();
            world_banner_on = reader.ReadInt32();
            event_icon_info = reader.ReadString();
            lobby_event_icon_name = reader.ReadString();
            world_direct_move = reader.ReadInt32();
            stage_direct_move = reader.ReadInt32();
            event_first_time_main_title = reader.ReadString();
            event_first_time_desc_title = reader.ReadString();
            event_first_time_desc_sub = reader.ReadString();
            event_first_time_link = reader.ReadInt32();
            event_first_time_link_id = reader.ReadInt32();
            event_large_popup_name = reader.ReadString();
            event_video_link_id = reader.ReadInt32();
            event_quest_video = reader.ReadInt32();
            event_ui_slot_name = reader.ReadString();
            content_open_popup = reader.ReadInt32();
            content_open_popup_icon = reader.ReadString();
            content_open_popup_local = reader.ReadString();
            return true;
        }
    }
    public class DBEventAltarRewardRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int reward_type { get; set; } // 0x18
        public int reward_need_item_id { get; set; } // 0x1C
        public int reward_need_item_count { get; set; } // 0x20
        public int reward_item_id { get; set; } // 0x24
        public int reward_item_count { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            reward_type = reader.ReadInt32();
            reward_need_item_id = reader.ReadInt32();
            reward_need_item_count = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventAttendanceRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public string reward_type { get; set; } // 0x18
        public int day { get; set; } // 0x20
        public int item_id { get; set; } // 0x24
        public int item_count { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            reward_type = reader.ReadString();
            day = reader.ReadInt32();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventBingoRow
    {
        public int id { get; set; } // 0x10
        public int bingo_rating { get; set; } // 0x14
        public int bingo_type { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            bingo_rating = reader.ReadInt32();
            bingo_type = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventBingoRewardRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int reward_item_id { get; set; } // 0x18
        public int reward_item_count { get; set; } // 0x1C
        public int reward_type { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            reward_type = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventBossMissionRow
    {
        public int id { get; set; } // 0x10
        public int group_id { get; set; } // 0x14
        public int stage_id { get; set; } // 0x18
        public string mission_type { get; set; } // 0x20
        public int mission_type_value { get; set; } // 0x28
        public int mission_target_value { get; set; } // 0x2C
        public int event_point_id { get; set; } // 0x30
        public int event_point_count { get; set; } // 0x34
        public int localize_display_type { get; set; } // 0x38
        public string mission_name { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            stage_id = reader.ReadInt32();
            mission_type = reader.ReadString();
            mission_type_value = reader.ReadInt32();
            mission_target_value = reader.ReadInt32();
            event_point_id = reader.ReadInt32();
            event_point_count = reader.ReadInt32();
            localize_display_type = reader.ReadInt32();
            mission_name = reader.ReadString();
            return true;
        }
    }
    public class DBEventBossSettingRow
    {
        public int id { get; set; } // 0x10
        public string event_start { get; set; } // 0x18
        public int event_use_hero_reset { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_start = reader.ReadString();
            event_use_hero_reset = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventBuffRow
    {
        public int id { get; set; } // 0x10
        public int event_buff_index { get; set; } // 0x14
        public int reward_mark { get; set; } // 0x18
        public string icon { get; set; } // 0x20
        public string title { get; set; } // 0x28
        public string explain { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_buff_index = reader.ReadInt32();
            reward_mark = reader.ReadInt32();
            icon = reader.ReadString();
            title = reader.ReadString();
            explain = reader.ReadString();
            return true;
        }
    }
    public class DBEventBingoExchangeRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int bingo_exchange_group { get; set; } // 0x18
        public int material_1 { get; set; } // 0x1C
        public int material_count_1 { get; set; } // 0x20
        public int reward_1 { get; set; } // 0x24
        public int reward_count_1 { get; set; } // 0x28
        public int event_bingo_random_id { get; set; } // 0x2C
        public List<int> list_material = new List<int>(); // 0x30
        public List<int> list_material_count = new List<int>(); // 0x38
        public List<int> list_reward = new List<int>(); // 0x40
        public List<int> list_reward_count = new List<int>(); // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            bingo_exchange_group = reader.ReadInt32();
            material_1 = reader.ReadInt32();
            material_count_1 = reader.ReadInt32();
            reward_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            event_bingo_random_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventBingoGachaRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int item_id { get; set; } // 0x18
        public int item_count { get; set; } // 0x1C
        public int rate { get; set; } // 0x20
        public int grade { get; set; } // 0x24
        public int need_item { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            rate = reader.ReadInt32();
            grade = reader.ReadInt32();
            need_item = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventBingoRandomRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int bingo_event_type { get; set; } // 0x18
        public int bingo_event_board_view_number { get; set; } // 0x1C
        public int bingo_event_numberitem { get; set; } // 0x20
        public int Highlight_numbers { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            bingo_event_type = reader.ReadInt32();
            bingo_event_board_view_number = reader.ReadInt32();
            bingo_event_numberitem = reader.ReadInt32();
            Highlight_numbers = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventLabelInfoRow
    {
        public int id { get; set; } // 0x10
        public string event_highlight_name { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_highlight_name = reader.ReadString();
            return true;
        }
    }
    public class DBEventMissionScoreSetRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int last_reward_count { get; set; } // 0x18
        public int last_reward_get_count { get; set; } // 0x1C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            last_reward_count = reader.ReadInt32();
            last_reward_get_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBForumControlRow
    {
        public int id { get; set; } // 0x10
        public byte url_1 { get; set; } // 0x14
        public byte url_2 { get; set; } // 0x15
        public byte url_3 { get; set; } // 0x16
        public byte url_4 { get; set; } // 0x17
        public byte url_5 { get; set; } // 0x18
        public byte url_6 { get; set; } // 0x19
        public byte url_7 { get; set; } // 0x1A
        public List<byte> list_url = new List<byte>(); // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            url_1 = reader.ReadByte();
            url_2 = reader.ReadByte();
            url_3 = reader.ReadByte();
            url_4 = reader.ReadByte();
            url_5 = reader.ReadByte();
            url_6 = reader.ReadByte();
            url_7 = reader.ReadByte();
            return true;
        }
    }
    public class DBGambleBonusRewardRow
    {
        public int index { get; set; } // 0x10
        public int gacha_bonus_reward_group_id { get; set; } // 0x14
        public int gacha_bonus_reward_type { get; set; } // 0x18
        public int gacha_bonus_reward { get; set; } // 0x1C
        public int gacha_bonus_count { get; set; } // 0x20
        public int gacha_bonus_reward_rate { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            index = reader.ReadInt32();
            gacha_bonus_reward_group_id = reader.ReadInt32();
            gacha_bonus_reward_type = reader.ReadInt32();
            gacha_bonus_reward = reader.ReadInt32();
            gacha_bonus_count = reader.ReadInt32();
            gacha_bonus_reward_rate = reader.ReadInt32();
            return true;
        }
    }
    public class DBGlobalChannelSettingRow
    {
        public int id { get; set; } // 0x10
        public string lang_system { get; set; } // 0x18
        public string lang_code { get; set; } // 0x20
        public int ch_min { get; set; } // 0x28
        public int ch_max { get; set; } // 0x2C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            lang_system = reader.ReadString();
            lang_code = reader.ReadString();
            ch_min = reader.ReadInt32();
            ch_max = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildWarBuffRow
    {
        public int id { get; set; } // 0x10
        public string passive_type { get; set; } // 0x18
        public int passive_id { get; set; } // 0x20
        public int use_count { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            passive_type = reader.ReadString();
            passive_id = reader.ReadInt32();
            use_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildWarConfigRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string value_string { get; set; } // 0x20
        public int value_int { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            value_string = reader.ReadString();
            value_int = reader.ReadInt32();
            return true;
        }
    }
    public class DBPvpSmashShopGradeRow
    {
        public int id { get; set; } // 0x10
        public int need_buy_point { get; set; } // 0x14
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            need_buy_point = reader.ReadInt32();
            return true;
        }
    }
    public class DBSpecialPriceScheduleRow
    {
        public int id { get; set; } // 0x10
        public int special_price_group { get; set; } // 0x14
        public int special_price_group_index { get; set; } // 0x18
        public int special_price_package_id { get; set; } // 0x1C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            special_price_group = reader.ReadInt32();
            special_price_group_index = reader.ReadInt32();
            special_price_package_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageBossSeasonRow
    {
        public int id { get; set; } // 0x10
        public string season_start { get; set; } // 0x18
        public string season_end { get; set; } // 0x20
        public int active_day { get; set; } // 0x28
        public int inactive_day { get; set; } // 0x2C
        public string season_title { get; set; } // 0x30
        public string large_popup { get; set; } // 0x38
        public string event_banner { get; set; } // 0x40
        public string season_info { get; set; } // 0x48
        public int disaster_group_cutin { get; set; } // 0x50
        public List<int> list_array_exchange_event_group = new List<int>(); // 0x58
        public string lobby_disaster_icon_name { get; set; } // 0x60
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            season_start = reader.ReadString();
            season_end = reader.ReadString();
            active_day = reader.ReadInt32();
            inactive_day = reader.ReadInt32();
            season_title = reader.ReadString();
            large_popup = reader.ReadString();
            event_banner = reader.ReadString();
            season_info = reader.ReadString();
            disaster_group_cutin = reader.ReadInt32();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_exchange_event_group.Add(reader.ReadInt32());
                v1--;
            }
            lobby_disaster_icon_name = reader.ReadString();
            return true;
        }
    }
    public class DBPvpSmashShopRow
    {
        public int id { get; set; } // 0x10
        public int basepoint_id { get; set; } // 0x14
        public int npc_id { get; set; } // 0x18
        public int tab_index { get; set; } // 0x1C
        public int pvp_smash_buy_grade { get; set; } // 0x20
        public int shop_item_id { get; set; } // 0x24
        public int product_count { get; set; } // 0x28
        public int buy_limited_count { get; set; } // 0x2C
        public int price_id_1 { get; set; } // 0x30
        public int price_count_1 { get; set; } // 0x34
        public List<int> list_price_id = new List<int>(); // 0x38
        public List<int> list_price_count = new List<int>(); // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            basepoint_id = reader.ReadInt32();
            npc_id = reader.ReadInt32();
            tab_index = reader.ReadInt32();
            pvp_smash_buy_grade = reader.ReadInt32();
            shop_item_id = reader.ReadInt32();
            product_count = reader.ReadInt32();
            buy_limited_count = reader.ReadInt32();
            price_id_1 = reader.ReadInt32();
            price_count_1 = reader.ReadInt32();
            return true;
        }
    }
    public class DBPvpSmashShopRewardRow
    {
        public int id { get; set; } // 0x10
        public int reward_order { get; set; } // 0x14
        public int need_buy_count { get; set; } // 0x18
        public int reward_item_id { get; set; } // 0x1C
        public int reward_count { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            reward_order = reader.ReadInt32();
            need_buy_count = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBPvpSmashRewardRow
    {
        public int id { get; set; } // 0x10
        public int reward_type { get; set; } // 0x14
        public string rank_type { get; set; } // 0x18
        public int rank_value_min { get; set; } // 0x20
        public int rank_value_max { get; set; } // 0x24
        public int reward_id_1 { get; set; } // 0x28
        public int reward_count_1 { get; set; } // 0x2C
        public List<int> list_reward_id = new List<int>(); // 0x30
        public List<int> list_reward_count = new List<int>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            reward_type = reader.ReadInt32();
            rank_type = reader.ReadString();
            rank_value_min = reader.ReadInt32();
            rank_value_max = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            return true;
        }
    }
    public class DBPatrolRow
    {
        public int id { get; set; } // 0x10
        public int patrol_group_id { get; set; } // 0x14
        public string patrol_name { get; set; } // 0x18
        public int patrol_need_item_id { get; set; } // 0x20
        public int patrol_need_item_count { get; set; } // 0x24
        public int patrol_open_quest_id { get; set; } // 0x28
        public int need_hero_rating { get; set; } // 0x2C
        public int need_hero_rating_count { get; set; } // 0x30
        public int need_hero_attribute { get; set; } // 0x34
        public int need_hero_attribute_count { get; set; } // 0x38
        public int need_hero_teampower { get; set; } // 0x3C
        public int complete_time { get; set; } // 0x40
        public int reward_item_id_1 { get; set; } // 0x44
        public int reward_item_value_1 { get; set; } // 0x48
        public int reward_item_id_2 { get; set; } // 0x4C
        public int reward_item_value_2 { get; set; } // 0x50
        public int reward_item_id_3 { get; set; } // 0x54
        public int reward_item_value_3 { get; set; } // 0x58
        public int reward_item_id_4 { get; set; } // 0x5C
        public int reward_item_value_4 { get; set; } // 0x60
        public List<int> list_reward_item_id = new List<int>(); // 0x68
        public List<int> list_reward_item_value = new List<int>(); // 0x70
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            patrol_group_id = reader.ReadInt32();
            patrol_name = reader.ReadString();
            patrol_need_item_id = reader.ReadInt32();
            patrol_need_item_count = reader.ReadInt32();
            patrol_open_quest_id = reader.ReadInt32();
            need_hero_rating = reader.ReadInt32();
            need_hero_rating_count = reader.ReadInt32();
            need_hero_attribute = reader.ReadInt32();
            need_hero_attribute_count = reader.ReadInt32();
            need_hero_teampower = reader.ReadInt32();
            complete_time = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_value_1 = reader.ReadInt32();
            reward_item_id_2 = reader.ReadInt32();
            reward_item_value_2 = reader.ReadInt32();
            reward_item_id_3 = reader.ReadInt32();
            reward_item_value_3 = reader.ReadInt32();
            reward_item_id_4 = reader.ReadInt32();
            reward_item_value_4 = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventLobbyRow
    {
        public int id { get; set; } // 0x10
        public int event_group { get; set; } // 0x14
        public string contents_type { get; set; } // 0x18
        public int event_type { get; set; } // 0x20
        public int event_sub_index { get; set; } // 0x24
        public int lobby_ui_index { get; set; } // 0x28
        public int ui_group { get; set; } // 0x2C
        public int ui_group_sub_index { get; set; } // 0x30
        public int view_index { get; set; } // 0x34
        public int button_style { get; set; } // 0x38
        public int event_icon_index { get; set; } // 0x3C
        public string title_name { get; set; } // 0x40
        public string image_name { get; set; } // 0x48
        public string description { get; set; } // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_group = reader.ReadInt32();
            contents_type = reader.ReadString();
            event_type = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            lobby_ui_index = reader.ReadInt32();
            ui_group = reader.ReadInt32();
            ui_group_sub_index = reader.ReadInt32();
            view_index = reader.ReadInt32();
            button_style = reader.ReadInt32();
            event_icon_index = reader.ReadInt32();
            title_name = reader.ReadString();
            image_name = reader.ReadString();
            description = reader.ReadString();
            return true;
        }
    }
    public class DBEventChallengeDestroyRow
    {
        public int id { get; set; } // 0x10
        public int group_id { get; set; } // 0x14
        public int limit_index { get; set; } // 0x18
        public int reward_need_count { get; set; } // 0x1C
        public int reward_item_id_1 { get; set; } // 0x20
        public int reward_item_count_1 { get; set; } // 0x24
        public int reward_item_id_2 { get; set; } // 0x28
        public int reward_item_count_2 { get; set; } // 0x2C
        public int reward_item_id_3 { get; set; } // 0x30
        public int reward_item_count_3 { get; set; } // 0x34
        public int reward_item_id_4 { get; set; } // 0x38
        public int reward_item_count_4 { get; set; } // 0x3C
        public int reward_item_id_5 { get; set; } // 0x40
        public int reward_item_count_5 { get; set; } // 0x44
        public List<int> list_reward_item_id = new List<int>(); // 0x48
        public List<int> list_reward_item_count = new List<int>(); // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            limit_index = reader.ReadInt32();
            reward_need_count = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            reward_item_id_2 = reader.ReadInt32();
            reward_item_count_2 = reader.ReadInt32();
            reward_item_id_3 = reader.ReadInt32();
            reward_item_count_3 = reader.ReadInt32();
            reward_item_id_4 = reader.ReadInt32();
            reward_item_count_4 = reader.ReadInt32();
            reward_item_id_5 = reader.ReadInt32();
            reward_item_count_5 = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventChallengeDestroyscoreRow
    {
        public int id { get; set; } // 0x10
        public int challenge_destroy_id { get; set; } // 0x14
        public int reward_need_count { get; set; } // 0x18
        public int reward_item_id { get; set; } // 0x1C
        public int reward_item_count { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            challenge_destroy_id = reader.ReadInt32();
            reward_need_count = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventDonationRow
    {
        public int id { get; set; } // 0x10
        public int basepoint_id { get; set; } // 0x14
        public int reward_condition_1 { get; set; } // 0x18
        public int reward_item_id_1 { get; set; } // 0x1C
        public int reward_item_count_1 { get; set; } // 0x20
        public int reward_condition_2 { get; set; } // 0x24
        public int reward_item_id_2 { get; set; } // 0x28
        public int reward_item_count_2 { get; set; } // 0x2C
        public int reward_condition_3 { get; set; } // 0x30
        public int reward_item_id_3 { get; set; } // 0x34
        public int reward_item_count_3 { get; set; } // 0x38
        public List<int> list_reward_condition = new List<int>(); // 0x40
        public List<int> list_reward_item_id = new List<int>(); // 0x48
        public List<int> list_reward_item_count = new List<int>(); // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            basepoint_id = reader.ReadInt32();
            reward_condition_1 = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            reward_condition_2 = reader.ReadInt32();
            reward_item_id_2 = reader.ReadInt32();
            reward_item_count_2 = reader.ReadInt32();
            reward_condition_3 = reader.ReadInt32();
            reward_item_id_3 = reader.ReadInt32();
            reward_item_count_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventExchangeRow
    {
        public int id { get; set; } // 0x10
        public int exchange_category { get; set; } // 0x14
        public int daily_exchange_count { get; set; } // 0x18
        public int exchange_count { get; set; } // 0x1C
        public int material_1 { get; set; } // 0x20
        public int material_count_1 { get; set; } // 0x24
        public int material_2 { get; set; } // 0x28
        public int material_count_2 { get; set; } // 0x2C
        public int material_3 { get; set; } // 0x30
        public int material_count_3 { get; set; } // 0x34
        public int material_4 { get; set; } // 0x38
        public int material_count_4 { get; set; } // 0x3C
        public int material_5 { get; set; } // 0x40
        public int material_count_5 { get; set; } // 0x44
        public int reward_1 { get; set; } // 0x48
        public int reward_evolution_count_1 { get; set; } // 0x4C
        public int reward_count_1 { get; set; } // 0x50
        public List<int> list_material = new List<int>(); // 0x58
        public List<int> list_material_count = new List<int>(); // 0x60
        public List<int> list_reward = new List<int>(); // 0x68
        public List<int> list_reward_evolution_count = new List<int>(); // 0x70
        public List<int> list_reward_count = new List<int>(); // 0x78
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            exchange_category = reader.ReadInt32();
            daily_exchange_count = reader.ReadInt32();
            exchange_count = reader.ReadInt32();
            material_1 = reader.ReadInt32();
            material_count_1 = reader.ReadInt32();
            material_2 = reader.ReadInt32();
            material_count_2 = reader.ReadInt32();
            material_3 = reader.ReadInt32();
            material_count_3 = reader.ReadInt32();
            material_4 = reader.ReadInt32();
            material_count_4 = reader.ReadInt32();
            material_5 = reader.ReadInt32();
            material_count_5 = reader.ReadInt32();
            reward_1 = reader.ReadInt32();
            reward_evolution_count_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventExchangeBoxRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int item_id { get; set; } // 0x18
        public int item_count { get; set; } // 0x1C
        public int exchange_count { get; set; } // 0x20
        public int rate { get; set; } // 0x24
        public int grade { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            exchange_count = reader.ReadInt32();
            rate = reader.ReadInt32();
            grade = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventExchangeBoxSettingRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int list_reset_item { get; set; } // 0x18
        public int list_reset_count { get; set; } // 0x1C
        public int gamble_item_id { get; set; } // 0x20
        public int gamble_count_1 { get; set; } // 0x24
        public int gamble_dia_id { get; set; } // 0x28
        public int gamble_item_count_1 { get; set; } // 0x2C
        public int gamble_dia_count_1 { get; set; } // 0x30
        public int gamble_count_2 { get; set; } // 0x34
        public int gamble_item_count_2 { get; set; } // 0x38
        public int gamble_dia_count_2 { get; set; } // 0x3C
        public string event_start { get; set; } // 0x40
        public int event_reset { get; set; } // 0x48
        public List<int> list_gamble_count = new List<int>(); // 0x50
        public List<int> list_gamble_item_count = new List<int>(); // 0x58
        public List<int> list_gamble_dia_count = new List<int>(); // 0x60
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            list_reset_item = reader.ReadInt32();
            list_reset_count = reader.ReadInt32();
            gamble_item_id = reader.ReadInt32();
            gamble_count_1 = reader.ReadInt32();
            gamble_dia_id = reader.ReadInt32();
            gamble_item_count_1 = reader.ReadInt32();
            gamble_dia_count_1 = reader.ReadInt32();
            gamble_count_2 = reader.ReadInt32();
            gamble_item_count_2 = reader.ReadInt32();
            gamble_dia_count_2 = reader.ReadInt32();
            event_start = reader.ReadString();
            event_reset = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventFortuneAttendanceRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public string reward_type { get; set; } // 0x18
        public int reward_sub_type { get; set; } // 0x20
        public string reward_title { get; set; } // 0x28
        public string reward_sub_desc { get; set; } // 0x30
        public int day_random { get; set; } // 0x38
        public int item_id { get; set; } // 0x3C
        public int item_count { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            reward_type = reader.ReadString();
            reward_sub_type = reader.ReadInt32();
            reward_title = reader.ReadString();
            reward_sub_desc = reader.ReadString();
            day_random = reader.ReadInt32();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventFurnitureRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int furniture_id { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            furniture_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventLadderRewardRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int mid_reward_type { get; set; } // 0x18
        public int mid_reward { get; set; } // 0x1C
        public int mid_reward_count { get; set; } // 0x20
        public int top_reward_type { get; set; } // 0x24
        public int top_reward { get; set; } // 0x28
        public int top_reward_count { get; set; } // 0x2C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            mid_reward_type = reader.ReadInt32();
            mid_reward = reader.ReadInt32();
            mid_reward_count = reader.ReadInt32();
            top_reward_type = reader.ReadInt32();
            top_reward = reader.ReadInt32();
            top_reward_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventLobbyGiftRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int reward_item_order { get; set; } // 0x18
        public int reward_item_id { get; set; } // 0x1C
        public int reward_item_count { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            reward_item_order = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventMissionRow
    {
        public int id { get; set; }// 0x10
        public int mission_group { get; set; }// 0x14
        public int season_pass_weeks { get; set; }// 0x18
        public int category { get; set; }// 0x1C
        public string season_pass_mission_category { get; set; }// 0x20
        public int group_id { get; set; }// 0x28
        public int group_index { get; set; }// 0x2C
        public int chain_id { get; set; }// 0x30
        public int chain_index { get; set; }// 0x34
        public string mission_type { get; set; }// 0x38
        public int mission_type_value { get; set; }// 0x40
        public int mission_target_value { get; set; }// 0x44
        public int mission_stage { get; set; }// 0x48
        public int mission_hero { get; set; }// 0x4C
        public int alarm_type { get; set; }// 0x50
        public int reward_item_id_1 { get; set; }// 0x54
        public int reward_item_count_1 { get; set; }// 0x58
        public int reward_item_id_2 { get; set; }// 0x5C
        public int reward_item_count_2 { get; set; }// 0x60
        public int reward_item_id_3 { get; set; }// 0x64
        public int reward_item_count_3 { get; set; }// 0x68
        public int reward_item_id_4 { get; set; }// 0x6C
        public int reward_item_count_4 { get; set; }// 0x70
        public int reward_achievepoint_value { get; set; }// 0x74
        public int reward_period_day { get; set; }// 0x78
        public int localize_display_type { get; set; }// 0x7C
        public int display_title { get; set; }// 0x80
        public string icon_info { get; set; }// 0x88
        public string mission_title { get; set; }// 0x90
        public string mission_name { get; set; }// 0x98
        public int mission_quick_link { get; set; }// 0xA0
        public List<int> list_reward_item_id = new List<int>();// 0xA8
        public List<int> list_reward_item_count = new List<int>();// 0xB0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            mission_group = reader.ReadInt32();
            season_pass_weeks = reader.ReadInt32();
            category = reader.ReadInt32();
            season_pass_mission_category = reader.ReadString();
            group_id = reader.ReadInt32();
            group_index = reader.ReadInt32();
            chain_id = reader.ReadInt32();
            chain_index = reader.ReadInt32();
            mission_type = reader.ReadString();
            mission_type_value = reader.ReadInt32();
            mission_target_value = reader.ReadInt32();
            mission_stage = reader.ReadInt32();
            mission_hero = reader.ReadInt32();
            alarm_type = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            reward_item_id_2 = reader.ReadInt32();
            reward_item_count_2 = reader.ReadInt32();
            reward_item_id_3 = reader.ReadInt32();
            reward_item_count_3 = reader.ReadInt32();
            reward_item_id_4 = reader.ReadInt32();
            reward_item_count_4 = reader.ReadInt32();
            reward_achievepoint_value = reader.ReadInt32();
            reward_period_day = reader.ReadInt32();
            localize_display_type = reader.ReadInt32();
            display_title = reader.ReadInt32();
            icon_info = reader.ReadString();
            mission_title = reader.ReadString();
            mission_name = reader.ReadString();
            mission_quick_link = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventMissionAchievepointRow
    {
        public int id { get; set; } // 0x10
        public int reward_order { get; set; } // 0x14
        public int mission_target_value { get; set; } // 0x18
        public int reward_item_id_1 { get; set; } // 0x1C
        public int reward_item_count_1 { get; set; } // 0x20
        public string name { get; set; } // 0x28
        public List<int> list_reward_item_id = new List<int>(); // 0x30
        public List<int> list_reward_item_count = new List<int>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            reward_order = reader.ReadInt32();
            mission_target_value = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            name = reader.ReadString();
            return true;
        }
    }
    public class DBEventMissionRewardRow
    {
        public int id { get; set; } // 0x10
        public int mission_group { get; set; } // 0x14
        public int item_id_1 { get; set; } // 0x18
        public int item_count_1 { get; set; } // 0x1C
        public List<int> list_item_id = new List<int>(); // 0x20
        public List<int> list_item_count = new List<int>(); // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            mission_group = reader.ReadInt32();
            item_id_1 = reader.ReadInt32();
            item_count_1 = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventMissionScoreRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int event_point_id { get; set; } // 0x18
        public int reward_need_count { get; set; } // 0x1C
        public int reward_item_id { get; set; } // 0x20
        public int reward_item_count { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            event_point_id = reader.ReadInt32();
            reward_need_count = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventMonthlySettingRow
    {
        public int id { get; set; } // 0x10
        public string event_start_date { get; set; } // 0x18
        public string event_limited_date { get; set; } // 0x20
        public string event_title { get; set; } // 0x28
        public string event_icon_info { get; set; } // 0x30
        public int story_set { get; set; } // 0x38
        public int story_id_1 { get; set; } // 0x3C
        public int story_id_2 { get; set; } // 0x40
        public int story_id_3 { get; set; } // 0x44
        public int story_id_4 { get; set; } // 0x48
        public int story_id_5 { get; set; } // 0x4C
        public int count_reward_set { get; set; } // 0x50
        public int count_reward_need_point_1 { get; set; } // 0x54
        public int count_reward_id_1 { get; set; } // 0x58
        public int count_reward_value_1 { get; set; } // 0x5C
        public int count_reward_need_point_2 { get; set; } // 0x60
        public int count_reward_id_2 { get; set; } // 0x64
        public int count_reward_value_2 { get; set; } // 0x68
        public int count_reward_need_point_3 { get; set; } // 0x6C
        public int count_reward_id_3 { get; set; } // 0x70
        public int count_reward_value_3 { get; set; } // 0x74
        public int count_reward_need_point_4 { get; set; } // 0x78
        public int count_reward_id_4 { get; set; } // 0x7C
        public int count_reward_value_4 { get; set; } // 0x80
        public int count_reward_need_point_5 { get; set; } // 0x84
        public int count_reward_id_5 { get; set; } // 0x88
        public int count_reward_value_5 { get; set; } // 0x8C
        public List<int> list_story_id = new List<int>(); // 0x90
        public List<int> list_count_reward_need_point = new List<int>(); // 0x98
        public List<int> list_count_reward_id = new List<int>(); // 0xA0
        public List<int> list_count_reward_value = new List<int>(); // 0xA8
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_start_date = reader.ReadString();
            event_limited_date = reader.ReadString();
            event_title = reader.ReadString();
            event_icon_info = reader.ReadString();
            story_set = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            story_id_4 = reader.ReadInt32();
            story_id_5 = reader.ReadInt32();
            count_reward_set = reader.ReadInt32();
            count_reward_need_point_1 = reader.ReadInt32();
            count_reward_id_1 = reader.ReadInt32();
            count_reward_value_1 = reader.ReadInt32();
            count_reward_need_point_2 = reader.ReadInt32();
            count_reward_id_2 = reader.ReadInt32();
            count_reward_value_2 = reader.ReadInt32();
            count_reward_need_point_3 = reader.ReadInt32();
            count_reward_id_3 = reader.ReadInt32();
            count_reward_value_3 = reader.ReadInt32();
            count_reward_need_point_4 = reader.ReadInt32();
            count_reward_id_4 = reader.ReadInt32();
            count_reward_value_4 = reader.ReadInt32();
            count_reward_need_point_5 = reader.ReadInt32();
            count_reward_id_5 = reader.ReadInt32();
            count_reward_value_5 = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventMonthlyStoryRow
    {
        public int id { get; set; } // 0x10
        public string banner_image { get; set; } // 0x18
        public string banner_title_text { get; set; } // 0x20
        public string banner_title_text_color { get; set; } // 0x28
        public string banner_story_text { get; set; } // 0x30
        public string banner_story_color { get; set; } // 0x38
        public string banner_dimmed_color { get; set; } // 0x40
        public int stage_set { get; set; } // 0x48
        public int stage_id_1 { get; set; } // 0x4C
        public int stage_id_2 { get; set; } // 0x50
        public int stage_id_3 { get; set; } // 0x54
        public int stage_id_4 { get; set; } // 0x58
        public int stage_id_5 { get; set; } // 0x5C
        public List<int> list_stage_id = new List<int>(); // 0x60
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            banner_image = reader.ReadString();
            banner_title_text = reader.ReadString();
            banner_title_text_color = reader.ReadString();
            banner_story_text = reader.ReadString();
            banner_story_color = reader.ReadString();
            banner_dimmed_color = reader.ReadString();
            stage_set = reader.ReadInt32();
            stage_id_1 = reader.ReadInt32();
            stage_id_2 = reader.ReadInt32();
            stage_id_3 = reader.ReadInt32();
            stage_id_4 = reader.ReadInt32();
            stage_id_5 = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventPaybackRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int reward_order { get; set; } // 0x18
        public int target_value { get; set; } // 0x1C
        public int reward_item_id { get; set; } // 0x20
        public int reward_item_count { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            reward_order = reader.ReadInt32();
            target_value = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventPlaycountRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int event_sub_type { get; set; } // 0x18
        public int play_count { get; set; } // 0x1C
        public int reward_1 { get; set; } // 0x20
        public int reward_evolution_count_1 { get; set; } // 0x24
        public int reward_count_1 { get; set; } // 0x28
        public int reward_2 { get; set; } // 0x2C
        public int reward_evolution_count_2 { get; set; } // 0x30
        public int reward_count_2 { get; set; } // 0x34
        public int reward_3 { get; set; } // 0x38
        public int reward_evolution_count_3 { get; set; } // 0x3C
        public int reward_count_3 { get; set; } // 0x40
        public int reward_4 { get; set; } // 0x44
        public int reward_evolution_count_4 { get; set; } // 0x48
        public int reward_count_4 { get; set; } // 0x4C
        public List<int> list_reward = new List<int>(); // 0x50
        public List<int> list_reward_evolution_count = new List<int>(); // 0x58
        public List<int> list_reward_count = new List<int>(); // 0x60
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            event_sub_type = reader.ReadInt32();
            play_count = reader.ReadInt32();
            reward_1 = reader.ReadInt32();
            reward_evolution_count_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            reward_2 = reader.ReadInt32();
            reward_evolution_count_2 = reader.ReadInt32();
            reward_count_2 = reader.ReadInt32();
            reward_3 = reader.ReadInt32();
            reward_evolution_count_3 = reader.ReadInt32();
            reward_count_3 = reader.ReadInt32();
            reward_4 = reader.ReadInt32();
            reward_evolution_count_4 = reader.ReadInt32();
            reward_count_4 = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventRhittaRewardRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int reward_condition_item { get; set; } // 0x18
        public int reward_condition_count { get; set; } // 0x1C
        public int reward_item_id { get; set; } // 0x20
        public int reward_item_count { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            reward_condition_item = reader.ReadInt32();
            reward_condition_count = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventSetupRow
    {
        public int id { get; set; } // 0x10
        public int event_type { get; set; } // 0x14
        public int event_sub_index { get; set; } // 0x18
        public int open_time_1 { get; set; } // 0x1C
        public int close_time_1 { get; set; } // 0x20
        public int open_time_2 { get; set; } // 0x24
        public int close_time_2 { get; set; } // 0x28
        public int open_time_3 { get; set; } // 0x2C
        public int close_time_3 { get; set; } // 0x30
        public int hero_check_1 { get; set; } // 0x34
        public int hero_check_2 { get; set; } // 0x38
        public int hero_check_3 { get; set; } // 0x3C
        public int user_rank { get; set; } // 0x40
        public int hero_grade { get; set; } // 0x44
        public int hero_grade_value { get; set; } // 0x48
        public int open_quest_id { get; set; } // 0x4C
        public List<int> list_open_time = new List<int>(); // 0x50
        public List<int> list_close_time = new List<int>(); // 0x58
        public List<int> list_hero_check = new List<int>(); // 0x60
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_type = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            open_time_1 = reader.ReadInt32();
            close_time_1 = reader.ReadInt32();
            open_time_2 = reader.ReadInt32();
            close_time_2 = reader.ReadInt32();
            open_time_3 = reader.ReadInt32();
            close_time_3 = reader.ReadInt32();
            hero_check_1 = reader.ReadInt32();
            hero_check_2 = reader.ReadInt32();
            hero_check_3 = reader.ReadInt32();
            user_rank = reader.ReadInt32();
            hero_grade = reader.ReadInt32();
            hero_grade_value = reader.ReadInt32();
            open_quest_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBEventTimeMissionRow
    {
        public int id { get; set; } // 0x10
        public int mission_group { get; set; } // 0x14
        public int time_mission_day { get; set; } // 0x18
        public int chain_id { get; set; } // 0x1C
        public int chain_index { get; set; } // 0x20
        public string mission_type { get; set; } // 0x28
        public int mission_type_value { get; set; } // 0x30
        public int mission_target_value { get; set; } // 0x34
        public int mission_stage { get; set; } // 0x38
        public int mission_hero { get; set; } // 0x3C
        public int reward_item_id_1 { get; set; } // 0x40
        public int reward_item_count_1 { get; set; } // 0x44
        public string mission_name { get; set; } // 0x48
        public List<int> list_reward_item_id = new List<int>(); // 0x50
        public List<int> list_reward_item_count = new List<int>(); // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            mission_group = reader.ReadInt32();
            time_mission_day = reader.ReadInt32();
            chain_id = reader.ReadInt32();
            chain_index = reader.ReadInt32();
            mission_type = reader.ReadString();
            mission_type_value = reader.ReadInt32();
            mission_target_value = reader.ReadInt32();
            mission_stage = reader.ReadInt32();
            mission_hero = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            mission_name = reader.ReadString();
            return true;
        }
    }
    public class DBEvolutionBreakBaseRow
    {
        public int id { get; set; } // 0x10
        public int start_rating { get; set; } // 0x14
        public int evolution_break_attribute { get; set; } // 0x18
        public int evolution_break_step { get; set; } // 0x1C
        public int evolution_break_level_up { get; set; } // 0x20
        public int evolution_break_key_id { get; set; } // 0x24
        public int evolution_break_key_count { get; set; } // 0x28
        public int evolution_break_material_id_1 { get; set; } // 0x2C
        public int evolution_break_material_count_1 { get; set; } // 0x30
        public int evolution_break_material_id_2 { get; set; } // 0x34
        public int evolution_break_material_count_2 { get; set; } // 0x38
        public int evolution_break_material_id_3 { get; set; } // 0x3C
        public int evolution_break_material_count_3 { get; set; } // 0x40
        public int evolution_break_price_id { get; set; } // 0x44
        public int evolution_break_price_count { get; set; } // 0x48
        public List<int> list_evolution_break_material_id = new List<int>(); // 0x50
        public List<int> list_evolution_break_material_count = new List<int>(); // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            start_rating = reader.ReadInt32();
            evolution_break_attribute = reader.ReadInt32();
            evolution_break_step = reader.ReadInt32();
            evolution_break_level_up = reader.ReadInt32();
            evolution_break_key_id = reader.ReadInt32();
            evolution_break_key_count = reader.ReadInt32();
            evolution_break_material_id_1 = reader.ReadInt32();
            evolution_break_material_count_1 = reader.ReadInt32();
            evolution_break_material_id_2 = reader.ReadInt32();
            evolution_break_material_count_2 = reader.ReadInt32();
            evolution_break_material_id_3 = reader.ReadInt32();
            evolution_break_material_count_3 = reader.ReadInt32();
            evolution_break_price_id = reader.ReadInt32();
            evolution_break_price_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBEvolutionBreakMaxRow
    {
        public int id { get; set; } // 0x10
        public int need_quest_id { get; set; } // 0x14
        public int need_main_stage_id { get; set; } // 0x18
        public int red_evolution_break_max { get; set; } // 0x1C
        public int green_evolution_break_max { get; set; } // 0x20
        public int blue_evolution_break_max { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            need_main_stage_id = reader.ReadInt32();
            red_evolution_break_max = reader.ReadInt32();
            green_evolution_break_max = reader.ReadInt32();
            blue_evolution_break_max = reader.ReadInt32();
            return true;
        }
    }
    public class DBFacialAniNameRow
    {
        public int id { get; set; } // 0x10
        public int type { get; set; } // 0x14
        public string facial_type_name { get; set; } // 0x18
        public string facial_name_local { get; set; } // 0x20
        public int sound_id { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadInt32();
            facial_type_name = reader.ReadString();
            facial_name_local = reader.ReadString();
            sound_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBFadeInoutRow
    {
        public int id { get; set; } // 0x10
        public string fade_gui { get; set; } // 0x18
        public string in_anim_name { get; set; } // 0x20
        public string out_anim_name { get; set; } // 0x28
        public int frame_skip_count { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            fade_gui = reader.ReadString();
            in_anim_name = reader.ReadString();
            out_anim_name = reader.ReadString();
            frame_skip_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBFateMonsterRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public int monster_group_id { get; set; } // 0x20
        public string array_hero_id { get; set; } // 0x28
        public List<int> list_array_hero_id = new List<int>(); // 0x30
        public string array_passive_id { get; set; } // 0x38
        public List<int> list_array_passive_id = new List<int>(); // 0x40
        public string potrait { get; set; } // 0x48
        public string hero_name { get; set; } // 0x50
        public string desc { get; set; } // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            monster_group_id = reader.ReadInt32();
            //array_hero_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_hero_id.Add(reader.ReadInt32());
                v0--;
            }
            //array_passive_id = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_passive_id.Add(reader.ReadInt32());
                v1--;
            }
            potrait = reader.ReadString();
            hero_name = reader.ReadString();
            desc = reader.ReadString();
            return true;
        }
    }
    public class DBFinalBossSeasonRow
    {
        public int id { get; set; } // 0x10
        public string season_type { get; set; } // 0x18
        public string season_start { get; set; } // 0x20
        public string season_end { get; set; } // 0x28
        public string season_title { get; set; } // 0x30
        public string season_icon { get; set; } // 0x38
        public string season_shop_end { get; set; } // 0x40
        public string large_popup { get; set; } // 0x48
        public string event_banner { get; set; } // 0x50
        public string season_info { get; set; } // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            season_type = reader.ReadString();
            season_start = reader.ReadString();
            season_end = reader.ReadString();
            season_title = reader.ReadString();
            season_icon = reader.ReadString();
            season_shop_end = reader.ReadString();
            large_popup = reader.ReadString();
            event_banner = reader.ReadString();
            season_info = reader.ReadString();
            return true;
        }
    }
    public class DBFinalBossSettingRow
    {
        public int id { get; set; } // 0x10
        public int group_id { get; set; } // 0x14
        public int group_active { get; set; } // 0x18
        public string active_start { get; set; } // 0x20
        public string active_end { get; set; } // 0x28
        public int season_id { get; set; } // 0x30
        public int season_shop_boss_item_1 { get; set; } // 0x34
        public int season_shop_boss_item_2 { get; set; } // 0x38
        public int season_shop_boss_item_3 { get; set; } // 0x3C
        public List<int> list_season_shop_boss_item = new List<int>(); // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            group_active = reader.ReadInt32();
            active_start = reader.ReadString();
            active_end = reader.ReadString();
            season_id = reader.ReadInt32();
            season_shop_boss_item_1 = reader.ReadInt32();
            season_shop_boss_item_2 = reader.ReadInt32();
            season_shop_boss_item_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBFinalBossShopRow
    {
        public int id { get; set; } // 0x10
        public int product_season { get; set; } // 0x14
        public int product_page { get; set; } // 0x18
        public int reward_item_id { get; set; } // 0x1C
        public int reward_item_count { get; set; } // 0x20
        public int product_type { get; set; } // 0x24
        public string product_type_name { get; set; } // 0x28
        public int price_id { get; set; } // 0x30
        public int price_count { get; set; } // 0x34
        public int buy_limited_daily_count { get; set; } // 0x38
        public int buy_limited_season_count { get; set; } // 0x3C
        public int product_condition { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            product_season = reader.ReadInt32();
            product_page = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            product_type = reader.ReadInt32();
            product_type_name = reader.ReadString();
            price_id = reader.ReadInt32();
            price_count = reader.ReadInt32();
            buy_limited_daily_count = reader.ReadInt32();
            buy_limited_season_count = reader.ReadInt32();
            product_condition = reader.ReadInt32();
            return true;
        }
    }
    public class DBFirstBuyBonusRow
    {
        public int id { get; set; } // 0x10
        public string shop_type { get; set; } // 0x18
        public string first_buy_bonus_m_banner { get; set; } // 0x20
        public string first_buy_bonus_s_banner { get; set; } // 0x28
        public string first_buy_bonus_name { get; set; } // 0x30
        public string first_buy_bonus_desc { get; set; } // 0x38
        public int bonus_item_id_1 { get; set; } // 0x40
        public int bonus_item_count_1 { get; set; } // 0x44
        public int contents_type { get; set; } // 0x48
        public List<int> list_bonus_item_id = new List<int>(); // 0x50
        public List<int> list_bonus_item_count = new List<int>(); // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            shop_type = reader.ReadString();
            first_buy_bonus_m_banner = reader.ReadString();
            first_buy_bonus_s_banner = reader.ReadString();
            first_buy_bonus_name = reader.ReadString();
            first_buy_bonus_desc = reader.ReadString();
            bonus_item_id_1 = reader.ReadInt32();
            bonus_item_count_1 = reader.ReadInt32();
            contents_type = reader.ReadInt32();
            return true;
        }
    }
    public class DBFoodBuffRow
    {
        public int id { get; set; } // 0x10
        public string passive_type { get; set; } // 0x18
        public int passive_id { get; set; } // 0x20
        public int use_count { get; set; } // 0x24
        public int use_time_min { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            passive_type = reader.ReadString();
            passive_id = reader.ReadInt32();
            use_count = reader.ReadInt32();
            use_time_min = reader.ReadInt32();
            return true;
        }
    }
    public class DBFreePackageRewardRow
    {
        public int id { get; set; } // 0x10
        public int check_index { get; set; } // 0x14
        public string condition_type { get; set; } // 0x18
        public int condition_value { get; set; } // 0x20
        public int condition_rank { get; set; } // 0x24
        public int reward_item_id_1 { get; set; } // 0x28
        public int reward_item_count_1 { get; set; } // 0x2C
        public int reward_item_id_2 { get; set; } // 0x30
        public int reward_item_count_2 { get; set; } // 0x34
        public int reward_item_id_3 { get; set; } // 0x38
        public int reward_item_count_3 { get; set; } // 0x3C
        public int reward_item_id_4 { get; set; } // 0x40
        public int reward_item_count_4 { get; set; } // 0x44
        public int reward_item_id_5 { get; set; } // 0x48
        public int reward_item_count_5 { get; set; } // 0x4C
        public int reward_item_id_6 { get; set; } // 0x50
        public int reward_item_count_6 { get; set; } // 0x54
        public int reward_item_id_7 { get; set; } // 0x58
        public int reward_item_count_7 { get; set; } // 0x5C
        public int reward_item_id_8 { get; set; } // 0x60
        public int reward_item_count_8 { get; set; } // 0x64
        public int reward_item_id_9 { get; set; } // 0x68
        public int reward_item_count_9 { get; set; } // 0x6C
        public int reward_item_id_10 { get; set; } // 0x70
        public int reward_item_count_10 { get; set; } // 0x74
        public List<int> list_reward_item_id = new List<int>(); // 0x78
        public List<int> list_reward_item_count = new List<int>(); // 0x80
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            check_index = reader.ReadInt32();
            condition_type = reader.ReadString();
            condition_value = reader.ReadInt32();
            condition_rank = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            reward_item_id_2 = reader.ReadInt32();
            reward_item_count_2 = reader.ReadInt32();
            reward_item_id_3 = reader.ReadInt32();
            reward_item_count_3 = reader.ReadInt32();
            reward_item_id_4 = reader.ReadInt32();
            reward_item_count_4 = reader.ReadInt32();
            reward_item_id_5 = reader.ReadInt32();
            reward_item_count_5 = reader.ReadInt32();
            reward_item_id_6 = reader.ReadInt32();
            reward_item_count_6 = reader.ReadInt32();
            reward_item_id_7 = reader.ReadInt32();
            reward_item_count_7 = reader.ReadInt32();
            reward_item_id_8 = reader.ReadInt32();
            reward_item_count_8 = reader.ReadInt32();
            reward_item_id_9 = reader.ReadInt32();
            reward_item_count_9 = reader.ReadInt32();
            reward_item_id_10 = reader.ReadInt32();
            reward_item_count_10 = reader.ReadInt32();
            return true;
        }
    }
    public class DBFriendVisitHeroRow
    {
        public int id { get; set; } // 0x10
        public int sync_npc { get; set; } // 0x14
        public int guest_id { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            sync_npc = reader.ReadInt32();
            guest_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBFrozenContentRow
    {
        public int id { get; set; } // 0x10
        public string content_type { get; set; } // 0x18
        public int PIDL_Min_1 { get; set; } // 0x20
        public int PIDL_Max_1 { get; set; } // 0x24
        public int PIDL_Min_2 { get; set; } // 0x28
        public int PIDL_Max_2 { get; set; } // 0x2C
        public int PIDL_Min_3 { get; set; } // 0x30
        public int PIDL_Max_3 { get; set; } // 0x34
        public int PIDL_Min_4 { get; set; } // 0x38
        public int PIDL_Max_4 { get; set; } // 0x3C
        public int PIDL_Min_5 { get; set; } // 0x40
        public int PIDL_Max_5 { get; set; } // 0x44
        public string popup_desc { get; set; } // 0x48
        public List<int> list_PIDL_Min = new List<int>(); // 0x50
        public List<int> list_PIDL_Max = new List<int>(); // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            content_type = reader.ReadString();
            PIDL_Min_1 = reader.ReadInt32();
            PIDL_Max_1 = reader.ReadInt32();
            PIDL_Min_2 = reader.ReadInt32();
            PIDL_Max_2 = reader.ReadInt32();
            PIDL_Min_3 = reader.ReadInt32();
            PIDL_Max_3 = reader.ReadInt32();
            PIDL_Min_4 = reader.ReadInt32();
            PIDL_Max_4 = reader.ReadInt32();
            PIDL_Min_5 = reader.ReadInt32();
            PIDL_Max_5 = reader.ReadInt32();
            popup_desc = reader.ReadString();
            return true;
        }
    }
    public class DBGambleChoiceRow
    {
        public int id { get; set; } // 0x10
        public int choice_group { get; set; } // 0x14
        public int skin_id { get; set; } // 0x18
        public int choice_check { get; set; } // 0x1C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            choice_group = reader.ReadInt32();
            skin_id = reader.ReadInt32();
            choice_check = reader.ReadInt32();
            return true;
        }
    }
    public class DBGambleDisplayRow
    {
        public int id { get; set; }// 0x10
        public int gamble_type { get; set; }// 0x14
        public int gamble_pickup { get; set; }// 0x18
        public int probability_check { get; set; }// 0x1C
        public int gamble_control { get; set; }// 0x20
        public int gamble_group { get; set; }// 0x24
        public int gamble_background { get; set; }// 0x28
        public List<int> list_array_pickup_skin_id = new List<int>();// 0x30
        public int gamble_limit_count { get; set; }// 0x38
        public int fail_bonus_check { get; set; }// 0x3C
        public int hero_gacha_fail_count { get; set; }// 0x40
        public int gacha_bonus_count_reset { get; set; }// 0x44
        public int hero_gacha_fail_group { get; set; }// 0x48
        public int gacha_bonus_reward_group { get; set; }// 0x4C
        public int gamble_count_1 { get; set; }// 0x50
        public int gamble_money_id_1 { get; set; }// 0x54
        public int gamble_money_count_1 { get; set; }// 0x58
        public int gamble_count_2 { get; set; }// 0x5C
        public int gamble_money_id_2 { get; set; }// 0x60
        public int gamble_money_count_2 { get; set; }// 0x64
        public int gamble_count_3 { get; set; }// 0x68
        public int gamble_money_id_3 { get; set; }// 0x6C
        public int gamble_money_count_3 { get; set; }// 0x70
        public int gamble_count_4 { get; set; }// 0x74
        public int gamble_money_id_4 { get; set; }// 0x78
        public int gamble_money_count_4 { get; set; }// 0x7C
        public string gamble_BG_name { get; set; }// 0x80
        public string gamble_m_banner_name { get; set; }// 0x88
        public string gamble_desc { get; set; }// 0x90
        public string gamble_probability_url_dev { get; set; }// 0x98
        public string gamble_probability_url_real { get; set; }// 0xA0
        public List<int> list_gamble_count = new List<int>();// 0xA8
        public List<int> list_gamble_money_id = new List<int>();// 0xB0
        public List<int> list_gamble_money_count = new List<int>();// 0xB8
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            gamble_type = reader.ReadInt32();
            gamble_pickup = reader.ReadInt32();
            probability_check = reader.ReadInt32();
            gamble_control = reader.ReadInt32();
            gamble_group = reader.ReadInt32();
            gamble_background = reader.ReadInt32();
            //array_pickup_skin_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_pickup_skin_id.Add(reader.ReadInt32());
                v0--;
            }
            gamble_limit_count = reader.ReadInt32();
            fail_bonus_check = reader.ReadInt32();
            hero_gacha_fail_count = reader.ReadInt32();
            gacha_bonus_count_reset = reader.ReadInt32();
            hero_gacha_fail_group = reader.ReadInt32();
            gacha_bonus_reward_group = reader.ReadInt32();
            gamble_count_1 = reader.ReadInt32();
            gamble_money_id_1 = reader.ReadInt32();
            gamble_money_count_1 = reader.ReadInt32();
            gamble_count_2 = reader.ReadInt32();
            gamble_money_id_2 = reader.ReadInt32();
            gamble_money_count_2 = reader.ReadInt32();
            gamble_count_3 = reader.ReadInt32();
            gamble_money_id_3 = reader.ReadInt32();
            gamble_money_count_3 = reader.ReadInt32();
            gamble_count_4 = reader.ReadInt32();
            gamble_money_id_4 = reader.ReadInt32();
            gamble_money_count_4 = reader.ReadInt32();
            gamble_BG_name = reader.ReadString();
            gamble_m_banner_name = reader.ReadString();
            gamble_desc = reader.ReadString();
            gamble_probability_url_dev = reader.ReadString();
            gamble_probability_url_real = reader.ReadString();
            return true;
        }
    }
    public class DBGambleGroupRow
    {
        public int id { get; set; } // 0x10
        public int gamble_group { get; set; } // 0x14
        public int skin_id { get; set; } // 0x18
        public int gamble_rate { get; set; } // 0x1C
        public int pick_up_check { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            gamble_group = reader.ReadInt32();
            skin_id = reader.ReadInt32();
            gamble_rate = reader.ReadInt32();
            pick_up_check = reader.ReadInt32();
            return true;
        }
    }
    public class DBGambleHeadDefaultRow
    {
        public int id { get; set; } // 0x10
        public int skin_id { get; set; } // 0x14
        public string default_head_resource { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            skin_id = reader.ReadInt32();
            default_head_resource = reader.ReadString();
            return true;
        }
    }
    public class DBGambleRatingPerRow
    {
        public int id { get; set; } // 0x10
        public int gamble_group { get; set; } // 0x14
        public int rating_1 { get; set; } // 0x18
        public int rating_2 { get; set; } // 0x1C
        public int rating_3 { get; set; } // 0x20
        public int rating_4 { get; set; } // 0x24
        public int rating_5 { get; set; } // 0x28
        public List<int> list_rating = new List<int>(); // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            gamble_group = reader.ReadInt32();
            rating_1 = reader.ReadInt32();
            rating_2 = reader.ReadInt32();
            rating_3 = reader.ReadInt32();
            rating_4 = reader.ReadInt32();
            rating_5 = reader.ReadInt32();
            return true;
        }
    }
    public class DBGambleRotationSetRow
    {
        public int id { get; set; } // 0x10
        public int gamble_group { get; set; } // 0x14
        public int skin_id { get; set; } // 0x18
        public string hero_icon_file_name { get; set; } // 0x20
        public string hero_icon_name { get; set; } // 0x28
        public int rotation_group { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            gamble_group = reader.ReadInt32();
            skin_id = reader.ReadInt32();
            hero_icon_file_name = reader.ReadString();
            hero_icon_name = reader.ReadString();
            rotation_group = reader.ReadInt32();
            return true;
        }
    }
    public class DBGambleSignRow
    {
        public int id { get; set; } // 0x10
        public int gamble_result { get; set; } // 0x14
        public string sign { get; set; } // 0x18
        public float sign_rate_1 { get; set; } // 0x20
        public float sign_rate_2 { get; set; } // 0x24
        public float sign_rate_3 { get; set; } // 0x28
        public float sign_rate_4 { get; set; } // 0x2C
        public float sign_rate_5 { get; set; } // 0x30
        public float sign_rate_6 { get; set; } // 0x34
        public List<float> list_sign_rate = new List<float>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            gamble_result = reader.ReadInt32();
            sign = reader.ReadString();
            sign_rate_1 = reader.ReadSingle();
            sign_rate_2 = reader.ReadSingle();
            sign_rate_3 = reader.ReadSingle();
            sign_rate_4 = reader.ReadSingle();
            sign_rate_5 = reader.ReadSingle();
            sign_rate_6 = reader.ReadSingle();
            return true;
        }
    }
    public class DBGambleSoundRow
    {
        public int id { get; set; } // 0x10
        public int hero_id { get; set; } // 0x14
        public int get_sound_1 { get; set; } // 0x18
        public int get_sound_2 { get; set; } // 0x1C
        public int dp_sound_1 { get; set; } // 0x20
        public List<int> list_get_sound = new List<int>(); // 0x28
        public List<int> list_dp_sound = new List<int>(); // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            hero_id = reader.ReadInt32();
            get_sound_1 = reader.ReadInt32();
            get_sound_2 = reader.ReadInt32();
            dp_sound_1 = reader.ReadInt32();
            return true;
        }
    }
    public class DBGameCenterAchievementRow
    {
        public int id { get; set; } // 0x10
        public string mission_type { get; set; } // 0x18
        public int target_value { get; set; } // 0x20
        public string jp_platform_id { get; set; } // 0x28
        public string kr_platform_id { get; set; } // 0x30
        public string gb_platform_id { get; set; } // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            mission_type = reader.ReadString();
            target_value = reader.ReadInt32();
            jp_platform_id = reader.ReadString();
            kr_platform_id = reader.ReadString();
            gb_platform_id = reader.ReadString();
            return true;
        }
    }
    public class DBGameCenterLeaderboardRow
    {
        public int id { get; set; } // 0x10
        public string mission_type { get; set; } // 0x18
        public string jp_platform_id { get; set; } // 0x20
        public string kr_platform_id { get; set; } // 0x28
        public string gb_platform_id { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            mission_type = reader.ReadString();
            jp_platform_id = reader.ReadString();
            kr_platform_id = reader.ReadString();
            gb_platform_id = reader.ReadString();
            return true;
        }
    }
    public class DBGbLanguageRow
    {
        public int id { get; set; } // 0x10
        public int language_type { get; set; } // 0x14
        public string language_local { get; set; } // 0x18
        public string language_build_local { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            language_type = reader.ReadInt32();
            language_local = reader.ReadString();
            language_build_local = reader.ReadString();
            return true;
        }
    }
    public class DBGemBaseRow
    {
        public int id { get; set; } // 0x10
        public int rating { get; set; } // 0x14
        public int type { get; set; } // 0x18
        public int passive_id_1 { get; set; } // 0x1C
        public int passive_level_1 { get; set; } // 0x20
        public int passive_id_2 { get; set; } // 0x24
        public int passive_level_2 { get; set; } // 0x28
        public int passive_id_3 { get; set; } // 0x2C
        public int passive_level_3 { get; set; } // 0x30
        public List<int> list_passive_id = new List<int>(); // 0x38
        public List<int> list_passive_level = new List<int>(); // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            rating = reader.ReadInt32();
            type = reader.ReadInt32();
            passive_id_1 = reader.ReadInt32();
            passive_level_1 = reader.ReadInt32();
            passive_id_2 = reader.ReadInt32();
            passive_level_2 = reader.ReadInt32();
            passive_id_3 = reader.ReadInt32();
            passive_level_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuestGiftRow
    {
        public int id { get; set; } // 0x10
        public int guest_id { get; set; } // 0x14
        public int gift_index { get; set; } // 0x18
        public int item_id { get; set; } // 0x1C
        public int item_count { get; set; } // 0x20
        public int sales_bonus { get; set; } // 0x24
        public int contents_passive_id { get; set; } // 0x28
        public int gift_fellow_count { get; set; } // 0x2C
        public int reward_item_id { get; set; } // 0x30
        public int reward_item_count { get; set; } // 0x34
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            guest_id = reader.ReadInt32();
            gift_index = reader.ReadInt32();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            sales_bonus = reader.ReadInt32();
            contents_passive_id = reader.ReadInt32();
            gift_fellow_count = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuestInteractiveTalkRow
    {
        public int id { get; set; } // 0x10
        public int guest_id { get; set; } // 0x14
        public int gift_index { get; set; } // 0x18
        public int guest_type { get; set; } // 0x1C
        public string question_1 { get; set; } // 0x20
        public string answer_1 { get; set; } // 0x28
        public string answer_2 { get; set; } // 0x30
        public string answer_3 { get; set; } // 0x38
        public string answer_reaction_1 { get; set; } // 0x40
        public string answer_reaction_2 { get; set; } // 0x48
        public string answer_reaction_3 { get; set; } // 0x50
        public int answer_fellow_count_1 { get; set; } // 0x58
        public int answer_fellow_count_2 { get; set; } // 0x5C
        public int answer_fellow_count_3 { get; set; } // 0x60
        public List<string> list_question = new List<string>(); // 0x68
        public List<string> list_answer = new List<string>(); // 0x70
        public List<string> list_answer_reaction = new List<string>(); // 0x78
        public List<int> list_answer_fellow_count = new List<int>(); // 0x80
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            guest_id = reader.ReadInt32();
            gift_index = reader.ReadInt32();
            guest_type = reader.ReadInt32();
            question_1 = reader.ReadString();
            answer_1 = reader.ReadString();
            answer_2 = reader.ReadString();
            answer_3 = reader.ReadString();
            answer_reaction_1 = reader.ReadString();
            answer_reaction_2 = reader.ReadString();
            answer_reaction_3 = reader.ReadString();
            answer_fellow_count_1 = reader.ReadInt32();
            answer_fellow_count_2 = reader.ReadInt32();
            answer_fellow_count_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildAttendanceRow
    {
        public int id { get; set; } // 0x10
        public string title_local { get; set; } // 0x18
        public int attendance_count { get; set; } // 0x20
        public int reward_item_id_1 { get; set; } // 0x24
        public int reward_item_count_1 { get; set; } // 0x28
        public int reward_item_id_2 { get; set; } // 0x2C
        public int reward_item_count_2 { get; set; } // 0x30
        public List<int> list_reward_item_id = new List<int>(); // 0x38
        public List<int> list_reward_item_count = new List<int>(); // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            title_local = reader.ReadString();
            attendance_count = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            reward_item_id_2 = reader.ReadInt32();
            reward_item_count_2 = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildBaseRow
    {
        public int guild_level { get; set; } // 0x10
        public int guild_member { get; set; } // 0x14
        public int skill_slot_count { get; set; } // 0x18
        public int need_point_count { get; set; } // 0x1C
        public int save_point_count { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            guild_level = reader.ReadInt32();
            guild_member = reader.ReadInt32();
            skill_slot_count = reader.ReadInt32();
            need_point_count = reader.ReadInt32();
            save_point_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildBossBattlescoreInfoRow
    {
        public int id { get; set; }// 0x10
        public int season_id { get; set; }// 0x14
        public int group_id { get; set; }// 0x18
        public int stage_id { get; set; }// 0x1C
        public string checklist_name { get; set; }// 0x20
        public string BattleScore_type { get; set; }// 0x28
        public int client_visible { get; set; }// 0x30
        public float checklist_value { get; set; }// 0x34
        public List<int> list_array_type_id = new List<int>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            season_id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            stage_id = reader.ReadInt32();
            checklist_name = reader.ReadString();
            BattleScore_type = reader.ReadString();
            client_visible = reader.ReadInt32();
            checklist_value = reader.ReadSingle();
            //array_type_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_type_id.Add(reader.ReadInt32());
                v0--;
            }
            return true;
        }
    }
    public class DBGuildBossGuildRewardRow
    {
        public int id { get; set; }// 0x10
        public int season_id { get; set; }// 0x14
        public int season_group { get; set; }// 0x18
        public int group_id { get; set; }// 0x1C
        public string reward_title { get; set; }// 0x20
        public int target_value { get; set; }// 0x28
        public int reward_item_id { get; set; }// 0x2C
        public int reward_item_count { get; set; }// 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            season_id = reader.ReadInt32();
            season_group = reader.ReadInt32();
            group_id = reader.ReadInt32();
            reward_title = reader.ReadString();
            target_value = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildBossMissionRow
    {
        public int id { get; set; }// 0x10
        public int season_id { get; set; }// 0x14
        public int season_group { get; set; }// 0x18
        public int group_id { get; set; }// 0x1C
        public int stage_id { get; set; }// 0x20
        public string mission_type { get; set; }// 0x28
        public int mission_type_value { get; set; }// 0x30
        public int mission_target_value { get; set; }// 0x34
        public int guild_contribution_reward { get; set; }// 0x38
        public int localize_display_type { get; set; }// 0x3C
        public string mission_name { get; set; }// 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            season_id = reader.ReadInt32();
            season_group = reader.ReadInt32();
            group_id = reader.ReadInt32();
            stage_id = reader.ReadInt32();
            mission_type = reader.ReadString();
            mission_type_value = reader.ReadInt32();
            mission_target_value = reader.ReadInt32();
            guild_contribution_reward = reader.ReadInt32();
            localize_display_type = reader.ReadInt32();
            mission_name = reader.ReadString();
            return true;
        }
    }
    public class DBGuildBossPersonalRewardRow
    {
        public int id { get; set; } // 0x10
        public int group_id { get; set; } // 0x14
        public int season_group { get; set; } // 0x18
        public int reward_order { get; set; } // 0x1C
        public int target_value { get; set; } // 0x20
        public int reward_item_id { get; set; } // 0x24
        public int reward_item_count { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            season_group = reader.ReadInt32();
            reward_order = reader.ReadInt32();
            target_value = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildBossSeasonRow
    {
        public int id { get; set; }// 0x10
        public int season_id { get; set; }// 0x14
        public int season_group { get; set; }// 0x18
        public string season_start { get; set; }// 0x20
        public string event_large_popup_name { get; set; }// 0x28
        public string event_large_popup_end { get; set; }// 0x30
        public string season_title { get; set; }// 0x38
        public string season_subtitle { get; set; }// 0x40
        public string mission_title { get; set; }// 0x48
        public int help_window { get; set; }// 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            season_id = reader.ReadInt32();
            season_group = reader.ReadInt32();
            season_start = reader.ReadString();
            event_large_popup_name = reader.ReadString();
            event_large_popup_end = reader.ReadString();
            season_title = reader.ReadString();
            season_subtitle = reader.ReadString();
            mission_title = reader.ReadString();
            help_window = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildBuffBaseRow
    {
        public int id { get; set; } // 0x10
        public int open_guild_level { get; set; } // 0x14
        public int buff_max_level { get; set; } // 0x18
        public int effect_id { get; set; } // 0x1C
        public float effect_value { get; set; } // 0x20
        public float effect_add_value { get; set; } // 0x24
        public string game_mode { get; set; } // 0x28
        public int buff_purchase_id { get; set; } // 0x30
        public int buff_purchase_count { get; set; } // 0x34
        public int buff_levelup_id { get; set; } // 0x38
        public int buff_levelup_count { get; set; } // 0x3C
        public int buff_change_id { get; set; } // 0x40
        public int buff_change_count { get; set; } // 0x44
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            open_guild_level = reader.ReadInt32();
            buff_max_level = reader.ReadInt32();
            effect_id = reader.ReadInt32();
            effect_value = reader.ReadSingle();
            effect_add_value = reader.ReadSingle();
            game_mode = reader.ReadString();
            buff_purchase_id = reader.ReadInt32();
            buff_purchase_count = reader.ReadInt32();
            buff_levelup_id = reader.ReadInt32();
            buff_levelup_count = reader.ReadInt32();
            buff_change_id = reader.ReadInt32();
            buff_change_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildBuffResourceRow
    {
        public int id { get; set; } // 0x10
        public string buff_icon_name { get; set; } // 0x18
        public string buff_name { get; set; } // 0x20
        public string buff_description { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            buff_icon_name = reader.ReadString();
            buff_name = reader.ReadString();
            buff_description = reader.ReadString();
            return true;
        }
    }
    public class DBGuildDonationRow
    {
        public int index { get; set; } // 0x10
        public string tab { get; set; } // 0x18
        public string array_item_id { get; set; } // 0x20
        public List<int> list_array_item_id = new List<int>(); // 0x28
        public int donation_once_count { get; set; } // 0x30
        public int donation_once_guild_exp { get; set; } // 0x34
        public int donation_once_guild_gold { get; set; } // 0x38
        public int donation_once_contribution { get; set; } // 0x3C
        public int donation_once_guild_skill_point { get; set; } // 0x40
        public int donation_count_daily_limit { get; set; } // 0x44
        public int donation_count_reset_dia { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            index = reader.ReadInt32();
            tab = reader.ReadString();
            //array_item_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_item_id.Add(reader.ReadInt32());
                v0--;
            }
            donation_once_count = reader.ReadInt32();
            donation_once_guild_exp = reader.ReadInt32();
            donation_once_guild_gold = reader.ReadInt32();
            donation_once_contribution = reader.ReadInt32();
            donation_once_guild_skill_point = reader.ReadInt32();
            donation_count_daily_limit = reader.ReadInt32();
            donation_count_reset_dia = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildMissionRow
    {
        public int id { get; set; } // 0x10
        public int open_guild_level { get; set; } // 0x14
        public string mission_type { get; set; } // 0x18
        public int mission_type_value { get; set; } // 0x20
        public int mission_target_value { get; set; } // 0x24
        public int alarm_type { get; set; } // 0x28
        public int reward_item_id_1 { get; set; } // 0x2C
        public int reward_item_count_1 { get; set; } // 0x30
        public int reward_item_id_2 { get; set; } // 0x34
        public int reward_item_count_2 { get; set; } // 0x38
        public int reward_guild_exp { get; set; } // 0x3C
        public int localize_display_type { get; set; } // 0x40
        public string mission_name { get; set; } // 0x48
        public int mission_quick_link { get; set; } // 0x50
        public List<int> list_reward_item_id = new List<int>(); // 0x58
        public List<int> list_reward_item_count = new List<int>(); // 0x60
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            open_guild_level = reader.ReadInt32();
            mission_type = reader.ReadString();
            mission_type_value = reader.ReadInt32();
            mission_target_value = reader.ReadInt32();
            alarm_type = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            reward_item_id_2 = reader.ReadInt32();
            reward_item_count_2 = reader.ReadInt32();
            reward_guild_exp = reader.ReadInt32();
            localize_display_type = reader.ReadInt32();
            mission_name = reader.ReadString();
            mission_quick_link = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildMissionUseRow
    {
        public int index { get; set; } // 0x10
        public int open_guild_level { get; set; } // 0x14
        public int guild_mission_id { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            index = reader.ReadInt32();
            open_guild_level = reader.ReadInt32();
            guild_mission_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildRankRewardRow
    {
        public int id { get; set; } // 0x10
        public string rank_type { get; set; } // 0x18
        public int rank_value_min { get; set; } // 0x20
        public int rank_value_max { get; set; } // 0x24
        public int rank_percentage_min { get; set; } // 0x28
        public int rank_percentage_max { get; set; } // 0x2C
        public int reward_id_1 { get; set; } // 0x30
        public int reward_count_1 { get; set; } // 0x34
        public int reward_id_2 { get; set; } // 0x38
        public int reward_count_2 { get; set; } // 0x3C
        public List<int> list_reward_id = new List<int>(); // 0x40
        public List<int> list_reward_count = new List<int>(); // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            rank_type = reader.ReadString();
            rank_value_min = reader.ReadInt32();
            rank_value_max = reader.ReadInt32();
            rank_percentage_min = reader.ReadInt32();
            rank_percentage_max = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            reward_id_2 = reader.ReadInt32();
            reward_count_2 = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildShopRow
    {
        public int id { get; set; } // 0x10
        public int basepoint_id { get; set; } // 0x14
        public int npc_id { get; set; } // 0x18
        public int usable_guild_level { get; set; } // 0x1C
        public int shop_item_id { get; set; } // 0x20
        public int shop_price_id { get; set; } // 0x24
        public int product_count { get; set; } // 0x28
        public int buy_limit_count { get; set; } // 0x2C
        public int price_id { get; set; } // 0x30
        public int price_count { get; set; } // 0x34
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            basepoint_id = reader.ReadInt32();
            npc_id = reader.ReadInt32();
            usable_guild_level = reader.ReadInt32();
            shop_item_id = reader.ReadInt32();
            shop_price_id = reader.ReadInt32();
            product_count = reader.ReadInt32();
            buy_limit_count = reader.ReadInt32();
            price_id = reader.ReadInt32();
            price_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildSkillRow
    {
        public int id { get; set; } // 0x10
        public string passive_type { get; set; } // 0x18
        public int guild_skill_passive { get; set; } // 0x20
        public int guild_skill_open_lv { get; set; } // 0x24
        public int guild_skill_lv { get; set; } // 0x28
        public int guild_skill_group { get; set; } // 0x2C
        public int guild_skill_lv_price_count { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            passive_type = reader.ReadString();
            guild_skill_passive = reader.ReadInt32();
            guild_skill_open_lv = reader.ReadInt32();
            guild_skill_lv = reader.ReadInt32();
            guild_skill_group = reader.ReadInt32();
            guild_skill_lv_price_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildWarAreaRow
    {
        public int guild_war_area_id { get; set; }// 0x10
        public int guild_war_region_id { get; set; }// 0x14
        public string guild_war_area_name { get; set; }// 0x18
        public string guild_war_area_icon { get; set; }// 0x20
        public string guild_war_area_destroy_icon { get; set; }// 0x28
        public string guild_war_area_bg_path { get; set; }// 0x30
        public string guild_war_area_bg { get; set; }// 0x38
        public int guild_war_area_score { get; set; }// 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            guild_war_area_id = reader.ReadInt32();
            guild_war_region_id = reader.ReadInt32();
            guild_war_area_name = reader.ReadString();
            guild_war_area_icon = reader.ReadString();
            guild_war_area_destroy_icon = reader.ReadString();
            guild_war_area_bg_path = reader.ReadString();
            guild_war_area_bg = reader.ReadString();
            guild_war_area_score = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildWarRankRewardRow
    {
        public int id { get; set; } // 0x10
        public int league_type { get; set; } // 0x14
        public string rank_type { get; set; } // 0x18
        public int rank_value_min { get; set; } // 0x20
        public int rank_value_max { get; set; } // 0x24
        public int rank_percentage_min { get; set; } // 0x28
        public int rank_percentage_max { get; set; } // 0x2C
        public int reward_id_1 { get; set; } // 0x30
        public int reward_count_1 { get; set; } // 0x34
        public int reward_id_2 { get; set; } // 0x38
        public int reward_count_2 { get; set; } // 0x3C
        public List<int> list_reward_id = new List<int>(); // 0x40
        public List<int> list_reward_count = new List<int>(); // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            league_type = reader.ReadInt32();
            rank_type = reader.ReadString();
            rank_value_min = reader.ReadInt32();
            rank_value_max = reader.ReadInt32();
            rank_percentage_min = reader.ReadInt32();
            rank_percentage_max = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            reward_id_2 = reader.ReadInt32();
            reward_count_2 = reader.ReadInt32();
            return true;
        }
    }
    public class DBGuildWarRegionRow
    {
        public int guild_war_region_id { get; set; } // 0x10
        public string guild_war_region_name { get; set; } // 0x18
        public string guild_war_region_icon { get; set; } // 0x20
        public int guild_war_region_score { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            guild_war_region_id = reader.ReadInt32();
            guild_war_region_name = reader.ReadString();
            guild_war_region_icon = reader.ReadString();
            guild_war_region_score = reader.ReadInt32();
            return true;
        }
    }
    public class DBHawkSlotRow
    {
        public int id { get; set; } // 0x10
        public int stage_id { get; set; } // 0x14
        public int slot { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            stage_id = reader.ReadInt32();
            slot = reader.ReadInt32();
            return true;
        }
    }
    public class DBHeadCostumeResourceRow
    {
        public int id { get; set; } // 0x10
        public int head_attach_dummy { get; set; } // 0x14
        public string character_base { get; set; } // 0x18
        public string resource_head { get; set; } // 0x20
        public string head_mixer_name { get; set; } // 0x28
        public string error_check_head_resource { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            head_attach_dummy = reader.ReadInt32();
            character_base = reader.ReadString();
            resource_head = reader.ReadString();
            head_mixer_name = reader.ReadString();
            error_check_head_resource = reader.ReadString();
            return true;
        }
    }
    public class DBHeroCapacityMentRow
    {
        public int id { get; set; } // 0x10
        public string hero_capacity_ment_1 { get; set; } // 0x18
        public string hero_capacity_ment_2 { get; set; } // 0x20
        public string hero_capacity_ment_3 { get; set; } // 0x28
        public string hero_capacity_ment_4 { get; set; } // 0x30
        public string hero_capacity_ment_5 { get; set; } // 0x38
        public string hero_capacity_ment_6 { get; set; } // 0x40
        public string hero_capacity_ment_7 { get; set; } // 0x48
        public List<string> list_hero_capacity_ment = new List<string>(); // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            hero_capacity_ment_1 = reader.ReadString();
            hero_capacity_ment_2 = reader.ReadString();
            hero_capacity_ment_3 = reader.ReadString();
            hero_capacity_ment_4 = reader.ReadString();
            hero_capacity_ment_5 = reader.ReadString();
            hero_capacity_ment_6 = reader.ReadString();
            hero_capacity_ment_7 = reader.ReadString();
            return true;
        }
    }
    public class DBHeroContentsPassiveRow
    {
        public int id { get; set; } // 0x10
        public int passive_id { get; set; } // 0x14
        public string array_stage_type { get; set; } // 0x18
        public List<string> list_array_stage_type = new List<string>(); // 0x20
        public string effect_keyword { get; set; } // 0x28
        public int group_id { get; set; } // 0x30
        public int event_type { get; set; } // 0x34
        public int event_sub_index { get; set; } // 0x38
        public int apply_per { get; set; } // 0x3C
        public int param_1 { get; set; } // 0x40
        public int param_2 { get; set; } // 0x44
        public int param_3 { get; set; } // 0x48
        public int param_4 { get; set; } // 0x4C
        public List<int> list_param = new List<int>(); // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            passive_id = reader.ReadInt32();
            //array_stage_type = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_stage_type.Add(reader.ReadString());
                v0--;
            }
            effect_keyword = reader.ReadString();
            group_id = reader.ReadInt32();
            event_type = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            apply_per = reader.ReadInt32();
            param_1 = reader.ReadInt32();
            param_2 = reader.ReadInt32();
            param_3 = reader.ReadInt32();
            param_4 = reader.ReadInt32();
            return true;
        }
    }
    public class DBHeroDetailRow
    {
        public int id { get; set; } // 0x10
        public int type { get; set; } // 0x14
        public string ani_clip { get; set; } // 0x18
        public string ani_clip_name { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadInt32();
            ani_clip = reader.ReadString();
            ani_clip_name = reader.ReadString();
            return true;
        }
    }
    public class DBHeroGroupNameRow
    {
        public int id { get; set; } // 0x10
        public string category_name { get; set; } // 0x18
        public string weapon_carve_hero_portrait_folder { get; set; } // 0x20
        public string weapon_carve_hero_portrait { get; set; } // 0x28
        public string weapon_carve_hero_icon_folder { get; set; } // 0x30
        public string weapon_carve_hero_icon { get; set; } // 0x38
        public int weapon_carve_hero_open { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            category_name = reader.ReadString();
            weapon_carve_hero_portrait_folder = reader.ReadString();
            weapon_carve_hero_portrait = reader.ReadString();
            weapon_carve_hero_icon_folder = reader.ReadString();
            weapon_carve_hero_icon = reader.ReadString();
            weapon_carve_hero_open = reader.ReadInt32();
            return true;
        }
    }
    public class DBHeroLovepointRewardRow
    {
        public int id { get; set; } // 0x10
        public int reward_condition_count { get; set; } // 0x14
        public int reward_item_id { get; set; } // 0x18
        public int reward_item_count { get; set; } // 0x1C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            reward_condition_count = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBHeroLovepointShareRow
    {
        public int id { get; set; } // 0x10
        public int hero_group { get; set; } // 0x14
        public int share_condition_count { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            hero_group = reader.ReadInt32();
            share_condition_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBInteractiveRow
    {
        public int id { get; set; } // 0x10
        public int guest_id { get; set; } // 0x14
        public int npc_type { get; set; } // 0x18
        public string type { get; set; } // 0x20
        public int level { get; set; } // 0x28
        public string question { get; set; } // 0x30
        public string player_good_answer { get; set; } // 0x38
        public int good_answer_value { get; set; } // 0x40
        public string good_feedback { get; set; } // 0x48
        public string player_normal_answer { get; set; } // 0x50
        public int normal_answer_value { get; set; } // 0x58
        public string normal_feedback { get; set; } // 0x60
        public string player_bad_answer { get; set; } // 0x68
        public int bad_answer_value { get; set; } // 0x70
        public string bad_feedback { get; set; } // 0x78
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            guest_id = reader.ReadInt32();
            npc_type = reader.ReadInt32();
            type = reader.ReadString();
            level = reader.ReadInt32();
            question = reader.ReadString();
            player_good_answer = reader.ReadString();
            good_answer_value = reader.ReadInt32();
            good_feedback = reader.ReadString();
            player_normal_answer = reader.ReadString();
            normal_answer_value = reader.ReadInt32();
            normal_feedback = reader.ReadString();
            player_bad_answer = reader.ReadString();
            bad_answer_value = reader.ReadInt32();
            bad_feedback = reader.ReadString();
            return true;
        }
    }
    public class DBInteractiveItemRow
    {
        public int id { get; set; } // 0x10
        public string name { get; set; } // 0x18
        public int guest_id { get; set; } // 0x20
        public int npc_type { get; set; } // 0x24
        public int index { get; set; } // 0x28
        public int condition { get; set; } // 0x2C
        public int costume_tab_type { get; set; } // 0x30
        public string icon_id { get; set; } // 0x38
        public string resource { get; set; } // 0x40
        public string head_resource { get; set; } // 0x48
        public string body_resource { get; set; } // 0x50
        public float scale { get; set; } // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            name = reader.ReadString();
            guest_id = reader.ReadInt32();
            npc_type = reader.ReadInt32();
            index = reader.ReadInt32();
            condition = reader.ReadInt32();
            costume_tab_type = reader.ReadInt32();
            icon_id = reader.ReadString();
            resource = reader.ReadString();
            head_resource = reader.ReadString();
            body_resource = reader.ReadString();
            scale = reader.ReadSingle();
            return true;
        }
    }
    public class DBInteractiveLinkRow
    {
        public int id { get; set; } // 0x10
        public int question_id_1 { get; set; } // 0x14
        public int question_id_2 { get; set; } // 0x18
        public int question_id_3 { get; set; } // 0x1C
        public int gift_item { get; set; } // 0x20
        public int gift_item_value_1 { get; set; } // 0x24
        public int gift_item_value_2 { get; set; } // 0x28
        public int gift_item_value_3 { get; set; } // 0x2C
        public List<int> list_question_id = new List<int>(); // 0x30
        public List<int> list_gift_item_value = new List<int>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            question_id_1 = reader.ReadInt32();
            question_id_2 = reader.ReadInt32();
            question_id_3 = reader.ReadInt32();
            gift_item = reader.ReadInt32();
            gift_item_value_1 = reader.ReadInt32();
            gift_item_value_2 = reader.ReadInt32();
            gift_item_value_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBInteractiveTalkRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string animation { get; set; } // 0x20
        public string answer_string { get; set; } // 0x28
        public int voice_sound_id { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            animation = reader.ReadString();
            answer_string = reader.ReadString();
            voice_sound_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBInteractiveVrRow
    {
        public int id { get; set; } // 0x10
        public string object_name { get; set; } // 0x18
        public int floor { get; set; } // 0x20
        public int need_item { get; set; } // 0x24
        public int need_item_count { get; set; } // 0x28
        public int reward_per { get; set; } // 0x2C
        public int reward_group_id { get; set; } // 0x30
        public string effect { get; set; } // 0x38
        public int sound_effect { get; set; } // 0x40
        public string text_effect { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            object_name = reader.ReadString();
            floor = reader.ReadInt32();
            need_item = reader.ReadInt32();
            need_item_count = reader.ReadInt32();
            reward_per = reader.ReadInt32();
            reward_group_id = reader.ReadInt32();
            effect = reader.ReadString();
            sound_effect = reader.ReadInt32();
            text_effect = reader.ReadString();
            return true;
        }
    }
    public class DBItemGotchaDisplayRow
    {
        public int id { get; set; } // 0x10
        public int ui_group { get; set; } // 0x14
        public int gotcha_type { get; set; } // 0x18
        public int gotcha_control { get; set; } // 0x1C
        public int gotcha_group { get; set; } // 0x20
        public int gotcha_free_count { get; set; } // 0x24
        public int gotcha_limit_count { get; set; } // 0x28
        public int gotcha_count_1 { get; set; } // 0x2C
        public int gotcha_money_id_1 { get; set; } // 0x30
        public int gotcha_money_count_1 { get; set; } // 0x34
        public int money_raisingvalue_1 { get; set; } // 0x38
        public int money_raise_max_1 { get; set; } // 0x3C
        public int gotcha_count_2 { get; set; } // 0x40
        public int gotcha_money_id_2 { get; set; } // 0x44
        public int gotcha_money_count_2 { get; set; } // 0x48
        public int money_raisingvalue_2 { get; set; } // 0x4C
        public int money_raise_max_2 { get; set; } // 0x50
        public int gotcha_count_3 { get; set; } // 0x54
        public int gotcha_money_id_3 { get; set; } // 0x58
        public int gotcha_money_count_3 { get; set; } // 0x5C
        public int money_raisingvalue_3 { get; set; } // 0x60
        public int money_raise_max_3 { get; set; } // 0x64
        public string gotcha_BG_name { get; set; } // 0x68
        public string gotcha_desc { get; set; } // 0x70
        public string gotcha_resource { get; set; } // 0x78
        public List<int> list_gotcha_count = new List<int>(); // 0x80
        public List<int> list_gotcha_money_id = new List<int>(); // 0x88
        public List<int> list_gotcha_money_count = new List<int>(); // 0x90
        public List<int> list_money_raisingvalue = new List<int>(); // 0x98
        public List<int> list_money_raise_max = new List<int>(); // 0xA0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            ui_group = reader.ReadInt32();
            gotcha_type = reader.ReadInt32();
            gotcha_control = reader.ReadInt32();
            gotcha_group = reader.ReadInt32();
            gotcha_free_count = reader.ReadInt32();
            gotcha_limit_count = reader.ReadInt32();
            gotcha_count_1 = reader.ReadInt32();
            gotcha_money_id_1 = reader.ReadInt32();
            gotcha_money_count_1 = reader.ReadInt32();
            money_raisingvalue_1 = reader.ReadInt32();
            money_raise_max_1 = reader.ReadInt32();
            gotcha_count_2 = reader.ReadInt32();
            gotcha_money_id_2 = reader.ReadInt32();
            gotcha_money_count_2 = reader.ReadInt32();
            money_raisingvalue_2 = reader.ReadInt32();
            money_raise_max_2 = reader.ReadInt32();
            gotcha_count_3 = reader.ReadInt32();
            gotcha_money_id_3 = reader.ReadInt32();
            gotcha_money_count_3 = reader.ReadInt32();
            money_raisingvalue_3 = reader.ReadInt32();
            money_raise_max_3 = reader.ReadInt32();
            gotcha_BG_name = reader.ReadString();
            gotcha_desc = reader.ReadString();
            gotcha_resource = reader.ReadString();
            return true;
        }
    }
    public class DBItemGotchaGroupRow
    {
        public int id { get; set; } // 0x10
        public int gotcha_group { get; set; } // 0x14
        public int item_id { get; set; } // 0x18
        public int item_count { get; set; } // 0x1C
        public int item_rate { get; set; } // 0x20
        public int rate { get; set; } // 0x24
        public int pick_up_check { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            gotcha_group = reader.ReadInt32();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            item_rate = reader.ReadInt32();
            rate = reader.ReadInt32();
            pick_up_check = reader.ReadInt32();
            return true;
        }
    }
    public class DBItemGotchaRatingPerRow
    {
        public int id { get; set; } // 0x10
        public int gotcha_group { get; set; } // 0x14
        public int rating_1 { get; set; } // 0x18
        public int rating_2 { get; set; } // 0x1C
        public int rating_3 { get; set; } // 0x20
        public int rating_4 { get; set; } // 0x24
        public int rating_5 { get; set; } // 0x28
        public int rating_6 { get; set; } // 0x2C
        public List<int> list_rating = new List<int>(); // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            gotcha_group = reader.ReadInt32();
            rating_1 = reader.ReadInt32();
            rating_2 = reader.ReadInt32();
            rating_3 = reader.ReadInt32();
            rating_4 = reader.ReadInt32();
            rating_5 = reader.ReadInt32();
            rating_6 = reader.ReadInt32();
            return true;
        }
    }
    public class DBItemGotchaSignRow
    {
        public int id { get; set; } // 0x10
        public string sign { get; set; } // 0x18
        public float sign_rate_1 { get; set; } // 0x20
        public float sign_rate_2 { get; set; } // 0x24
        public List<float> list_sign_rate = new List<float>(); // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            sign = reader.ReadString();
            sign_rate_1 = reader.ReadSingle();
            sign_rate_2 = reader.ReadSingle();
            return true;
        }
    }
    public class DBItemInfoRow
    {
        public int item_id { get; set; }// 0x10
        public string item_icon { get; set; }// 0x18
        public string item_nickname { get; set; }// 0x20
        public string item_name { get; set; }// 0x28
        public string item_description { get; set; }// 0x30
        public string item_type { get; set; }// 0x38
        public string item_type_description { get; set; }// 0x40
        public int item_display_group { get; set; }// 0x48
        public byte item_rating { get; set; }// 0x4C
        public int item_param_1 { get; set; }// 0x50
        public int item_param_2 { get; set; }// 0x54
        public int item_param_3 { get; set; }// 0x58
        public int item_param_4 { get; set; }// 0x5C
        public List<int> list_array_item_param = new List<int>();// 0x60
        public byte storage_on { get; set; }// 0x68
        public byte storage_group { get; set; }// 0x69
        public byte sell_on { get; set; }// 0x6A
        public int sell_id { get; set; }// 0x6C
        public int sell_cost { get; set; }// 0x70
        public List<int> list_item_param = new List<int>(); // 0x78
        public bool ReadToStream(BinaryReader reader)
        {
            item_id = reader.ReadInt32();
            item_icon = reader.ReadString();
            item_nickname = reader.ReadString();
            item_name = reader.ReadString();
            item_description = reader.ReadString();
            item_type = reader.ReadString();
            item_type_description = reader.ReadString();
            item_display_group = reader.ReadInt32();
            item_rating = reader.ReadByte();
            item_param_1 = reader.ReadInt32();
            item_param_2 = reader.ReadInt32();
            item_param_3 = reader.ReadInt32();
            item_param_4 = reader.ReadInt32();
            //array_item_param = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_item_param.Add(reader.ReadInt32());
                v0--;
            }
            storage_on = reader.ReadByte();
            storage_group = reader.ReadByte();
            sell_on = reader.ReadByte();
            sell_id = reader.ReadInt32();
            sell_cost = reader.ReadInt32();
            return true;
        }
    }
    public class DBJournalRow
    {
        public int id { get; set; } // 0x10
        public string journal_name { get; set; } // 0x18
        public string journal_resource { get; set; } // 0x20
        public int journal_tap_index { get; set; } // 0x28
        public string journal_type { get; set; } // 0x30
        public int journal_root_group { get; set; } // 0x38
        public int journal_value { get; set; } // 0x3C
        public int display_link_id { get; set; } // 0x40
        public string blind_open_type { get; set; } // 0x48
        public int blind_open_value { get; set; } // 0x50
        public string close_type { get; set; } // 0x58
        public int close_value { get; set; } // 0x60
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            journal_name = reader.ReadString();
            journal_resource = reader.ReadString();
            journal_tap_index = reader.ReadInt32();
            journal_type = reader.ReadString();
            journal_root_group = reader.ReadInt32();
            journal_value = reader.ReadInt32();
            display_link_id = reader.ReadInt32();
            blind_open_type = reader.ReadString();
            blind_open_value = reader.ReadInt32();
            close_type = reader.ReadString();
            close_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBJukeboxListRow
    {
        public int id { get; set; } // 0x10
        public string bgm_name { get; set; } // 0x18
        public string bgm_icon { get; set; } // 0x20
        public string bgm_desc { get; set; } // 0x28
        public string bgm_desc_sub { get; set; } // 0x30
        public string bgm_collect_require { get; set; } // 0x38
        public int bgm_resource_id { get; set; } // 0x40
        public int bgm_type { get; set; } // 0x44
        public int matching_hero_id { get; set; } // 0x48
        public int collection_type { get; set; } // 0x4C
        public int collection_value { get; set; } // 0x50
        public string bgm_7ml_code { get; set; } // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            bgm_name = reader.ReadString();
            bgm_icon = reader.ReadString();
            bgm_desc = reader.ReadString();
            bgm_desc_sub = reader.ReadString();
            bgm_collect_require = reader.ReadString();
            bgm_resource_id = reader.ReadInt32();
            bgm_type = reader.ReadInt32();
            matching_hero_id = reader.ReadInt32();
            collection_type = reader.ReadInt32();
            collection_value = reader.ReadInt32();
            bgm_7ml_code = reader.ReadString();
            return true;
        }
    }
    public class DBKingAmberRow
    {
        public int id { get; set; } // 0x10
        public int grade { get; set; } // 0x14
        public string type { get; set; } // 0x18
        public string type_name { get; set; } // 0x20
        public string sub_type { get; set; } // 0x28
        public string sub_type_name { get; set; } // 0x30
        public string title_icon { get; set; } // 0x38
        public int material_id { get; set; } // 0x40
        public int material_count { get; set; } // 0x44
        public int reward_id_1 { get; set; } // 0x48
        public int reward_count_1 { get; set; } // 0x4C
        public int reward_id_2 { get; set; } // 0x50
        public int reward_count_2 { get; set; } // 0x54
        public int reward_id_3 { get; set; } // 0x58
        public int reward_count_3 { get; set; } // 0x5C
        public int reward_id_4 { get; set; } // 0x60
        public int reward_count_4 { get; set; } // 0x64
        public int reward_id_5 { get; set; } // 0x68
        public int reward_count_5 { get; set; } // 0x6C
        public int reward_id_6 { get; set; } // 0x70
        public int reward_count_6 { get; set; } // 0x74
        public List<int> list_reward_id = new List<int>(); // 0x78
        public List<int> list_reward_count = new List<int>(); // 0x80
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            grade = reader.ReadInt32();
            type = reader.ReadString();
            type_name = reader.ReadString();
            sub_type = reader.ReadString();
            sub_type_name = reader.ReadString();
            title_icon = reader.ReadString();
            material_id = reader.ReadInt32();
            material_count = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            reward_id_2 = reader.ReadInt32();
            reward_count_2 = reader.ReadInt32();
            reward_id_3 = reader.ReadInt32();
            reward_count_3 = reader.ReadInt32();
            reward_id_4 = reader.ReadInt32();
            reward_count_4 = reader.ReadInt32();
            reward_id_5 = reader.ReadInt32();
            reward_count_5 = reader.ReadInt32();
            reward_id_6 = reader.ReadInt32();
            reward_count_6 = reader.ReadInt32();
            return true;
        }
    }
    public class DBLevelupPackageRow
    {
        public int id { get; set; } // 0x10
        public int product_id { get; set; } // 0x14
        public int reward_index { get; set; } // 0x18
        public int user_rank { get; set; } // 0x1C
        public int reward_item_id_1 { get; set; } // 0x20
        public int reward_item_count_1 { get; set; } // 0x24
        public List<int> list_reward_item_id = new List<int>(); // 0x28
        public List<int> list_reward_item_count = new List<int>(); // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            product_id = reader.ReadInt32();
            reward_index = reader.ReadInt32();
            user_rank = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            return true;
        }
    }
    public class DBLoadingDefaultRow
    {
        public int id { get; set; } // 0x10
        public string map_filename { get; set; } // 0x18
        public int before_loading_id { get; set; } // 0x20
        public int after_loading_id { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            map_filename = reader.ReadString();
            before_loading_id = reader.ReadInt32();
            after_loading_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBLoadingSceneRow
    {
        public int id { get; set; } // 0x10
        public int group_id { get; set; } // 0x14
        public int loading_type { get; set; } // 0x18
        public string loading_scene_path { get; set; } // 0x20
        public string resource_loading_scene { get; set; } // 0x28
        public string loading_title { get; set; } // 0x30
        public string loading_desc { get; set; } // 0x38
        public int loading_hero { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            loading_type = reader.ReadInt32();
            loading_scene_path = reader.ReadString();
            resource_loading_scene = reader.ReadString();
            loading_title = reader.ReadString();
            loading_desc = reader.ReadString();
            loading_hero = reader.ReadInt32();
            return true;
        }
    }
    public class DBLoadingSettingRow
    {
        public int id { get; set; } // 0x10
        public string contents_type { get; set; } // 0x18
        public string type { get; set; } // 0x20
        public int stage_ID { get; set; } // 0x28
        public int before_loading_id { get; set; } // 0x2C
        public int after_loading_id { get; set; } // 0x30
        public int loading_tip_group { get; set; } // 0x34
        public string open_type { get; set; } // 0x38
        public int open_value { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            contents_type = reader.ReadString();
            type = reader.ReadString();
            stage_ID = reader.ReadInt32();
            before_loading_id = reader.ReadInt32();
            after_loading_id = reader.ReadInt32();
            loading_tip_group = reader.ReadInt32();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBLoadingTipRow
    {
        public int id { get; set; } // 0x10
        public string loading_tip_localize { get; set; } // 0x18
        public int group_id { get; set; } // 0x20
        public string open_type { get; set; } // 0x28
        public int open_value { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            loading_tip_localize = reader.ReadString();
            group_id = reader.ReadInt32();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBLobbyHousingBuffRow
    {
        public int id { get; set; } // 0x10
        public string passive_type { get; set; } // 0x18
        public int passive_id { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            passive_type = reader.ReadString();
            passive_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBLobbyHousingFurnitureBaseRow
    {
        public int id { get; set; } // 0x10
        public int default_check { get; set; } // 0x14
        public int furniture_group { get; set; } // 0x18
        public string furniture_path { get; set; } // 0x20
        public string furniture_resource { get; set; } // 0x28
        public string furniture_ani { get; set; } // 0x30
        public int use_night { get; set; } // 0x38
        public string array_furniture_camera { get; set; } // 0x40
        public List<int> list_array_furniture_camera = new List<int>(); // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            default_check = reader.ReadInt32();
            furniture_group = reader.ReadInt32();
            furniture_path = reader.ReadString();
            furniture_resource = reader.ReadString();
            furniture_ani = reader.ReadString();
            use_night = reader.ReadInt32();
            //array_furniture_camera = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_furniture_camera.Add(reader.ReadInt32());
                v0--;
            }
            return true;
        }
    }
    public class DBLobbyHousingShopRow
    {
        public int id { get; set; } // 0x10
        public string shop_type { get; set; } // 0x18
        public int product_id { get; set; } // 0x20
        public int price_id { get; set; } // 0x24
        public int price_count { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            shop_type = reader.ReadString();
            product_id = reader.ReadInt32();
            price_id = reader.ReadInt32();
            price_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBLobbyNpcRewardRow
    {
        public int id { get; set; } // 0x10
        public int hero_id { get; set; } // 0x14
        public int level { get; set; } // 0x18
        public string reward_type { get; set; } // 0x20
        public int reward_index { get; set; } // 0x28
        public string reward_icon { get; set; } // 0x30
        public string reward_title { get; set; } // 0x38
        public string reward_desc { get; set; } // 0x40
        public string detail_reward_desc { get; set; } // 0x48
        public string array_sound_id { get; set; } // 0x50
        public List<int> list_array_sound_id = new List<int>(); // 0x58
        public string illust { get; set; } // 0x60
        public int reward_item { get; set; } // 0x68
        public int reward_item_count { get; set; } // 0x6C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            hero_id = reader.ReadInt32();
            level = reader.ReadInt32();
            reward_type = reader.ReadString();
            reward_index = reader.ReadInt32();
            reward_icon = reader.ReadString();
            reward_title = reader.ReadString();
            reward_desc = reader.ReadString();
            detail_reward_desc = reader.ReadString();
            //array_sound_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_sound_id.Add(reader.ReadInt32());
                v0--;
            }
            illust = reader.ReadString();
            reward_item = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBLoseGuideRow
    {
        public int id { get; set; } // 0x10
        public string control_type { get; set; } // 0x18
        public int stage_id { get; set; } // 0x20
        public int guide_page_index { get; set; } // 0x24
        public int pack_index { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            control_type = reader.ReadString();
            stage_id = reader.ReadInt32();
            guide_page_index = reader.ReadInt32();
            pack_index = reader.ReadInt32();
            return true;
        }
    }
    public class DBMailboxRow
    {
        public int id { get; set; } // 0x10
        public string mail_route_localize { get; set; } // 0x18
        public string mail_route_desc_localize { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            mail_route_localize = reader.ReadString();
            mail_route_desc_localize = reader.ReadString();
            return true;
        }
    }
    public class DBMaterialChangeRow
    {
        public int id { get; set; } // 0x10
        public int town_id { get; set; } // 0x14
        public string material_resource { get; set; } // 0x18
        public string open_type { get; set; } // 0x20
        public int open_value { get; set; } // 0x28
        public string close_type { get; set; } // 0x30
        public int close_value { get; set; } // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            town_id = reader.ReadInt32();
            material_resource = reader.ReadString();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            close_type = reader.ReadString();
            close_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBMissionRow
    {
        public int id { get; set; } // 0x10
        public int category { get; set; } // 0x14
        public int group_id { get; set; } // 0x18
        public int group_index { get; set; } // 0x1C
        public int chain_id { get; set; } // 0x20
        public int chain_index { get; set; } // 0x24
        public string mission_type { get; set; } // 0x28
        public int mission_type_value { get; set; } // 0x30
        public int mission_target_value { get; set; } // 0x34
        public int alarm_type { get; set; } // 0x38
        public int reward_item_id_1 { get; set; } // 0x3C
        public int reward_item_count_1 { get; set; } // 0x40
        public int reward_achievepoint_Value { get; set; } // 0x44
        public int localize_display_type { get; set; } // 0x48
        public string mission_name { get; set; } // 0x50
        public int mission_quick_link { get; set; } // 0x58
        public List<int> list_reward_item_id = new List<int>(); // 0x60
        public List<int> list_reward_item_count = new List<int>(); // 0x68
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            category = reader.ReadInt32();
            group_id = reader.ReadInt32();
            group_index = reader.ReadInt32();
            chain_id = reader.ReadInt32();
            chain_index = reader.ReadInt32();
            mission_type = reader.ReadString();
            mission_type_value = reader.ReadInt32();
            mission_target_value = reader.ReadInt32();
            alarm_type = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            reward_achievepoint_Value = reader.ReadInt32();
            localize_display_type = reader.ReadInt32();
            mission_name = reader.ReadString();
            mission_quick_link = reader.ReadInt32();
            return true;
        }
    }
    public class DBMissionAchievepointRow
    {
        public int id { get; set; } // 0x10
        public int reward_order { get; set; } // 0x14
        public int mission_target_value { get; set; } // 0x18
        public int reward_item_id_1 { get; set; } // 0x1C
        public int reward_item_count_1 { get; set; } // 0x20
        public string name { get; set; } // 0x28
        public List<int> list_reward_item_id = new List<int>(); // 0x30
        public List<int> list_reward_item_count = new List<int>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            reward_order = reader.ReadInt32();
            mission_target_value = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            name = reader.ReadString();
            return true;
        }
    }
    public class DBMissionPlayTitleRow
    {
        public int id { get; set; } // 0x10
        public int category { get; set; } // 0x14
        public string mission_type { get; set; } // 0x18
        public int mission_type_value { get; set; } // 0x20
        public int mission_target_value { get; set; } // 0x24
        public int target_progress_type { get; set; } // 0x28
        public string reward_title { get; set; } // 0x30
        public string title_desc { get; set; } // 0x38
        public string title_hint { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            category = reader.ReadInt32();
            mission_type = reader.ReadString();
            mission_type_value = reader.ReadInt32();
            mission_target_value = reader.ReadInt32();
            target_progress_type = reader.ReadInt32();
            reward_title = reader.ReadString();
            title_desc = reader.ReadString();
            title_hint = reader.ReadString();
            return true;
        }
    }
    public class DBMissionPlayTitleGroupRow
    {
        public int id { get; set; } // 0x10
        public int category { get; set; } // 0x14
        public string passive_type { get; set; } // 0x18
        public int passive_id { get; set; } // 0x20
        public float passive_value { get; set; } // 0x24
        public int play_title_point { get; set; } // 0x28
        public string play_title_icon { get; set; } // 0x30
        public string play_title { get; set; } // 0x38
        public string play_title_mission_name { get; set; } // 0x40
        public string play_title_mission_desc { get; set; } // 0x48
        public string play_title_passive_desc { get; set; } // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            category = reader.ReadInt32();
            passive_type = reader.ReadString();
            passive_id = reader.ReadInt32();
            passive_value = reader.ReadSingle();
            play_title_point = reader.ReadInt32();
            play_title_icon = reader.ReadString();
            play_title = reader.ReadString();
            play_title_mission_name = reader.ReadString();
            play_title_mission_desc = reader.ReadString();
            play_title_passive_desc = reader.ReadString();
            return true;
        }
    }
    public class DBMonsterAiRow
    {
        public int id { get; set; } // 0x10
        public string boss_team_ai_1 { get; set; } // 0x18
        public string boss_team_ai_2 { get; set; } // 0x20
        public string boss_team_ai_3 { get; set; } // 0x28
        public string boss_team_ai_4 { get; set; } // 0x30
        public string boss_team_ai_5 { get; set; } // 0x38
        public string boss_team_ai_6 { get; set; } // 0x40
        public string normal_team_ai_1 { get; set; } // 0x48
        public string normal_team_ai_2 { get; set; } // 0x50
        public string normal_team_ai_3 { get; set; } // 0x58
        public List<string> list_boss_team_ai = new List<string>(); // 0x60
        public List<string> list_normal_team_ai = new List<string>(); // 0x68
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            boss_team_ai_1 = reader.ReadString();
            boss_team_ai_2 = reader.ReadString();
            boss_team_ai_3 = reader.ReadString();
            boss_team_ai_4 = reader.ReadString();
            boss_team_ai_5 = reader.ReadString();
            boss_team_ai_6 = reader.ReadString();
            normal_team_ai_1 = reader.ReadString();
            normal_team_ai_2 = reader.ReadString();
            normal_team_ai_3 = reader.ReadString();
            return true;
        }
    }
    public class DBMusicalBaseRow
    {
        public int id { get; set; } // 0x10
        public string musical_base_type_name { get; set; } // 0x18
        public string musical_base_icon { get; set; } // 0x20
        public int musical_compose_use { get; set; } // 0x28
        public int musical_compose_open { get; set; } // 0x2C
        public int musical_gm_id { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            musical_base_type_name = reader.ReadString();
            musical_base_icon = reader.ReadString();
            musical_compose_use = reader.ReadInt32();
            musical_compose_open = reader.ReadInt32();
            musical_gm_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBNetmarbleRewardRow
    {
        public int id { get; set; } // 0x10
        public int item_id { get; set; } // 0x14
        public int item_count { get; set; } // 0x18
        public string netmarble_reward_id { get; set; } // 0x20
        public int contents_type { get; set; } // 0x28
        public string goods_name { get; set; } // 0x30
        public string goods_explain { get; set; } // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            netmarble_reward_id = reader.ReadString();
            contents_type = reader.ReadInt32();
            goods_name = reader.ReadString();
            goods_explain = reader.ReadString();
            return true;
        }
    }
    public class DBNormalPackageRow
    {
        public int product_id { get; set; } // 0x10
        public int reward_item_id_1 { get; set; } // 0x14
        public int reward_item_count_1 { get; set; } // 0x18
        public int reward_item_id_2 { get; set; } // 0x1C
        public int reward_item_count_2 { get; set; } // 0x20
        public int reward_item_id_3 { get; set; } // 0x24
        public int reward_item_count_3 { get; set; } // 0x28
        public int reward_item_id_4 { get; set; } // 0x2C
        public int reward_item_count_4 { get; set; } // 0x30
        public int reward_item_id_5 { get; set; } // 0x34
        public int reward_item_count_5 { get; set; } // 0x38
        public int reward_item_id_6 { get; set; } // 0x3C
        public int reward_item_count_6 { get; set; } // 0x40
        public int reward_item_id_7 { get; set; } // 0x44
        public int reward_item_count_7 { get; set; } // 0x48
        public int reward_item_id_8 { get; set; } // 0x4C
        public int reward_item_count_8 { get; set; } // 0x50
        public int reward_item_id_9 { get; set; } // 0x54
        public int reward_item_count_9 { get; set; } // 0x58
        public int reward_item_id_10 { get; set; } // 0x5C
        public int reward_item_count_10 { get; set; } // 0x60
        public List<int> list_reward_item_id = new List<int>(); // 0x68
        public List<int> list_reward_item_count = new List<int>(); // 0x70
        public bool ReadToStream(BinaryReader reader)
        {
            product_id = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            reward_item_id_2 = reader.ReadInt32();
            reward_item_count_2 = reader.ReadInt32();
            reward_item_id_3 = reader.ReadInt32();
            reward_item_count_3 = reader.ReadInt32();
            reward_item_id_4 = reader.ReadInt32();
            reward_item_count_4 = reader.ReadInt32();
            reward_item_id_5 = reader.ReadInt32();
            reward_item_count_5 = reader.ReadInt32();
            reward_item_id_6 = reader.ReadInt32();
            reward_item_count_6 = reader.ReadInt32();
            reward_item_id_7 = reader.ReadInt32();
            reward_item_count_7 = reader.ReadInt32();
            reward_item_id_8 = reader.ReadInt32();
            reward_item_count_8 = reader.ReadInt32();
            reward_item_id_9 = reader.ReadInt32();
            reward_item_count_9 = reader.ReadInt32();
            reward_item_id_10 = reader.ReadInt32();
            reward_item_count_10 = reader.ReadInt32();
            return true;
        }
    }
    public class DBNoticeRow
    {
        public int id { get; set; } // 0x10
        public string notice_title { get; set; } // 0x18
        public string notice_desc1 { get; set; } // 0x20
        public string notice_desc2 { get; set; } // 0x28
        public int notice_type { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            notice_title = reader.ReadString();
            notice_desc1 = reader.ReadString();
            notice_desc2 = reader.ReadString();
            notice_type = reader.ReadInt32();
            return true;
        }
    }
    public class DBNpcInfoRow
    {
        public int id { get; set; } // 0x10
        public string npc_icon_info { get; set; } // 0x18
        public string dressup_silhouette { get; set; } // 0x20
        public string array_prop { get; set; } // 0x28
        public List<int> list_array_prop = new List<int>(); // 0x30
        public string resource { get; set; } // 0x38
        public string head_resource { get; set; } // 0x40
        public string body_resource { get; set; } // 0x48
        public string special_resource { get; set; } // 0x50
        public string anim_resource { get; set; } // 0x58
        public string normal_ani { get; set; } // 0x60
        public string random_ani { get; set; } // 0x68
        public string wait_ani { get; set; } // 0x70
        public string walk_ani { get; set; } // 0x78
        public string run_ani { get; set; } // 0x80
        public string sequence_start_ani { get; set; } // 0x88
        public string sequence_start_add_ani_1 { get; set; } // 0x90
        public string sequence_start_add_ani_2 { get; set; } // 0x98
        public string sequence_start_add_ani_3 { get; set; } // 0xA0
        public string sequence_end_ani { get; set; } // 0xA8
        public float npc_height { get; set; } // 0xB0
        public float trans_scale { get; set; } // 0xB4
        public string size_info { get; set; } // 0xB8
        public float content_radius { get; set; } // 0xC0
        public int position_id { get; set; } // 0xC4
        public int look_at { get; set; } // 0xC8
        public int object_check { get; set; } // 0xCC
        public List<string> list_sequence_start_add_ani = new List<string>(); // 0xD0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            npc_icon_info = reader.ReadString();
            dressup_silhouette = reader.ReadString();
            //array_prop = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_prop.Add(reader.ReadInt32());
                v0--;
            }
            resource = reader.ReadString();
            head_resource = reader.ReadString();
            body_resource = reader.ReadString();
            special_resource = reader.ReadString();
            anim_resource = reader.ReadString();
            normal_ani = reader.ReadString();
            random_ani = reader.ReadString();
            wait_ani = reader.ReadString();
            walk_ani = reader.ReadString();
            run_ani = reader.ReadString();
            sequence_start_ani = reader.ReadString();
            sequence_start_add_ani_1 = reader.ReadString();
            sequence_start_add_ani_2 = reader.ReadString();
            sequence_start_add_ani_3 = reader.ReadString();
            sequence_end_ani = reader.ReadString();
            npc_height = reader.ReadSingle();
            trans_scale = reader.ReadSingle();
            size_info = reader.ReadString();
            content_radius = reader.ReadSingle();
            position_id = reader.ReadInt32();
            look_at = reader.ReadInt32();
            object_check = reader.ReadInt32();
            return true;
        }
    }
    public class DBNpcPropRow
    {
        public int id { get; set; } // 0x10
        public string path { get; set; } // 0x18
        public string resource { get; set; } // 0x20
        public int type { get; set; } // 0x28
        public string attach_name { get; set; } // 0x30
        public string attach { get; set; } // 0x38
        public string ani_keyname { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            path = reader.ReadString();
            resource = reader.ReadString();
            type = reader.ReadInt32();
            attach_name = reader.ReadString();
            attach = reader.ReadString();
            ani_keyname = reader.ReadString();
            return true;
        }
    }
    public class LocalizationManager
    {
        public string name { get; set; } // 0x10
        public string text { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            name = reader.ReadString();
            text = reader.ReadString();
            return true;
        }
    }
    public class DBPackageWeaponGrowthRow
    {
        public int id { get; set; } // 0x10
        public int product_id { get; set; } // 0x14
        public int item_id { get; set; } // 0x18
        public int weapon_evolution_count { get; set; } // 0x1C
        public int evolution_option_1 { get; set; } // 0x20
        public int evolution_option_2 { get; set; } // 0x24
        public int evolution_option_3 { get; set; } // 0x28
        public int evolution_option_4 { get; set; } // 0x2C
        public int evolution_option_5 { get; set; } // 0x30
        public int weapon_upgrade_count { get; set; } // 0x34
        public List<int> list_evolution_option = new List<int>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            product_id = reader.ReadInt32();
            item_id = reader.ReadInt32();
            weapon_evolution_count = reader.ReadInt32();
            evolution_option_1 = reader.ReadInt32();
            evolution_option_2 = reader.ReadInt32();
            evolution_option_3 = reader.ReadInt32();
            evolution_option_4 = reader.ReadInt32();
            evolution_option_5 = reader.ReadInt32();
            weapon_upgrade_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBPackageWeekSetupRow
    {
        public int id { get; set; } // 0x10
        public int product_id { get; set; } // 0x14
        public int sunday { get; set; } // 0x18
        public int monday { get; set; } // 0x1C
        public int tuesday { get; set; } // 0x20
        public int wednesday { get; set; } // 0x24
        public int thursday { get; set; } // 0x28
        public int friday { get; set; } // 0x2C
        public int saturday { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            product_id = reader.ReadInt32();
            sunday = reader.ReadInt32();
            monday = reader.ReadInt32();
            tuesday = reader.ReadInt32();
            wednesday = reader.ReadInt32();
            thursday = reader.ReadInt32();
            friday = reader.ReadInt32();
            saturday = reader.ReadInt32();
            return true;
        }
    }
    public class DBPassDesignSettingRow
    {
        public int setting_id { get; set; } // 0x10
        public string bg_design { get; set; } // 0x18
        public string shop_btn_design { get; set; } // 0x20
        public string food_design { get; set; } // 0x28
        public string food_empty_design { get; set; } // 0x30
        public string food_special_design { get; set; } // 0x38
        public string food_special_empty_design { get; set; } // 0x40
        public string ground_design { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            setting_id = reader.ReadInt32();
            bg_design = reader.ReadString();
            shop_btn_design = reader.ReadString();
            food_design = reader.ReadString();
            food_empty_design = reader.ReadString();
            food_special_design = reader.ReadString();
            food_special_empty_design = reader.ReadString();
            ground_design = reader.ReadString();
            return true;
        }
    }
    public class DBPassMissionRankRow
    {
        public int mission_rank { get; set; } // 0x10
        public int need_mission_point { get; set; } // 0x14
        public bool ReadToStream(BinaryReader reader)
        {
            mission_rank = reader.ReadInt32();
            need_mission_point = reader.ReadInt32();
            return true;
        }
    }
    public class DBPassMissionRankRewardRow
    {
        public int index { get; set; } // 0x10
        public int setting_id { get; set; } // 0x14
        public int mission_rank { get; set; } // 0x18
        public int ground_icon_type { get; set; } // 0x1C
        public int normal_reward_item_id { get; set; } // 0x20
        public int normal_reward_item_count { get; set; } // 0x24
        public int special_reward_item_id_1 { get; set; } // 0x28
        public int special_reward_item_count_1 { get; set; } // 0x2C
        public int special_reward_item_id_2 { get; set; } // 0x30
        public int special_reward_item_count_2 { get; set; } // 0x34
        public List<int> list_special_reward_item_id = new List<int>(); // 0x38
        public List<int> list_special_reward_item_count = new List<int>(); // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            index = reader.ReadInt32();
            setting_id = reader.ReadInt32();
            mission_rank = reader.ReadInt32();
            ground_icon_type = reader.ReadInt32();
            normal_reward_item_id = reader.ReadInt32();
            normal_reward_item_count = reader.ReadInt32();
            special_reward_item_id_1 = reader.ReadInt32();
            special_reward_item_count_1 = reader.ReadInt32();
            special_reward_item_id_2 = reader.ReadInt32();
            special_reward_item_count_2 = reader.ReadInt32();
            return true;
        }
    }
    public class DBPopupPackageRow
    {
        public int id { get; set; } // 0x10
        public int link_product_id { get; set; } // 0x14
        public string type { get; set; } // 0x18
        public string popup_timing { get; set; } // 0x20
        public string popup_image_url { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            link_product_id = reader.ReadInt32();
            type = reader.ReadString();
            popup_timing = reader.ReadString();
            popup_image_url = reader.ReadString();
            return true;
        }
    }
    public class DBPreviewAccountRow
    {
        public int id { get; set; } // 0x10
        public string name { get; set; } // 0x18
        public string password { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            name = reader.ReadString();
            password = reader.ReadString();
            return true;
        }
    }
    public class DBPvpModeBaseRow
    {
        public int id { get; set; } // 0x10
        public string mode_type { get; set; } // 0x18
        public int mode_type_value { get; set; } // 0x20
        public string array_mode_passive_id { get; set; } // 0x28
        public List<int> list_array_mode_passive_id = new List<int>(); // 0x30
        public string name { get; set; } // 0x38
        public string explain { get; set; } // 0x40
        public string mode_icon { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            mode_type = reader.ReadString();
            mode_type_value = reader.ReadInt32();
            //array_mode_passive_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_mode_passive_id.Add(reader.ReadInt32());
                v0--;
            }
            name = reader.ReadString();
            explain = reader.ReadString();
            mode_icon = reader.ReadString();
            return true;
        }
    }
    public class DBPvpNpcBaseRow
    {
        public int npc_id { get; set; } // 0x10
        public int skin_id { get; set; } // 0x14
        public int team_group_id { get; set; } // 0x18
        public int npc_exp { get; set; } // 0x1C
        public int weapon_costume_id { get; set; } // 0x20
        public int weapon_costume_hold { get; set; } // 0x24
        public int skin_costume_id { get; set; } // 0x28
        public int skin_costume_hold { get; set; } // 0x2C
        public int awaken_count { get; set; } // 0x30
        public int special_skill_level { get; set; } // 0x34
        public bool ReadToStream(BinaryReader reader)
        {
            npc_id = reader.ReadInt32();
            skin_id = reader.ReadInt32();
            team_group_id = reader.ReadInt32();
            npc_exp = reader.ReadInt32();
            weapon_costume_id = reader.ReadInt32();
            weapon_costume_hold = reader.ReadInt32();
            skin_costume_id = reader.ReadInt32();
            skin_costume_hold = reader.ReadInt32();
            awaken_count = reader.ReadInt32();
            special_skill_level = reader.ReadInt32();
            return true;
        }
    }
    public class DBPvpNpcNameRow
    {
        public int id { get; set; } // 0x10
        public string name_local { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            name_local = reader.ReadString();
            return true;
        }
    }
    public class DBPvpPointRow
    {
        public int id { get; set; } // 0x10
        public int league_type { get; set; } // 0x14
        public int rank_type { get; set; } // 0x18
        public int rank_num { get; set; } // 0x1C
        public int rating { get; set; } // 0x20
        public int realtime_rate { get; set; } // 0x24
        public string rating_icon { get; set; } // 0x28
        public string rating_name { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            league_type = reader.ReadInt32();
            rank_type = reader.ReadInt32();
            rank_num = reader.ReadInt32();
            rating = reader.ReadInt32();
            realtime_rate = reader.ReadInt32();
            rating_icon = reader.ReadString();
            rating_name = reader.ReadString();
            return true;
        }
    }
    public class DBPvpRewardRow
    {
        public int id { get; set; } // 0x10
        public int league_type { get; set; } // 0x14
        public int rank_type { get; set; } // 0x18
        public int rank_num { get; set; } // 0x1C
        public int rank_min { get; set; } // 0x20
        public int rank_max { get; set; } // 0x24
        public int reward_id_1 { get; set; } // 0x28
        public int reward_count_1 { get; set; } // 0x2C
        public int reward_id_2 { get; set; } // 0x30
        public int reward_count_2 { get; set; } // 0x34
        public int reward_season_point { get; set; } // 0x38
        public List<int> list_reward_id = new List<int>(); // 0x40
        public List<int> list_reward_count = new List<int>(); // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            league_type = reader.ReadInt32();
            rank_type = reader.ReadInt32();
            rank_num = reader.ReadInt32();
            rank_min = reader.ReadInt32();
            rank_max = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            reward_id_2 = reader.ReadInt32();
            reward_count_2 = reader.ReadInt32();
            reward_season_point = reader.ReadInt32();
            return true;
        }
    }
    public class DBPvpSeasonBaseRow
    {
        public int id { get; set; } // 0x10
        public string season_start_date { get; set; } // 0x18
        public string season_limited_date { get; set; } // 0x20
        public string season_past_limited_date { get; set; } // 0x28
        public string season_title { get; set; } // 0x30
        public string season_banner_s { get; set; } // 0x38
        public string season_banner_s_title { get; set; } // 0x40
        public string season_banner_s_desc { get; set; } // 0x48
        public int season_reward_group { get; set; } // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            season_start_date = reader.ReadString();
            season_limited_date = reader.ReadString();
            season_past_limited_date = reader.ReadString();
            season_title = reader.ReadString();
            season_banner_s = reader.ReadString();
            season_banner_s_title = reader.ReadString();
            season_banner_s_desc = reader.ReadString();
            season_reward_group = reader.ReadInt32();
            return true;
        }
    }
    public class DBPvpSeasonRewardGroupRow
    {
        public int id { get; set; } // 0x10
        public int rank_min { get; set; } // 0x14
        public int rank_max { get; set; } // 0x18
        public string rank_icon { get; set; } // 0x20
        public int reward_group { get; set; } // 0x28
        public int reward_id_1 { get; set; } // 0x2C
        public int reward_count_1 { get; set; } // 0x30
        public int reward_id_2 { get; set; } // 0x34
        public int reward_count_2 { get; set; } // 0x38
        public int reward_id_3 { get; set; } // 0x3C
        public int reward_count_3 { get; set; } // 0x40
        public List<int> list_reward_id = new List<int>(); // 0x48
        public List<int> list_reward_count = new List<int>(); // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            rank_min = reader.ReadInt32();
            rank_max = reader.ReadInt32();
            rank_icon = reader.ReadString();
            reward_group = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            reward_id_2 = reader.ReadInt32();
            reward_count_2 = reader.ReadInt32();
            reward_id_3 = reader.ReadInt32();
            reward_count_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBPvpShopRow
    {
        public int id { get; set; } // 0x10
        public int basepoint_id { get; set; } // 0x14
        public int npc_id { get; set; } // 0x18
        public int league_type { get; set; } // 0x1C
        public int tab_index { get; set; } // 0x20
        public int need_pvp_grade { get; set; } // 0x24
        public int sell_type { get; set; } // 0x28
        public int shop_item_id { get; set; } // 0x2C
        public int product_count { get; set; } // 0x30
        public int buy_limited_count { get; set; } // 0x34
        public int price_id_1 { get; set; } // 0x38
        public int price_count_1 { get; set; } // 0x3C
        public List<int> list_price_id = new List<int>(); // 0x40
        public List<int> list_price_count = new List<int>(); // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            basepoint_id = reader.ReadInt32();
            npc_id = reader.ReadInt32();
            league_type = reader.ReadInt32();
            tab_index = reader.ReadInt32();
            need_pvp_grade = reader.ReadInt32();
            sell_type = reader.ReadInt32();
            shop_item_id = reader.ReadInt32();
            product_count = reader.ReadInt32();
            buy_limited_count = reader.ReadInt32();
            price_id_1 = reader.ReadInt32();
            price_count_1 = reader.ReadInt32();
            return true;
        }
    }
    public class DBPvpShowRow
    {
        public int id { get; set; } // 0x10
        public int rank_type { get; set; } // 0x14
        public string type_icon { get; set; } // 0x18
        public string type_localize { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            rank_type = reader.ReadInt32();
            type_icon = reader.ReadString();
            type_localize = reader.ReadString();
            return true;
        }
    }
    public class DBPvpTop100BannerRow
    {
        public int id { get; set; } // 0x10
        public string banner_image { get; set; } // 0x18
        public string banner_title_local { get; set; } // 0x20
        public string banner_desc_local { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            banner_image = reader.ReadString();
            banner_title_local = reader.ReadString();
            banner_desc_local = reader.ReadString();
            return true;
        }
    }
    public class DBPvpTopRankRow
    {
        public int id { get; set; } // 0x10
        public int rank_min { get; set; } // 0x14
        public int rank_max { get; set; } // 0x18
        public string ranker_title { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            rank_min = reader.ReadInt32();
            rank_max = reader.ReadInt32();
            ranker_title = reader.ReadString();
            return true;
        }
    }
    public class DBPvpTournamentRewardRow
    {
        public int id { get; set; } // 0x10
        public int rank_min { get; set; } // 0x14
        public int rank_max { get; set; } // 0x18
        public int reward_group { get; set; } // 0x1C
        public int reward_type { get; set; } // 0x20
        public int reward_id_1 { get; set; } // 0x24
        public int reward_count_1 { get; set; } // 0x28
        public int reward_id_2 { get; set; } // 0x2C
        public int reward_count_2 { get; set; } // 0x30
        public int reward_id_3 { get; set; } // 0x34
        public int reward_count_3 { get; set; } // 0x38
        public string reward_rank_title { get; set; } // 0x40
        public List<int> list_reward_id = new List<int>(); // 0x48
        public List<int> list_reward_count = new List<int>(); // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            rank_min = reader.ReadInt32();
            rank_max = reader.ReadInt32();
            reward_group = reader.ReadInt32();
            reward_type = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            reward_id_2 = reader.ReadInt32();
            reward_count_2 = reader.ReadInt32();
            reward_id_3 = reader.ReadInt32();
            reward_count_3 = reader.ReadInt32();
            reward_rank_title = reader.ReadString();
            return true;
        }
    }
    public class DBPvpWeekSettingRow
    {
        public int id { get; set; } // 0x10
        public int week_group_id { get; set; } // 0x14
        public int pvp_passive_id { get; set; } // 0x18
        public int pvp_mode_id { get; set; } // 0x1C
        public string pvp_passive_icon { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            week_group_id = reader.ReadInt32();
            pvp_passive_id = reader.ReadInt32();
            pvp_mode_id = reader.ReadInt32();
            pvp_passive_icon = reader.ReadString();
            return true;
        }
    }
    public class DBPvpWinningPointRow
    {
        public int id { get; set; } // 0x10
        public string winning_type { get; set; } // 0x18
        public int battle_point_min { get; set; } // 0x20
        public int battle_point_max { get; set; } // 0x24
        public int add_battle_point { get; set; } // 0x28
        public int bronze_battle_point { get; set; } // 0x2C
        public int silver_battle_point { get; set; } // 0x30
        public int challenger_battle_point { get; set; } // 0x34
        public int top100_atk_battle_point { get; set; } // 0x38
        public int top100_def_battle_point { get; set; } // 0x3C
        public int challenger_win_season_point { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            winning_type = reader.ReadString();
            battle_point_min = reader.ReadInt32();
            battle_point_max = reader.ReadInt32();
            add_battle_point = reader.ReadInt32();
            bronze_battle_point = reader.ReadInt32();
            silver_battle_point = reader.ReadInt32();
            challenger_battle_point = reader.ReadInt32();
            top100_atk_battle_point = reader.ReadInt32();
            top100_def_battle_point = reader.ReadInt32();
            challenger_win_season_point = reader.ReadInt32();
            return true;
        }
    }
    public class DBQuestRow
    {
        public int id { get; set; } // 0x10
        public string quest_name { get; set; } // 0x18
        public int region { get; set; } // 0x20
        public int quest_basepoint_id { get; set; } // 0x24
        public string quest_class { get; set; } // 0x28
        public int another_episode { get; set; } // 0x30
        public int event_sub_index { get; set; } // 0x34
        public int repeat_check { get; set; } // 0x38
        public int next_story_quest { get; set; } // 0x3C
        public int need_base_fellow_level { get; set; } // 0x40
        public string open_class_1 { get; set; } // 0x48
        public string open_type_1 { get; set; } // 0x50
        public int open_value_1 { get; set; } // 0x58
        public int fellow_quest_group { get; set; } // 0x5C
        public int quest_group { get; set; } // 0x60
        public int matching_area_end_id { get; set; } // 0x64
        public int contents_open_area { get; set; } // 0x68
        public string array_contents_check { get; set; } // 0x70
        public List<string> list_array_contents_check = new List<string>(); // 0x78
        public int auto_start { get; set; } // 0x80
        public int start_area_id { get; set; } // 0x84
        public int start_npc_id { get; set; } // 0x88
        public int auto_story_cut { get; set; } // 0x8C
        public int auto_end { get; set; } // 0x90
        public int end_area_id { get; set; } // 0x94
        public int end_npc_id { get; set; } // 0x98
        public string quest_type { get; set; } // 0xA0
        public string quest_info_alarm { get; set; } // 0xA8
        public int quest_info_alarm_group { get; set; } // 0xB0
        public string play_stage_type { get; set; } // 0xB8
        public string array_play_stage_id { get; set; } // 0xC0
        public List<int> list_array_play_stage_id = new List<int>(); // 0xC8
        public string array_need_id { get; set; } // 0xD0
        public List<int> list_array_need_id = new List<int>(); // 0xD8
        public string need_type { get; set; } // 0xE0
        public string array_need_count { get; set; } // 0xE8
        public List<int> list_array_need_count = new List<int>(); // 0xF0
        public int need_item_keep { get; set; } // 0xF8
        public int give_quest_item_id { get; set; } // 0xFC
        public int give_quest_item_count { get; set; } // 0x100
        public string array_count_npc { get; set; } // 0x108
        public List<int> list_array_count_npc = new List<int>(); // 0x110
        public string array_count_npc_menu { get; set; } // 0x118
        public List<string> list_array_count_npc_menu = new List<string>(); // 0x120
        public int item_info_link { get; set; } // 0x128
        public int lobby_quest_route { get; set; } // 0x12C
        public int loop_quest_id { get; set; } // 0x130
        public string quest_info { get; set; } // 0x138
        public string icon_info_1_resource { get; set; } // 0x140
        public int icon_info_1_item_id { get; set; } // 0x148
        public string icon_info_1 { get; set; } // 0x150
        public int need_user_rank { get; set; } // 0x158
        public int start_story_cut { get; set; } // 0x15C
        public int end_story_cut { get; set; } // 0x160
        public int character_position_move_id { get; set; } // 0x164
        public int user_exp { get; set; } // 0x168
        public int base_fellow_id { get; set; } // 0x16C
        public int base_fellow_exp { get; set; } // 0x170
        public int reward_item_id_1 { get; set; } // 0x174
        public int reward_item_count_1 { get; set; } // 0x178
        public int reward_item_hero_lv_1 { get; set; } // 0x17C
        public int reward_item_id_2 { get; set; } // 0x180
        public int reward_item_count_2 { get; set; } // 0x184
        public int reward_item_hero_lv_2 { get; set; } // 0x188
        public int reward_item_id_3 { get; set; } // 0x18C
        public int reward_item_count_3 { get; set; } // 0x190
        public int reward_item_hero_lv_3 { get; set; } // 0x194
        public int reward_item_id_4 { get; set; } // 0x198
        public int reward_item_count_4 { get; set; } // 0x19C
        public int reward_item_hero_lv_4 { get; set; } // 0x1A0
        public List<string> list_open_class = new List<string>(); // 0x1A8
        public List<string> list_open_type = new List<string>(); // 0x1B0
        public List<int> list_open_value = new List<int>(); // 0x1B8
        public List<string> list_icon_info = new List<string>(); // 0x1C0
        public List<int> list_reward_item_id = new List<int>(); // 0x1C8
        public List<int> list_reward_item_count = new List<int>(); // 0x1D0
        public List<int> list_reward_item_hero_lv = new List<int>(); // 0x1D8
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            quest_name = reader.ReadString();
            region = reader.ReadInt32();
            quest_basepoint_id = reader.ReadInt32();
            quest_class = reader.ReadString();
            another_episode = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            repeat_check = reader.ReadInt32();
            next_story_quest = reader.ReadInt32();
            need_base_fellow_level = reader.ReadInt32();
            open_class_1 = reader.ReadString();
            open_type_1 = reader.ReadString();
            open_value_1 = reader.ReadInt32();
            fellow_quest_group = reader.ReadInt32();
            quest_group = reader.ReadInt32();
            matching_area_end_id = reader.ReadInt32();
            contents_open_area = reader.ReadInt32();
            //array_contents_check = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_contents_check.Add(reader.ReadString());
                v0--;
            }
            auto_start = reader.ReadInt32();
            start_area_id = reader.ReadInt32();
            start_npc_id = reader.ReadInt32();
            auto_story_cut = reader.ReadInt32();
            auto_end = reader.ReadInt32();
            end_area_id = reader.ReadInt32();
            end_npc_id = reader.ReadInt32();
            quest_type = reader.ReadString();
            quest_info_alarm = reader.ReadString();
            quest_info_alarm_group = reader.ReadInt32();
            play_stage_type = reader.ReadString();
            //array_play_stage_id = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_play_stage_id.Add(reader.ReadInt32());
                v1--;
            }
            //array_need_id = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_need_id.Add(reader.ReadInt32());
                v2--;
            }
            need_type = reader.ReadString();
            //array_need_count = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_need_count.Add(reader.ReadInt32());
                v3--;
            }
            need_item_keep = reader.ReadInt32();
            give_quest_item_id = reader.ReadInt32();
            give_quest_item_count = reader.ReadInt32();
            //array_count_npc = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_count_npc.Add(reader.ReadInt32());
                v4--;
            }
            //array_count_npc_menu = reader.ReadString();
            var v5 = reader.ReadInt32();
            while ((v5 - 1) >= 0)
            {
                list_array_count_npc_menu.Add(reader.ReadString());
                v5--;
            }
            item_info_link = reader.ReadInt32();
            lobby_quest_route = reader.ReadInt32();
            loop_quest_id = reader.ReadInt32();
            quest_info = reader.ReadString();
            icon_info_1_resource = reader.ReadString();
            icon_info_1_item_id = reader.ReadInt32();
            icon_info_1 = reader.ReadString();
            need_user_rank = reader.ReadInt32();
            start_story_cut = reader.ReadInt32();
            end_story_cut = reader.ReadInt32();
            character_position_move_id = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            base_fellow_id = reader.ReadInt32();
            base_fellow_exp = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            reward_item_hero_lv_1 = reader.ReadInt32();
            reward_item_id_2 = reader.ReadInt32();
            reward_item_count_2 = reader.ReadInt32();
            reward_item_hero_lv_2 = reader.ReadInt32();
            reward_item_id_3 = reader.ReadInt32();
            reward_item_count_3 = reader.ReadInt32();
            reward_item_hero_lv_3 = reader.ReadInt32();
            reward_item_id_4 = reader.ReadInt32();
            reward_item_count_4 = reader.ReadInt32();
            reward_item_hero_lv_4 = reader.ReadInt32();
            return true;
        }
    }
    public class DBQuestCharacterRow
    {
        public int id { get; set; } // 0x10
        public int default_character { get; set; } // 0x14
        public int guest_id { get; set; } // 0x18
        public string open_type { get; set; } // 0x20
        public int open_value { get; set; } // 0x28
        public string close_type { get; set; } // 0x30
        public int close_value { get; set; } // 0x38
        public string contents { get; set; } // 0x40
        public int change_contents_id { get; set; } // 0x48
        public string resource { get; set; } // 0x50
        public string head_resource { get; set; } // 0x58
        public string body_resource { get; set; } // 0x60
        public string idle_ani { get; set; } // 0x68
        public string random_idle_ani { get; set; } // 0x70
        public string walk_ani { get; set; } // 0x78
        public string run_ani { get; set; } // 0x80
        public string destroy_ani { get; set; } // 0x88
        public string special_ani { get; set; } // 0x90
        public float run_radius { get; set; } // 0x98
        public float walk_speed { get; set; } // 0x9C
        public float run_speed { get; set; } // 0xA0
        public float trans_scale { get; set; } // 0xA4
        public string array_controller_val { get; set; } // 0xA8
        public List<float> list_array_controller_val = new List<float>(); // 0xB0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            default_character = reader.ReadInt32();
            guest_id = reader.ReadInt32();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            close_type = reader.ReadString();
            close_value = reader.ReadInt32();
            contents = reader.ReadString();
            change_contents_id = reader.ReadInt32();
            resource = reader.ReadString();
            head_resource = reader.ReadString();
            body_resource = reader.ReadString();
            idle_ani = reader.ReadString();
            random_idle_ani = reader.ReadString();
            walk_ani = reader.ReadString();
            run_ani = reader.ReadString();
            destroy_ani = reader.ReadString();
            special_ani = reader.ReadString();
            run_radius = reader.ReadSingle();
            walk_speed = reader.ReadSingle();
            run_speed = reader.ReadSingle();
            trans_scale = reader.ReadSingle();
            //array_controller_val = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_controller_val.Add(reader.ReadSingle());
                v0--;
            }
            return true;
        }
    }
    public class DBQuestCharacterCostumeRow
    {
        public int id { get; set; } // 0x10
        public int guest_id { get; set; } // 0x14
        public int item_id { get; set; } // 0x18
        public int default_check { get; set; } // 0x1C
        public string story_costume_name { get; set; } // 0x20
        public string icon_info { get; set; } // 0x28
        public string blind_open_type { get; set; } // 0x30
        public int blind_open_value { get; set; } // 0x38
        public string open_type { get; set; } // 0x40
        public int open_value { get; set; } // 0x48
        public int reward_check { get; set; } // 0x4C
        public string resource { get; set; } // 0x50
        public string head_resource { get; set; } // 0x58
        public string body_resource { get; set; } // 0x60
        public string array_prop { get; set; } // 0x68
        public List<int> list_array_prop = new List<int>(); // 0x70
        public string idle_ani { get; set; } // 0x78
        public string walk_ani { get; set; } // 0x80
        public int blind_open_state { get; set; } // 0x88
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            guest_id = reader.ReadInt32();
            item_id = reader.ReadInt32();
            default_check = reader.ReadInt32();
            story_costume_name = reader.ReadString();
            icon_info = reader.ReadString();
            blind_open_type = reader.ReadString();
            blind_open_value = reader.ReadInt32();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            reward_check = reader.ReadInt32();
            resource = reader.ReadString();
            head_resource = reader.ReadString();
            body_resource = reader.ReadString();
            //array_prop = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_prop.Add(reader.ReadInt32());
                v0--;
            }
            idle_ani = reader.ReadString();
            walk_ani = reader.ReadString();
            blind_open_state = reader.ReadInt32();
            return true;
        }
    }
    public class DBQuestDropRow
    {
        public int id { get; set; } // 0x10
        public int quest_id { get; set; } // 0x14
        public int prop_index { get; set; } // 0x18
        public string stage_type { get; set; } // 0x20
        public int drop_monster_id { get; set; } // 0x28
        public int drop_item_id { get; set; } // 0x2C
        public int drop_percent { get; set; } // 0x30
        public int drop_count_min { get; set; } // 0x34
        public int drop_count_max { get; set; } // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            quest_id = reader.ReadInt32();
            prop_index = reader.ReadInt32();
            stage_type = reader.ReadString();
            drop_monster_id = reader.ReadInt32();
            drop_item_id = reader.ReadInt32();
            drop_percent = reader.ReadInt32();
            drop_count_min = reader.ReadInt32();
            drop_count_max = reader.ReadInt32();
            return true;
        }
    }
    public class DBQuestEventUtilityRow
    {
        public int id { get; set; } // 0x10
        public string quest_class { get; set; } // 0x18
        public int region { get; set; } // 0x20
        public string quest_group_icon_path { get; set; } // 0x28
        public string quest_group_icon { get; set; } // 0x30
        public string quest_group_localize { get; set; } // 0x38
        public string array_quest_group_list { get; set; } // 0x40
        public List<int> list_array_quest_group_list = new List<int>(); // 0x48
        public string group_open_type { get; set; } // 0x50
        public int group_open_value { get; set; } // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            quest_class = reader.ReadString();
            region = reader.ReadInt32();
            quest_group_icon_path = reader.ReadString();
            quest_group_icon = reader.ReadString();
            quest_group_localize = reader.ReadString();
            //array_quest_group_list = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_quest_group_list.Add(reader.ReadInt32());
                v0--;
            }
            group_open_type = reader.ReadString();
            group_open_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBQuestSoundRow
    {
        public int id { get; set; } // 0x10
        public int sound_id { get; set; } // 0x14
        public int contents_id { get; set; } // 0x18
        public string bgm_open_type { get; set; } // 0x20
        public int bgm_open_value { get; set; } // 0x28
        public string bgm_close_type { get; set; } // 0x30
        public int bgm_close_value { get; set; } // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            sound_id = reader.ReadInt32();
            contents_id = reader.ReadInt32();
            bgm_open_type = reader.ReadString();
            bgm_open_value = reader.ReadInt32();
            bgm_close_type = reader.ReadString();
            bgm_close_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBQuestTalkRow
    {
        public int id { get; set; } // 0x10
        public int quest_id { get; set; } // 0x14
        public string quest_step { get; set; } // 0x18
        public int talk_npc_id { get; set; } // 0x20
        public string talk_type { get; set; } // 0x28
        public string talk_string { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            quest_id = reader.ReadInt32();
            quest_step = reader.ReadString();
            talk_npc_id = reader.ReadInt32();
            talk_type = reader.ReadString();
            talk_string = reader.ReadString();
            return true;
        }
    }
    public class DBRandomShopRatingPerRow
    {
        public int rating { get; set; } // 0x10
        public int normal_slot { get; set; } // 0x14
        public int special_slot { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            rating = reader.ReadInt32();
            normal_slot = reader.ReadInt32();
            special_slot = reader.ReadInt32();
            return true;
        }
    }
    public class DBRecommendTeamRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public int stage_id { get; set; } // 0x20
        public string array_recommend_1team { get; set; } // 0x28
        public List<int> list_array_recommend_1team = new List<int>(); // 0x30
        public string array_recommend_2team { get; set; } // 0x38
        public List<int> list_array_recommend_2team = new List<int>(); // 0x40
        public string array_recommend_3team { get; set; } // 0x48
        public List<int> list_array_recommend_3team = new List<int>(); // 0x50
        public string array_recommend_4team { get; set; } // 0x58
        public List<int> list_array_recommend_4team = new List<int>(); // 0x60
        public string array_recommend_5team { get; set; } // 0x68
        public List<int> list_array_recommend_5team = new List<int>(); // 0x70
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            stage_id = reader.ReadInt32();
            //array_recommend_1team = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_recommend_1team.Add(reader.ReadInt32());
                v0--;
            }
            //array_recommend_2team = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_recommend_2team.Add(reader.ReadInt32());
                v1--;
            }
            //array_recommend_3team = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_recommend_3team.Add(reader.ReadInt32());
                v2--;
            }
            //array_recommend_4team = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_recommend_4team.Add(reader.ReadInt32());
                v3--;
            }
            //array_recommend_5team = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_recommend_5team.Add(reader.ReadInt32());
                v4--;
            }
            return true;
        }
    }
    public class DBRegionRow
    {
        public int id { get; set; } // 0x10
        public int time_slot { get; set; } // 0x14
        public string region_type { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            time_slot = reader.ReadInt32();
            region_type = reader.ReadString();
            return true;
        }
    }
    public class DBRegionChangeRow
    {
        public int id { get; set; } // 0x10
        public int region_id { get; set; } // 0x14
        public string region_resource { get; set; } // 0x18
        public string path { get; set; } // 0x20
        public string change_region_prefab { get; set; } // 0x28
        public string open_type { get; set; } // 0x30
        public int open_value { get; set; } // 0x38
        public string close_type { get; set; } // 0x40
        public int close_value { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            region_id = reader.ReadInt32();
            region_resource = reader.ReadString();
            path = reader.ReadString();
            change_region_prefab = reader.ReadString();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            close_type = reader.ReadString();
            close_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBRegistrationMissionRow
    {
        public int id { get; set; } // 0x10
        public string os { get; set; } // 0x18
        public int item_id { get; set; } // 0x20
        public int item_count { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            os = reader.ReadString();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBRestBonusRow
    {
        public int id { get; set; } // 0x10
        public int bonus_item_id_1 { get; set; } // 0x14
        public int bonus_item_count_1 { get; set; } // 0x18
        public int bonus_item_id_2 { get; set; } // 0x1C
        public int bonus_item_count_2 { get; set; } // 0x20
        public int bonus_item_id_3 { get; set; } // 0x24
        public int bonus_item_count_3 { get; set; } // 0x28
        public List<int> list_bonus_item_id = new List<int>(); // 0x30
        public List<int> list_bonus_item_count = new List<int>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            bonus_item_id_1 = reader.ReadInt32();
            bonus_item_count_1 = reader.ReadInt32();
            bonus_item_id_2 = reader.ReadInt32();
            bonus_item_count_2 = reader.ReadInt32();
            bonus_item_id_3 = reader.ReadInt32();
            bonus_item_count_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBSelectedExchangeInfoRow
    {
        public int id { get; set; }// 0x10
        public byte select_group { get; set; }// 0x14
        public byte select_type_1 { get; set; }// 0x15
        public byte select_type_2 { get; set; }// 0x16
        public int item_id { get; set; }// 0x18
        public byte weapon_evolution_count { get; set; }// 0x1C
        public byte Weapon_upgrade_count { get; set; }// 0x1D
        public List<byte> list_select_type = new List<byte>();// 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            select_group = reader.ReadByte();
            select_type_1 = reader.ReadByte();
            select_type_2 = reader.ReadByte();
            item_id = reader.ReadInt32();
            weapon_evolution_count = reader.ReadByte();
            Weapon_upgrade_count = reader.ReadByte();
            return true;
        }
    }
    public class DBSequenceRow
    {
        public int id { get; set; } // 0x10
        public string array_Basepoint_npc_id { get; set; } // 0x18
        public List<int> list_array_Basepoint_npc_id = new List<int>(); // 0x20
        public string event_spawn_point_type { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            //array_Basepoint_npc_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_Basepoint_npc_id.Add(reader.ReadInt32());
                v0--;
            }
            event_spawn_point_type = reader.ReadString();
            return true;
        }
    }
    public class DBSetCostumeRow
    {
        public int id { get; set; } // 0x10
        public string set_costume_name { get; set; } // 0x18
        public int hero_group { get; set; } // 0x20
        public int set_costume_base { get; set; } // 0x24
        public int set_costume_weapon { get; set; } // 0x28
        public int set_costume_head { get; set; } // 0x2C
        public int normal_attack_sfx_id { get; set; } // 0x30
        public int critical_attack_sfx_id { get; set; } // 0x34
        public string set_passive_type { get; set; } // 0x38
        public int set_passive_id { get; set; } // 0x40
        public string array_event_special_hero_id { get; set; } // 0x48
        public List<int> list_array_event_special_hero_id = new List<int>(); // 0x50
        public string event_special_ani_name { get; set; } // 0x58
        public int event_special_id_1 { get; set; } // 0x60
        public int event_special_id_2 { get; set; } // 0x64
        public int event_special_id_3 { get; set; } // 0x68
        public int event_special_id_4 { get; set; } // 0x6C
        public int event_special_id_5 { get; set; } // 0x70
        public int event_special_id_6 { get; set; } // 0x74
        public List<int> list_event_special_id = new List<int>(); // 0x78
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            set_costume_name = reader.ReadString();
            hero_group = reader.ReadInt32();
            set_costume_base = reader.ReadInt32();
            set_costume_weapon = reader.ReadInt32();
            set_costume_head = reader.ReadInt32();
            normal_attack_sfx_id = reader.ReadInt32();
            critical_attack_sfx_id = reader.ReadInt32();
            set_passive_type = reader.ReadString();
            set_passive_id = reader.ReadInt32();
            //array_event_special_hero_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_event_special_hero_id.Add(reader.ReadInt32());
                v0--;
            }
            event_special_ani_name = reader.ReadString();
            event_special_id_1 = reader.ReadInt32();
            event_special_id_2 = reader.ReadInt32();
            event_special_id_3 = reader.ReadInt32();
            event_special_id_4 = reader.ReadInt32();
            event_special_id_5 = reader.ReadInt32();
            event_special_id_6 = reader.ReadInt32();
            return true;
        }
    }
    public class DBSfxRow
    {
        public int id { get; set; } // 0x10
        public int attach_type { get; set; } // 0x14
        public string create_socket { get; set; } // 0x18
        public string path { get; set; } // 0x20
        public string filename { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            attach_type = reader.ReadInt32();
            create_socket = reader.ReadString();
            path = reader.ReadString();
            filename = reader.ReadString();
            return true;
        }
    }
    public class DBShopConsumeRow
    {
        public int id { get; set; }// 0x10
        public string item_icon_name { get; set; }// 0x18
        public int category { get; set; }// 0x20
        public int item_active { get; set; }// 0x24
        public string consume_type { get; set; }// 0x28
        public int item_id { get; set; }// 0x30
        public int item_count { get; set; }// 0x34
        public int bonus_item_id { get; set; }// 0x38
        public int bonus_item_count { get; set; }// 0x3C
        public int price_item_id { get; set; }// 0x40
        public int price { get; set; }// 0x44
        public int event_on { get; set; }// 0x48
        public string goods_name { get; set; }// 0x50
        public string goods_explain { get; set; }// 0x58
        public string goods_count { get; set; }// 0x60
        public int item_param_index { get; set; }// 0x68
        public string buy_type { get; set; }// 0x70
        public int buy_limited_count { get; set; }// 0x78
        public int bonus_limited_count { get; set; }// 0x7C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            item_icon_name = reader.ReadString();
            category = reader.ReadInt32();
            item_active = reader.ReadInt32();
            consume_type = reader.ReadString();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            bonus_item_id = reader.ReadInt32();
            bonus_item_count = reader.ReadInt32();
            price_item_id = reader.ReadInt32();
            price = reader.ReadInt32();
            event_on = reader.ReadInt32();
            goods_name = reader.ReadString();
            goods_explain = reader.ReadString();
            goods_count = reader.ReadString();
            item_param_index = reader.ReadInt32();
            buy_type = reader.ReadString();
            buy_limited_count = reader.ReadInt32();
            bonus_limited_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBShopMenuRow
    {
        public int id { get; set; } // 0x10
        public string shop_type { get; set; } // 0x18
        public string shop_title { get; set; } // 0x20
        public string shop_desc { get; set; } // 0x28
        public string array_event_key { get; set; } // 0x30
        public List<int> list_array_event_key = new List<int>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            shop_type = reader.ReadString();
            shop_title = reader.ReadString();
            shop_desc = reader.ReadString();
            //array_event_key = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_event_key.Add(reader.ReadInt32());
                v0--;
            }
            return true;
        }
    }
    public class DBShopMoneyRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string shop_type { get; set; } // 0x20
        public int buy_condition { get; set; } // 0x28
        public string item_icon_name { get; set; } // 0x30
        public int item_id { get; set; } // 0x38
        public int item_count { get; set; } // 0x3C
        public int bonus_item_id { get; set; } // 0x40
        public int bonus_count { get; set; } // 0x44
        public string pricetype { get; set; } // 0x48
        public int price_krw { get; set; } // 0x50
        public int price_jpy { get; set; } // 0x54
        public float price_usd { get; set; } // 0x58
        public string netmarble_item_id { get; set; } // 0x60
        public string goods_name { get; set; } // 0x68
        public string goods_explain { get; set; } // 0x70
        public string icon { get; set; } // 0x78
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            shop_type = reader.ReadString();
            buy_condition = reader.ReadInt32();
            item_icon_name = reader.ReadString();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            bonus_item_id = reader.ReadInt32();
            bonus_count = reader.ReadInt32();
            pricetype = reader.ReadString();
            price_krw = reader.ReadInt32();
            price_jpy = reader.ReadInt32();
            price_usd = reader.ReadSingle();
            netmarble_item_id = reader.ReadString();
            goods_name = reader.ReadString();
            goods_explain = reader.ReadString();
            icon = reader.ReadString();
            return true;
        }
    }
    public class DBShopPackageRow
    {
        public int product_id { get; set; } // 0x10
        public int package_index { get; set; } // 0x14
        public string type { get; set; } // 0x18
        public string sub_type { get; set; } // 0x20
        public int step_group { get; set; } // 0x28
        public int contents_type { get; set; } // 0x2C
        public int package_active { get; set; } // 0x30
        public int package_category { get; set; } // 0x34
        public int package_view { get; set; } // 0x38
        public int package_view_index { get; set; } // 0x3C
        public string condition_type { get; set; } // 0x40
        public int condition_value { get; set; } // 0x48
        public int condition_rank { get; set; } // 0x4C
        public string close_type { get; set; } // 0x50
        public int close_value { get; set; } // 0x58
        public int close_rank { get; set; } // 0x5C
        public int package_type { get; set; } // 0x60
        public int give_type { get; set; } // 0x64
        public int product_setup { get; set; } // 0x68
        public string price_type { get; set; } // 0x70
        public int price_count { get; set; } // 0x78
        public int buy_limit { get; set; } // 0x7C
        public string reset_type { get; set; } // 0x80
        public int reset_count { get; set; } // 0x88
        public int reward_package { get; set; } // 0x8C
        public int reward_mail_type { get; set; } // 0x90
        public string package_image_name { get; set; } // 0x98
        public string package_image_name_s { get; set; } // 0xA0
        public string package_large_popup_name { get; set; } // 0xA8
        public string package_icon_name { get; set; } // 0xB0
        public string package_banner_name { get; set; } // 0xB8
        public string package_banner_name_gb { get; set; } // 0xC0
        public string package_banner_name_gb_s { get; set; } // 0xC8
        public string package_banner_name_gb_m { get; set; } // 0xD0
        public string package_name { get; set; } // 0xD8
        public string package_desc { get; set; } // 0xE0
        public int date_check { get; set; } // 0xE8
        public string buy_start_date { get; set; } // 0xF0
        public string buy_end_date { get; set; } // 0xF8
        public bool ReadToStream(BinaryReader reader)
        {
            product_id = reader.ReadInt32();
            package_index = reader.ReadInt32();
            type = reader.ReadString();
            sub_type = reader.ReadString();
            step_group = reader.ReadInt32();
            contents_type = reader.ReadInt32();
            package_active = reader.ReadInt32();
            package_category = reader.ReadInt32();
            package_view = reader.ReadInt32();
            package_view_index = reader.ReadInt32();
            condition_type = reader.ReadString();
            condition_value = reader.ReadInt32();
            condition_rank = reader.ReadInt32();
            close_type = reader.ReadString();
            close_value = reader.ReadInt32();
            close_rank = reader.ReadInt32();
            package_type = reader.ReadInt32();
            give_type = reader.ReadInt32();
            product_setup = reader.ReadInt32();
            price_type = reader.ReadString();
            price_count = reader.ReadInt32();
            buy_limit = reader.ReadInt32();
            reset_type = reader.ReadString();
            reset_count = reader.ReadInt32();
            reward_package = reader.ReadInt32();
            reward_mail_type = reader.ReadInt32();
            package_image_name = reader.ReadString();
            package_image_name_s = reader.ReadString();
            package_large_popup_name = reader.ReadString();
            package_icon_name = reader.ReadString();
            package_banner_name = reader.ReadString();
            package_banner_name_gb = reader.ReadString();
            package_banner_name_gb_s = reader.ReadString();
            package_banner_name_gb_m = reader.ReadString();
            package_name = reader.ReadString();
            package_desc = reader.ReadString();
            date_check = reader.ReadInt32();
            buy_start_date = reader.ReadString();
            buy_end_date = reader.ReadString();
            return true;
        }
    }
    public class DBSituationPackageRow
    {
        public int id { get; set; } // 0x10
        public string situation_type { get; set; } // 0x18
        public int chain_id { get; set; } // 0x20
        public int situation_target_value { get; set; } // 0x24
        public int situation_target_count { get; set; } // 0x28
        public int product_id { get; set; } // 0x2C
        public int situation_active_type { get; set; } // 0x30
        public int situation_active_count { get; set; } // 0x34
        public string situation_reset_type { get; set; } // 0x38
        public int situation_reset_count { get; set; } // 0x40
        public int situation_priority { get; set; } // 0x44
        public string package_image_name_b { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            situation_type = reader.ReadString();
            chain_id = reader.ReadInt32();
            situation_target_value = reader.ReadInt32();
            situation_target_count = reader.ReadInt32();
            product_id = reader.ReadInt32();
            situation_active_type = reader.ReadInt32();
            situation_active_count = reader.ReadInt32();
            situation_reset_type = reader.ReadString();
            situation_reset_count = reader.ReadInt32();
            situation_priority = reader.ReadInt32();
            package_image_name_b = reader.ReadString();
            return true;
        }
    }
    public class DBSkillRetryRow
    {
        public int id { get; set; } // 0x10
        public string matcing_db_name { get; set; } // 0x18
        public int matcing_id_1 { get; set; } // 0x20
        public int check_version { get; set; } // 0x24
        public int retry_on { get; set; } // 0x28
        public List<int> list_matcing_id = new List<int>(); // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            matcing_db_name = reader.ReadString();
            matcing_id_1 = reader.ReadInt32();
            check_version = reader.ReadInt32();
            retry_on = reader.ReadInt32();
            return true;
        }
    }
    public class DBSkinAniRow
    {
        public int id { get; set; } // 0x10
        public string ani_select { get; set; } // 0x18
        public string ani_levelup_1 { get; set; } // 0x20
        public string ani_levelup_2 { get; set; } // 0x28
        public string ani_awaken_1 { get; set; } // 0x30
        public string ani_awaken_2 { get; set; } // 0x38
        public string ani_capacityup_1 { get; set; } // 0x40
        public string ani_capacityup_2 { get; set; } // 0x48
        public string ani_research_1 { get; set; } // 0x50
        public string ani_research_2 { get; set; } // 0x58
        public string ani_item_1 { get; set; } // 0x60
        public string ani_item_2 { get; set; } // 0x68
        public int awaken_neck_ani_check { get; set; } // 0x70
        public List<string> list_ani_levelup = new List<string>(); // 0x78
        public List<string> list_ani_awaken = new List<string>(); // 0x80
        public List<string> list_ani_capacityup = new List<string>(); // 0x88
        public List<string> list_ani_research = new List<string>(); // 0x90
        public List<string> list_ani_item = new List<string>(); // 0x98
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            ani_select = reader.ReadString();
            ani_levelup_1 = reader.ReadString();
            ani_levelup_2 = reader.ReadString();
            ani_awaken_1 = reader.ReadString();
            ani_awaken_2 = reader.ReadString();
            ani_capacityup_1 = reader.ReadString();
            ani_capacityup_2 = reader.ReadString();
            ani_research_1 = reader.ReadString();
            ani_research_2 = reader.ReadString();
            ani_item_1 = reader.ReadString();
            ani_item_2 = reader.ReadString();
            awaken_neck_ani_check = reader.ReadInt32();
            return true;
        }
    }
    public class DBSkinAwakenRow
    {
        public int id { get; set; } // 0x10
        public int skin_awaken_count { get; set; } // 0x14
        public int skin_awaken_level { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            skin_awaken_count = reader.ReadInt32();
            skin_awaken_level = reader.ReadInt32();
            return true;
        }
    }
    public class DBSkinAwakenResourceRow
    {
        public int id { get; set; } // 0x10
        public int hero_id { get; set; } // 0x14
        public int skin_rating { get; set; } // 0x18
        public int skin_awaken_count { get; set; } // 0x1C
        public int awaken_material_id_1 { get; set; } // 0x20
        public int awaken_material_count_1 { get; set; } // 0x24
        public int awaken_material_id_2 { get; set; } // 0x28
        public int awaken_material_count_2 { get; set; } // 0x2C
        public int awaken_material_id_3 { get; set; } // 0x30
        public int awaken_material_count_3 { get; set; } // 0x34
        public int awaken_material_id_4 { get; set; } // 0x38
        public int awaken_material_count_4 { get; set; } // 0x3C
        public int awaken_price_id { get; set; } // 0x40
        public int awaken_price_count { get; set; } // 0x44
        public int weapon_costume_id { get; set; } // 0x48
        public List<int> list_awaken_material_id = new List<int>(); // 0x50
        public List<int> list_awaken_material_count = new List<int>(); // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            hero_id = reader.ReadInt32();
            skin_rating = reader.ReadInt32();
            skin_awaken_count = reader.ReadInt32();
            awaken_material_id_1 = reader.ReadInt32();
            awaken_material_count_1 = reader.ReadInt32();
            awaken_material_id_2 = reader.ReadInt32();
            awaken_material_count_2 = reader.ReadInt32();
            awaken_material_id_3 = reader.ReadInt32();
            awaken_material_count_3 = reader.ReadInt32();
            awaken_material_id_4 = reader.ReadInt32();
            awaken_material_count_4 = reader.ReadInt32();
            awaken_price_id = reader.ReadInt32();
            awaken_price_count = reader.ReadInt32();
            weapon_costume_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBSkinAwakenStatRow
    {
        public int id { get; set; } // 0x10
        public int hero_id { get; set; } // 0x14
        public int skin_rating { get; set; } // 0x18
        public int skin_awaken_count { get; set; } // 0x1C
        public float awaken_add_atk { get; set; } // 0x20
        public float awaken_add_fixed_atk_per { get; set; } // 0x24
        public float awaken_add_crit_per { get; set; } // 0x28
        public float awaken_add_crit_atk_per { get; set; } // 0x2C
        public float awaken_add_def { get; set; } // 0x30
        public float awaken_add_fixed_def_per { get; set; } // 0x34
        public float awaken_add_crit_res_per { get; set; } // 0x38
        public float awaken_add_crit_def_per { get; set; } // 0x3C
        public float awaken_add_hp { get; set; } // 0x40
        public float awaken_add_hp_regen_per { get; set; } // 0x44
        public float awaken_add_hp_recovery_per { get; set; } // 0x48
        public float awaken_add_hp_steal_per { get; set; } // 0x4C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            hero_id = reader.ReadInt32();
            skin_rating = reader.ReadInt32();
            skin_awaken_count = reader.ReadInt32();
            awaken_add_atk = reader.ReadSingle();
            awaken_add_fixed_atk_per = reader.ReadSingle();
            awaken_add_crit_per = reader.ReadSingle();
            awaken_add_crit_atk_per = reader.ReadSingle();
            awaken_add_def = reader.ReadSingle();
            awaken_add_fixed_def_per = reader.ReadSingle();
            awaken_add_crit_res_per = reader.ReadSingle();
            awaken_add_crit_def_per = reader.ReadSingle();
            awaken_add_hp = reader.ReadSingle();
            awaken_add_hp_regen_per = reader.ReadSingle();
            awaken_add_hp_recovery_per = reader.ReadSingle();
            awaken_add_hp_steal_per = reader.ReadSingle();
            return true;
        }
    }
    public class DBSkinBaseRow
    {
        public int id { get; set; } // 0x10
        public string costume_name { get; set; } // 0x18
        public int base_skin_costume_id { get; set; } // 0x20
        public int base_head_costume_id { get; set; } // 0x24
        public int base_weapon_costume_id { get; set; } // 0x28
        public string skin_portrait_base { get; set; } // 0x30
        public int costume_combination { get; set; } // 0x38
        public int skin_category { get; set; } // 0x3C
        public int skin_display { get; set; } // 0x40
        public int skin_combat { get; set; } // 0x44
        public int sort { get; set; } // 0x48
        public int start_rating { get; set; } // 0x4C
        public int rating { get; set; } // 0x50
        public int attribute { get; set; } // 0x54
        public string select_rank_exp { get; set; } // 0x58
        public int level_initializtion { get; set; } // 0x60
        public int max_level { get; set; } // 0x64
        public int evolution_level { get; set; } // 0x68
        public int create_special_score { get; set; } // 0x6C
        public int category_group { get; set; } // 0x70
        public int matching_hero_id { get; set; } // 0x74
        public int hero_coin { get; set; } // 0x78
        public int hero_coin_count { get; set; } // 0x7C
        public float atk { get; set; } // 0x80
        public float fixed_atk_per { get; set; } // 0x84
        public float crit_per { get; set; } // 0x88
        public float crit_atk_per { get; set; } // 0x8C
        public float def { get; set; } // 0x90
        public float fixed_def_per { get; set; } // 0x94
        public float crit_res_per { get; set; } // 0x98
        public float crit_def_per { get; set; } // 0x9C
        public float hp { get; set; } // 0xA0
        public float hp_regen_per { get; set; } // 0xA4
        public float hp_recovery_per { get; set; } // 0xA8
        public float hp_steal_per { get; set; } // 0xAC
        public float atk_add { get; set; } // 0xB0
        public float def_add { get; set; } // 0xB4
        public float hp_add { get; set; } // 0xB8
        public string costume_set_count { get; set; } // 0xC0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            costume_name = reader.ReadString();
            base_skin_costume_id = reader.ReadInt32();
            base_head_costume_id = reader.ReadInt32();
            base_weapon_costume_id = reader.ReadInt32();
            skin_portrait_base = reader.ReadString();
            costume_combination = reader.ReadInt32();
            skin_category = reader.ReadInt32();
            skin_display = reader.ReadInt32();
            skin_combat = reader.ReadInt32();
            sort = reader.ReadInt32();
            start_rating = reader.ReadInt32();
            rating = reader.ReadInt32();
            attribute = reader.ReadInt32();
            select_rank_exp = reader.ReadString();
            level_initializtion = reader.ReadInt32();
            max_level = reader.ReadInt32();
            evolution_level = reader.ReadInt32();
            create_special_score = reader.ReadInt32();
            category_group = reader.ReadInt32();
            matching_hero_id = reader.ReadInt32();
            hero_coin = reader.ReadInt32();
            hero_coin_count = reader.ReadInt32();
            atk = reader.ReadSingle();
            fixed_atk_per = reader.ReadSingle();
            crit_per = reader.ReadSingle();
            crit_atk_per = reader.ReadSingle();
            def = reader.ReadSingle();
            fixed_def_per = reader.ReadSingle();
            crit_res_per = reader.ReadSingle();
            crit_def_per = reader.ReadSingle();
            hp = reader.ReadSingle();
            hp_regen_per = reader.ReadSingle();
            hp_recovery_per = reader.ReadSingle();
            hp_steal_per = reader.ReadSingle();
            atk_add = reader.ReadSingle();
            def_add = reader.ReadSingle();
            hp_add = reader.ReadSingle();
            costume_set_count = reader.ReadString();
            return true;
        }
    }
    public class DBSkinCostumeResourceRow
    {
        public int id { get; set; } // 0x10
        public float attack_range { get; set; } // 0x14
        public float move_speed { get; set; } // 0x18
        public float hero_portrait { get; set; } // 0x1C
        public float hero_camera_offset_y { get; set; } // 0x20
        public string character_base { get; set; } // 0x28
        public int head_error_check { get; set; } // 0x30
        public string resource_body { get; set; } // 0x38
        public int change_head { get; set; } // 0x40
        public string resource_base_head { get; set; } // 0x48
        public string base_head_helm_mixer_name { get; set; } // 0x50
        public string array_weapon_attach_dummy { get; set; } // 0x58
        public List<int> list_array_weapon_attach_dummy = new List<int>(); // 0x60
        public string array_weapon_combi_attach_dummy { get; set; } // 0x68
        public List<int> list_array_weapon_combi_attach_dummy = new List<int>(); // 0x70
        public string ani_directory_name { get; set; } // 0x78
        public int enable_special_sfx { get; set; } // 0x80
        public float sfx_scale { get; set; } // 0x84
        public float model_scale { get; set; } // 0x88
        public float gacha_model_scale { get; set; } // 0x8C
        public string portrait_base { get; set; } // 0x90
        public string check_size { get; set; } // 0x98
        public string victory_prop { get; set; } // 0xA0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            attack_range = reader.ReadSingle();
            move_speed = reader.ReadSingle();
            hero_portrait = reader.ReadSingle();
            hero_camera_offset_y = reader.ReadSingle();
            character_base = reader.ReadString();
            head_error_check = reader.ReadInt32();
            resource_body = reader.ReadString();
            change_head = reader.ReadInt32();
            resource_base_head = reader.ReadString();
            base_head_helm_mixer_name = reader.ReadString();
            //array_weapon_attach_dummy = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_weapon_attach_dummy.Add(reader.ReadInt32());
                v0--;
            }
            //array_weapon_combi_attach_dummy = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_weapon_combi_attach_dummy.Add(reader.ReadInt32());
                v1--;
            }
            ani_directory_name = reader.ReadString();
            enable_special_sfx = reader.ReadInt32();
            sfx_scale = reader.ReadSingle();
            model_scale = reader.ReadSingle();
            gacha_model_scale = reader.ReadSingle();
            portrait_base = reader.ReadString();
            check_size = reader.ReadString();
            victory_prop = reader.ReadString();
            return true;
        }
    }
    public class DBSkinEvolutionRow
    {
        public int id { get; set; } // 0x10
        public int matching_hero_id { get; set; } // 0x14
        public int evolution_break_check { get; set; } // 0x18
        public int evolution_rating { get; set; } // 0x1C
        public int coin_rate { get; set; } // 0x20
        public int evolution_key_id { get; set; } // 0x24
        public int evolution_key_count { get; set; } // 0x28
        public int evolution_material_id_1 { get; set; } // 0x2C
        public int evolution_material_count_1 { get; set; } // 0x30
        public int evolution_material_id_2 { get; set; } // 0x34
        public int evolution_material_count_2 { get; set; } // 0x38
        public int evolution_material_id_3 { get; set; } // 0x3C
        public int evolution_material_count_3 { get; set; } // 0x40
        public int evolution_price_id { get; set; } // 0x44
        public int evolution_price_count { get; set; } // 0x48
        public List<int> list_evolution_material_id = new List<int>(); // 0x50
        public List<int> list_evolution_material_count = new List<int>(); // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            matching_hero_id = reader.ReadInt32();
            evolution_break_check = reader.ReadInt32();
            evolution_rating = reader.ReadInt32();
            coin_rate = reader.ReadInt32();
            evolution_key_id = reader.ReadInt32();
            evolution_key_count = reader.ReadInt32();
            evolution_material_id_1 = reader.ReadInt32();
            evolution_material_count_1 = reader.ReadInt32();
            evolution_material_id_2 = reader.ReadInt32();
            evolution_material_count_2 = reader.ReadInt32();
            evolution_material_id_3 = reader.ReadInt32();
            evolution_material_count_3 = reader.ReadInt32();
            evolution_price_id = reader.ReadInt32();
            evolution_price_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBSkinExclusivePassiveRow
    {
        public int hero_id { get; set; } // 0x10
        public int memorial_stage_id_1 { get; set; } // 0x14
        public int exclusive_passive_id_1 { get; set; } // 0x18
        public int memorial_stage_id_2 { get; set; } // 0x1C
        public int exclusive_passive_id_2 { get; set; } // 0x20
        public int memorial_stage_id_3 { get; set; } // 0x24
        public int exclusive_passive_id_3 { get; set; } // 0x28
        public int taboo_exclusive_passive_id { get; set; } // 0x2C
        public List<int> list_memorial_stage_id = new List<int>(); // 0x30
        public List<int> list_exclusive_passive_id = new List<int>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            hero_id = reader.ReadInt32();
            memorial_stage_id_1 = reader.ReadInt32();
            exclusive_passive_id_1 = reader.ReadInt32();
            memorial_stage_id_2 = reader.ReadInt32();
            exclusive_passive_id_2 = reader.ReadInt32();
            memorial_stage_id_3 = reader.ReadInt32();
            exclusive_passive_id_3 = reader.ReadInt32();
            taboo_exclusive_passive_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBSkinResearchRow
    {
        public int id { get; set; } // 0x10
        public int role_type_1 { get; set; } // 0x14
        public int research_rank { get; set; } // 0x18
        public int passive_skill_id_1 { get; set; } // 0x1C
        public int value_1 { get; set; } // 0x20
        public int passive_skill_id_2 { get; set; } // 0x24
        public int value_2 { get; set; } // 0x28
        public int resource_type { get; set; } // 0x2C
        public int hero_coin_count { get; set; } // 0x30
        public int research_resource_type_1 { get; set; } // 0x34
        public int research_resource_count_1 { get; set; } // 0x38
        public int research_resource_type_2 { get; set; } // 0x3C
        public int research_resource_count_2 { get; set; } // 0x40
        public int research_resource_type_3 { get; set; } // 0x44
        public int research_resource_count_3 { get; set; } // 0x48
        public int research_resource_type_4 { get; set; } // 0x4C
        public int research_resource_count_4 { get; set; } // 0x50
        public int research_resource_type_5 { get; set; } // 0x54
        public int research_resource_count_5 { get; set; } // 0x58
        public int research_resource_type_6 { get; set; } // 0x5C
        public int research_resource_count_6 { get; set; } // 0x60
        public int research_need_gold { get; set; } // 0x64
        public List<int> list_role_type = new List<int>(); // 0x68
        public List<int> list_passive_skill_id = new List<int>(); // 0x70
        public List<int> list_value = new List<int>(); // 0x78
        public List<int> list_research_resource_type = new List<int>(); // 0x80
        public List<int> list_research_resource_count = new List<int>(); // 0x88
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            role_type_1 = reader.ReadInt32();
            research_rank = reader.ReadInt32();
            passive_skill_id_1 = reader.ReadInt32();
            value_1 = reader.ReadInt32();
            passive_skill_id_2 = reader.ReadInt32();
            value_2 = reader.ReadInt32();
            resource_type = reader.ReadInt32();
            hero_coin_count = reader.ReadInt32();
            research_resource_type_1 = reader.ReadInt32();
            research_resource_count_1 = reader.ReadInt32();
            research_resource_type_2 = reader.ReadInt32();
            research_resource_count_2 = reader.ReadInt32();
            research_resource_type_3 = reader.ReadInt32();
            research_resource_count_3 = reader.ReadInt32();
            research_resource_type_4 = reader.ReadInt32();
            research_resource_count_4 = reader.ReadInt32();
            research_resource_type_5 = reader.ReadInt32();
            research_resource_count_5 = reader.ReadInt32();
            research_resource_type_6 = reader.ReadInt32();
            research_resource_count_6 = reader.ReadInt32();
            research_need_gold = reader.ReadInt32();
            return true;
        }
    }
    public class DBSkinSkillRow
    {
        public int id { get; set; } // 0x10
        public int skill_a_1_id { get; set; } // 0x14
        public int skill_a_2_id { get; set; } // 0x18
        public int skill_a_3_id { get; set; } // 0x1C
        public int skill_a_draw_per { get; set; } // 0x20
        public int skill_a_2_logic_cam { get; set; } // 0x24
        public int skill_a_3_logic_cam { get; set; } // 0x28
        public int skill_b_1_id { get; set; } // 0x2C
        public int skill_b_2_id { get; set; } // 0x30
        public int skill_b_3_id { get; set; } // 0x34
        public int skill_b_draw_per { get; set; } // 0x38
        public int skill_b_2_logic_cam { get; set; } // 0x3C
        public int skill_b_3_logic_cam { get; set; } // 0x40
        public int counter_attack_1_id { get; set; } // 0x44
        public int counter_attack_2_id { get; set; } // 0x48
        public int counter_attack_3_id { get; set; } // 0x4C
        public int special_id_1 { get; set; } // 0x50
        public int special_id_2 { get; set; } // 0x54
        public int special_id_3 { get; set; } // 0x58
        public int special_id_4 { get; set; } // 0x5C
        public int special_id_5 { get; set; } // 0x60
        public int special_id_6 { get; set; } // 0x64
        public List<int> list_special_id = new List<int>(); // 0x68
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            skill_a_1_id = reader.ReadInt32();
            skill_a_2_id = reader.ReadInt32();
            skill_a_3_id = reader.ReadInt32();
            skill_a_draw_per = reader.ReadInt32();
            skill_a_2_logic_cam = reader.ReadInt32();
            skill_a_3_logic_cam = reader.ReadInt32();
            skill_b_1_id = reader.ReadInt32();
            skill_b_2_id = reader.ReadInt32();
            skill_b_3_id = reader.ReadInt32();
            skill_b_draw_per = reader.ReadInt32();
            skill_b_2_logic_cam = reader.ReadInt32();
            skill_b_3_logic_cam = reader.ReadInt32();
            counter_attack_1_id = reader.ReadInt32();
            counter_attack_2_id = reader.ReadInt32();
            counter_attack_3_id = reader.ReadInt32();
            special_id_1 = reader.ReadInt32();
            special_id_2 = reader.ReadInt32();
            special_id_3 = reader.ReadInt32();
            special_id_4 = reader.ReadInt32();
            special_id_5 = reader.ReadInt32();
            special_id_6 = reader.ReadInt32();
            return true;
        }
    }
    public class DBSkinSkillLevelupRow
    {
        public int id { get; set; } // 0x10
        public int hero_id { get; set; } // 0x14
        public int special_material_count_1 { get; set; } // 0x18
        public int special_price_id_1 { get; set; } // 0x1C
        public int special_price_count_1 { get; set; } // 0x20
        public int special_material_count_2 { get; set; } // 0x24
        public int special_price_id_2 { get; set; } // 0x28
        public int special_price_count_2 { get; set; } // 0x2C
        public int special_material_count_3 { get; set; } // 0x30
        public int special_price_id_3 { get; set; } // 0x34
        public int special_price_count_3 { get; set; } // 0x38
        public int special_material_count_4 { get; set; } // 0x3C
        public int special_price_id_4 { get; set; } // 0x40
        public int special_price_count_4 { get; set; } // 0x44
        public int special_material_count_5 { get; set; } // 0x48
        public int special_price_id_5 { get; set; } // 0x4C
        public int special_price_count_5 { get; set; } // 0x50
        public int special_material_count_6 { get; set; } // 0x54
        public int special_price_id_6 { get; set; } // 0x58
        public int special_price_count_6 { get; set; } // 0x5C
        public List<int> list_special_material_count = new List<int>(); // 0x60
        public List<int> list_special_price_id = new List<int>(); // 0x68
        public List<int> list_special_price_count = new List<int>(); // 0x70
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            hero_id = reader.ReadInt32();
            special_material_count_1 = reader.ReadInt32();
            special_price_id_1 = reader.ReadInt32();
            special_price_count_1 = reader.ReadInt32();
            special_material_count_2 = reader.ReadInt32();
            special_price_id_2 = reader.ReadInt32();
            special_price_count_2 = reader.ReadInt32();
            special_material_count_3 = reader.ReadInt32();
            special_price_id_3 = reader.ReadInt32();
            special_price_count_3 = reader.ReadInt32();
            special_material_count_4 = reader.ReadInt32();
            special_price_id_4 = reader.ReadInt32();
            special_price_count_4 = reader.ReadInt32();
            special_material_count_5 = reader.ReadInt32();
            special_price_id_5 = reader.ReadInt32();
            special_price_count_5 = reader.ReadInt32();
            special_material_count_6 = reader.ReadInt32();
            special_price_id_6 = reader.ReadInt32();
            special_price_count_6 = reader.ReadInt32();
            return true;
        }
    }
    public class DBSnsRewardRow
    {
        public int id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int share_count { get; set; } // 0x18
        public int event_type { get; set; } // 0x1C
        public int reward_1 { get; set; } // 0x20
        public int reward_count_1 { get; set; } // 0x24
        public string share_img_name { get; set; } // 0x28
        public string share_desc { get; set; } // 0x30
        public List<int> list_reward = new List<int>(); // 0x38
        public List<int> list_reward_count = new List<int>(); // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            share_count = reader.ReadInt32();
            event_type = reader.ReadInt32();
            reward_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            share_img_name = reader.ReadString();
            share_desc = reader.ReadString();
            return true;
        }
    }
    public class DBSoundRow
    {
        public int id { get; set; } // 0x10
        public string path { get; set; } // 0x18
        public string sub_path { get; set; } // 0x20
        public string filename { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            path = reader.ReadString();
            sub_path = reader.ReadString();
            filename = reader.ReadString();
            return true;
        }
    }
    public class DBStageRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string stage_string { get; set; } // 0x20
        public int essen_hero_setting { get; set; } // 0x28
        public string control_type { get; set; } // 0x30
        public int region { get; set; } // 0x38
        public int index { get; set; } // 0x3C
        public int area { get; set; } // 0x40
        public int side { get; set; } // 0x44
        public int start_quest_id { get; set; } // 0x48
        public int need_quest_id { get; set; } // 0x4C
        public int need_stage_side { get; set; } // 0x50
        public int extra_group_id { get; set; } // 0x54
        public int need_stage_id { get; set; } // 0x58
        public int next_stage_side { get; set; } // 0x5C
        public int next_stage_id { get; set; } // 0x60
        public int start_cut { get; set; } // 0x64
        public int end_cut { get; set; } // 0x68
        public int story_id_1 { get; set; } // 0x6C
        public int story_id_2 { get; set; } // 0x70
        public int story_id_3 { get; set; } // 0x74
        public int need_stamina_item_id { get; set; } // 0x78
        public int need_stamina_count { get; set; } // 0x7C
        public int team_power { get; set; } // 0x80
        public int monster_count { get; set; } // 0x84
        public int monster_atk_inc_per { get; set; } // 0x88
        public int monster_def_inc_per { get; set; } // 0x8C
        public int monster_hp_inc_per { get; set; } // 0x90
        public int monster_level { get; set; } // 0x94
        public int monster_id_1 { get; set; } // 0x98
        public int monster_id_2 { get; set; } // 0x9C
        public int monster_id_3 { get; set; } // 0xA0
        public int monster_id_4 { get; set; } // 0xA4
        public int monster_id_5 { get; set; } // 0xA8
        public int monster_id_6 { get; set; } // 0xAC
        public int is_turn_pivot { get; set; } // 0xB0
        public int set_boss_elite_ui { get; set; } // 0xB4
        public string stage_placement { get; set; } // 0xB8
        public int stage_hero_entry_all { get; set; } // 0xC0
        public int monster_ai_id { get; set; } // 0xC4
        public int boss_atk_inc_per { get; set; } // 0xC8
        public int boss_def_inc_per { get; set; } // 0xCC
        public int boss_hp_inc_per { get; set; } // 0xD0
        public int boss_id_1 { get; set; } // 0xD4
        public int boss_level_1 { get; set; } // 0xD8
        public string array_passive1 { get; set; } // 0xE0
        public List<int> list_array_passive1 = new List<int>(); // 0xE8
        public int boss_id_2 { get; set; } // 0xF0
        public int boss_level_2 { get; set; } // 0xF4
        public string array_passive2 { get; set; } // 0xF8
        public List<int> list_array_passive2 = new List<int>(); // 0x100
        public int boss_id_3 { get; set; } // 0x108
        public int boss_level_3 { get; set; } // 0x10C
        public string array_passive3 { get; set; } // 0x110
        public List<int> list_array_passive3 = new List<int>(); // 0x118
        public int boss_id_4 { get; set; } // 0x120
        public int boss_level_4 { get; set; } // 0x124
        public string array_passive4 { get; set; } // 0x128
        public List<int> list_array_passive4 = new List<int>(); // 0x130
        public int play_boss_spawn { get; set; } // 0x138
        public string boss_entry_type { get; set; } // 0x140
        public string array_ally_passive_id { get; set; } // 0x148
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x150
        public string map_filename { get; set; } // 0x158
        public string spawn_prop_filename { get; set; } // 0x160
        public string change_map_filename { get; set; } // 0x168
        public int bgm_sound_id { get; set; } // 0x170
        public int boss_sound_id { get; set; } // 0x174
        public int user_exp { get; set; } // 0x178
        public int hero_exp { get; set; } // 0x17C
        public int gold_value { get; set; } // 0x180
        public int reward_id_1 { get; set; } // 0x184
        public int reward_value_1 { get; set; } // 0x188
        public int reward_value_box_1 { get; set; } // 0x18C
        public int reward_hero_lv_1 { get; set; } // 0x190
        public int first_reward_id { get; set; } // 0x194
        public int first_reward_value { get; set; } // 0x198
        public int first_reward_hero_lv { get; set; } // 0x19C
        public string EssenCondition_1 { get; set; } // 0x1A0
        public int EssenConditionValue_1 { get; set; } // 0x1A8
        public string EssenCondition_2 { get; set; } // 0x1B0
        public int EssenConditionValue_2 { get; set; } // 0x1B8
        public string EssenCondition_3 { get; set; } // 0x1C0
        public int EssenConditionValue_3 { get; set; } // 0x1C8
        public string EssenCondition_4 { get; set; } // 0x1D0
        public int EssenConditionValue_4 { get; set; } // 0x1D8
        public string BanCondition_1 { get; set; } // 0x1E0
        public int BanConditionValue_1 { get; set; } // 0x1E8
        public string BanCondition_2 { get; set; } // 0x1F0
        public int BanConditionValue_2 { get; set; } // 0x1F8
        public string BanCondition_3 { get; set; } // 0x200
        public int BanConditionValue_3 { get; set; } // 0x208
        public string BanCondition_4 { get; set; } // 0x210
        public int BanConditionValue_4 { get; set; } // 0x218
        public string BanCondition_5 { get; set; } // 0x220
        public int BanConditionValue_5 { get; set; } // 0x228
        public string BanCondition_6 { get; set; } // 0x230
        public int BanConditionValue_6 { get; set; } // 0x238
        public int Hrun_reward_max_value { get; set; } // 0x23C
        public string Hrun_map { get; set; } // 0x240
        public string Hrun_bg { get; set; } // 0x248
        public int npc_team_id { get; set; } // 0x250
        public List<int> list_story_id = new List<int>(); // 0x258
        public List<int> list_monster_id = new List<int>(); // 0x260
        public List<int> list_boss_id = new List<int>(); // 0x268
        public List<int> list_boss_level = new List<int>(); // 0x270
        public List<int> list_reward_id = new List<int>(); // 0x278
        public List<int> list_reward_value = new List<int>(); // 0x280
        public List<int> list_reward_value_box = new List<int>(); // 0x288
        public List<int> list_reward_hero_lv = new List<int>(); // 0x290
        public List<string> list_EssenCondition = new List<string>(); // 0x298
        public List<int> list_EssenConditionValue = new List<int>(); // 0x2A0
        public List<string> list_BanCondition = new List<string>(); // 0x2A8
        public List<int> list_BanConditionValue = new List<int>(); // 0x2B0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            stage_string = reader.ReadString();
            essen_hero_setting = reader.ReadInt32();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            index = reader.ReadInt32();
            area = reader.ReadInt32();
            side = reader.ReadInt32();
            start_quest_id = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            need_stage_side = reader.ReadInt32();
            extra_group_id = reader.ReadInt32();
            need_stage_id = reader.ReadInt32();
            next_stage_side = reader.ReadInt32();
            next_stage_id = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            team_power = reader.ReadInt32();
            monster_count = reader.ReadInt32();
            monster_atk_inc_per = reader.ReadInt32();
            monster_def_inc_per = reader.ReadInt32();
            monster_hp_inc_per = reader.ReadInt32();
            monster_level = reader.ReadInt32();
            monster_id_1 = reader.ReadInt32();
            monster_id_2 = reader.ReadInt32();
            monster_id_3 = reader.ReadInt32();
            monster_id_4 = reader.ReadInt32();
            monster_id_5 = reader.ReadInt32();
            monster_id_6 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            set_boss_elite_ui = reader.ReadInt32();
            stage_placement = reader.ReadString();
            stage_hero_entry_all = reader.ReadInt32();
            monster_ai_id = reader.ReadInt32();
            boss_atk_inc_per = reader.ReadInt32();
            boss_def_inc_per = reader.ReadInt32();
            boss_hp_inc_per = reader.ReadInt32();
            boss_id_1 = reader.ReadInt32();
            boss_level_1 = reader.ReadInt32();
            //array_passive1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v0--;
            }
            boss_id_2 = reader.ReadInt32();
            boss_level_2 = reader.ReadInt32();
            //array_passive2 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v1--;
            }
            boss_id_3 = reader.ReadInt32();
            boss_level_3 = reader.ReadInt32();
            //array_passive3 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v2--;
            }
            boss_id_4 = reader.ReadInt32();
            boss_level_4 = reader.ReadInt32();
            //array_passive4 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_passive4.Add(reader.ReadInt32());
                v3--;
            }
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v4--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_value_1 = reader.ReadInt32();
            reward_value_box_1 = reader.ReadInt32();
            reward_hero_lv_1 = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            first_reward_hero_lv = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            Hrun_reward_max_value = reader.ReadInt32();
            Hrun_map = reader.ReadString();
            Hrun_bg = reader.ReadString();
            npc_team_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageBossRow
    {
        public int id { get; set; }// 0x10
        public string type { get; set; }// 0x18
        public string stage_string { get; set; }// 0x20
        public string control_type { get; set; }// 0x28
        public int limit_index { get; set; }// 0x30
        public int region { get; set; }// 0x34
        public int boss_index { get; set; }// 0x38
        public int area { get; set; }// 0x3C
        public int extra_group_id { get; set; }// 0x40
        public int need_quest_id { get; set; }// 0x44
        public int need_stage_id { get; set; }// 0x48
        public int next_stage_id { get; set; }// 0x4C
        public int difficulty { get; set; }// 0x50
        public string difficulty_string { get; set; }// 0x58
        public int destroy_gauge_min { get; set; }// 0x60
        public int destroy_gauge_max { get; set; }// 0x64
        public int destroy_gauge_unit { get; set; }// 0x68
        public int destroy_gauge_bonus { get; set; }// 0x6C
        public int start_cut { get; set; }// 0x70
        public int end_cut { get; set; }// 0x74
        public int story_id_1 { get; set; }// 0x78
        public int story_id_2 { get; set; }// 0x7C
        public int story_id_3 { get; set; }// 0x80
        public int team_power { get; set; }// 0x84
        public int need_stamina_item_id { get; set; }// 0x88
        public int need_stamina_count { get; set; }// 0x8C
        public int user_exp { get; set; }// 0x90
        public int hero_exp { get; set; }// 0x94
        public int gold_value { get; set; }// 0x98
        public int first_reward_id { get; set; }// 0x9C
        public int first_reward_value { get; set; }// 0xA0
        public int first_evolution_count { get; set; }// 0xA4
        public int drop_item_boss_min_count { get; set; }// 0xA8
        public int drop_item_boss_max_count { get; set; }// 0xAC
        public int monster_material_per { get; set; }// 0xB0
        public int drop_item_id_1 { get; set; }// 0xB4
        public int drop_item_value_1 { get; set; }// 0xB8
        public int drop_item_evolution_count_1 { get; set; }// 0xBC
        public int drop_item_per_1 { get; set; }// 0xC0
        public int drop_item_box_1 { get; set; }// 0xC4
        public int drop_item_id_2 { get; set; }// 0xC8
        public int drop_item_value_2 { get; set; }// 0xCC
        public int drop_item_evolution_count_2 { get; set; }// 0xD0
        public int drop_item_per_2 { get; set; }// 0xD4
        public int drop_item_box_2 { get; set; }// 0xD8
        public int drop_item_id_3 { get; set; }// 0xDC
        public int drop_item_value_3 { get; set; }// 0xE0
        public int drop_item_evolution_count_3 { get; set; }// 0xE4
        public int drop_item_per_3 { get; set; }// 0xE8
        public int drop_item_box_3 { get; set; }// 0xEC
        public int drop_item_id_4 { get; set; }// 0xF0
        public int drop_item_value_4 { get; set; }// 0xF4
        public int drop_item_evolution_count_4 { get; set; }// 0xF8
        public int drop_item_per_4 { get; set; }// 0xFC
        public int drop_item_box_4 { get; set; }// 0x100
        public int drop_item_id_5 { get; set; }// 0x104
        public int drop_item_value_5 { get; set; }// 0x108
        public int drop_item_evolution_count_5 { get; set; }// 0x10C
        public int drop_item_per_5 { get; set; }// 0x110
        public int drop_item_box_5 { get; set; }// 0x114
        public int drop_item_id_6 { get; set; }// 0x118
        public int drop_item_value_6 { get; set; }// 0x11C
        public int drop_item_evolution_count_6 { get; set; }// 0x120
        public int drop_item_per_6 { get; set; }// 0x124
        public int drop_item_box_6 { get; set; }// 0x128
        public int drop_item_id_7 { get; set; }// 0x12C
        public int drop_item_value_7 { get; set; }// 0x130
        public int drop_item_evolution_count_7 { get; set; }// 0x134
        public int drop_item_per_7 { get; set; }// 0x138
        public int drop_item_box_7 { get; set; }// 0x13C
        public int drop_item_id_8 { get; set; }// 0x140
        public int drop_item_value_8 { get; set; }// 0x144
        public int drop_item_evolution_count_8 { get; set; }// 0x148
        public int drop_item_per_8 { get; set; }// 0x14C
        public int drop_item_box_8 { get; set; }// 0x150
        public int drop_item_id_9 { get; set; }// 0x154
        public int drop_item_value_9 { get; set; }// 0x158
        public int drop_item_evolution_count_9 { get; set; }// 0x15C
        public int drop_item_per_9 { get; set; }// 0x160
        public int drop_item_box_9 { get; set; }// 0x164
        public int drop_item_id_10 { get; set; }// 0x168
        public int drop_item_value_10 { get; set; }// 0x16C
        public int drop_item_evolution_count_10 { get; set; }// 0x170
        public int drop_item_per_10 { get; set; }// 0x174
        public int drop_item_box_10 { get; set; }// 0x178
        public int drop_item_id_11 { get; set; }// 0x17C
        public int drop_item_value_11 { get; set; }// 0x180
        public int drop_item_evolution_count_11 { get; set; }// 0x184
        public int drop_item_per_11 { get; set; }// 0x188
        public int drop_item_box_11 { get; set; }// 0x18C
        public int drop_item_id_12 { get; set; }// 0x190
        public int drop_item_value_12 { get; set; }// 0x194
        public int drop_item_evolution_count_12 { get; set; }// 0x198
        public int drop_item_per_12 { get; set; }// 0x19C
        public int drop_item_box_12 { get; set; }// 0x1A0
        public int drop_item_id_13 { get; set; }// 0x1A4
        public int drop_item_value_13 { get; set; }// 0x1A8
        public int drop_item_evolution_count_13 { get; set; }// 0x1AC
        public int drop_item_per_13 { get; set; }// 0x1B0
        public int drop_item_box_13 { get; set; }// 0x1B4
        public int drop_item_id_14 { get; set; }// 0x1B8
        public int drop_item_value_14 { get; set; }// 0x1BC
        public int drop_item_evolution_count_14 { get; set; }// 0x1C0
        public int drop_item_per_14 { get; set; }// 0x1C4
        public int drop_item_box_14 { get; set; }// 0x1C8
        public int drop_item_id_15 { get; set; }// 0x1CC
        public int drop_item_value_15 { get; set; }// 0x1D0
        public int drop_item_evolution_count_15 { get; set; }// 0x1D4
        public int drop_item_per_15 { get; set; }// 0x1D8
        public int drop_item_box_15 { get; set; }// 0x1DC
        public int is_turn_pivot { get; set; }// 0x1E0
        public int set_boss_elite_ui { get; set; }// 0x1E4
        public string stage_placement { get; set; }// 0x1E8
        public int stage_hero_entry_all { get; set; }// 0x1F0
        public int monster_ai_id { get; set; }// 0x1F4
        public int boss_atk_inc_per { get; set; }// 0x1F8
        public int boss_def_inc_per { get; set; }// 0x1FC
        public int boss_hp_inc_per { get; set; }// 0x200
        public int boss_id_1 { get; set; }// 0x204
        public int boss_level_1 { get; set; }// 0x208
        public List<int> list_array_passive1 = new List<int>();// 0x210
        public int boss_material_box_1 { get; set; }// 0x218
        public int boss_id_2 { get; set; }// 0x21C
        public int boss_level_2 { get; set; }// 0x220
        public List<int> list_array_passive2 = new List<int>();// 0x228
        public int boss_material_box_2 { get; set; }// 0x230
        public int boss_id_3 { get; set; }// 0x234
        public int boss_level_3 { get; set; }// 0x238
        public List<int> list_array_passive3 = new List<int>();// 0x240
        public int boss_material_box_3 { get; set; }// 0x248
        public int boss_id_4 { get; set; }// 0x24C
        public int boss_level_4 { get; set; }// 0x250
        public List<int> list_array_passive4 = new List<int>();// 0x258
        public int boss_material_box_4 { get; set; }// 0x260
        public int play_boss_spawn { get; set; }// 0x264
        public string boss_entry_type { get; set; }// 0x268
        public List<int> list_array_ally_passive_id = new List<int>();// 0x270
        public string map_filename { get; set; }// 0x278
        public string spawn_prop_filename { get; set; }// 0x280
        public string change_map_filename { get; set; }// 0x288
        public int bgm_sound_id { get; set; }// 0x290
        public int boss_sound_id { get; set; }// 0x294
        public string EssenCondition_1 { get; set; }// 0x298
        public int EssenConditionValue_1 { get; set; }// 0x2A0
        public string EssenCondition_2 { get; set; }// 0x2A8
        public int EssenConditionValue_2 { get; set; }// 0x2B0
        public string EssenCondition_3 { get; set; }// 0x2B8
        public int EssenConditionValue_3 { get; set; }// 0x2C0
        public string EssenCondition_4 { get; set; }// 0x2C8
        public int EssenConditionValue_4 { get; set; }// 0x2D0
        public string BanCondition_1 { get; set; }// 0x2D8
        public int BanConditionValue_1 { get; set; }// 0x2E0
        public string BanCondition_2 { get; set; }// 0x2E8
        public int BanConditionValue_2 { get; set; }// 0x2F0
        public string BanCondition_3 { get; set; }// 0x2F8
        public int BanConditionValue_3 { get; set; }// 0x300
        public string BanCondition_4 { get; set; }// 0x308
        public int BanConditionValue_4 { get; set; }// 0x310
        public string BanCondition_5 { get; set; }// 0x318
        public int BanConditionValue_5 { get; set; }// 0x320
        public string BanCondition_6 { get; set; }// 0x328
        public int BanConditionValue_6 { get; set; }// 0x330
        public int npc_team_id { get; set; }// 0x334
        public int season_group { get; set; }// 0x338
        public List<int> list_story_id = new List<int>();// 0x340
        public List<int> list_drop_item_id = new List<int>();// 0x348
        public List<int> list_drop_item_value = new List<int>();// 0x350
        public List<int> list_drop_item_evolution_count = new List<int>();// 0x358
        public List<int> list_drop_item_per = new List<int>();// 0x360
        public List<int> list_drop_item_box = new List<int>();// 0x368
        public List<int> list_boss_id = new List<int>();// 0x370
        public List<int> list_boss_level = new List<int>();// 0x378
        public List<int> list_boss_material_box = new List<int>();// 0x380
        public List<string> list_EssenCondition = new List<string>();// 0x388
        public List<int> list_EssenConditionValue = new List<int>();// 0x390
        public List<string> list_BanCondition = new List<string>();// 0x398
        public List<int> list_BanConditionValue = new List<int>();// 0x3A0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            stage_string = reader.ReadString();
            control_type = reader.ReadString();
            limit_index = reader.ReadInt32();
            region = reader.ReadInt32();
            boss_index = reader.ReadInt32();
            area = reader.ReadInt32();
            extra_group_id = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            need_stage_id = reader.ReadInt32();
            next_stage_id = reader.ReadInt32();
            difficulty = reader.ReadInt32();
            difficulty_string = reader.ReadString();
            destroy_gauge_min = reader.ReadInt32();
            destroy_gauge_max = reader.ReadInt32();
            destroy_gauge_unit = reader.ReadInt32();
            destroy_gauge_bonus = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            team_power = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            first_evolution_count = reader.ReadInt32();
            drop_item_boss_min_count = reader.ReadInt32();
            drop_item_boss_max_count = reader.ReadInt32();
            monster_material_per = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_item_value_1 = reader.ReadInt32();
            drop_item_evolution_count_1 = reader.ReadInt32();
            drop_item_per_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_item_value_2 = reader.ReadInt32();
            drop_item_evolution_count_2 = reader.ReadInt32();
            drop_item_per_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_item_value_3 = reader.ReadInt32();
            drop_item_evolution_count_3 = reader.ReadInt32();
            drop_item_per_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            drop_item_id_4 = reader.ReadInt32();
            drop_item_value_4 = reader.ReadInt32();
            drop_item_evolution_count_4 = reader.ReadInt32();
            drop_item_per_4 = reader.ReadInt32();
            drop_item_box_4 = reader.ReadInt32();
            drop_item_id_5 = reader.ReadInt32();
            drop_item_value_5 = reader.ReadInt32();
            drop_item_evolution_count_5 = reader.ReadInt32();
            drop_item_per_5 = reader.ReadInt32();
            drop_item_box_5 = reader.ReadInt32();
            drop_item_id_6 = reader.ReadInt32();
            drop_item_value_6 = reader.ReadInt32();
            drop_item_evolution_count_6 = reader.ReadInt32();
            drop_item_per_6 = reader.ReadInt32();
            drop_item_box_6 = reader.ReadInt32();
            drop_item_id_7 = reader.ReadInt32();
            drop_item_value_7 = reader.ReadInt32();
            drop_item_evolution_count_7 = reader.ReadInt32();
            drop_item_per_7 = reader.ReadInt32();
            drop_item_box_7 = reader.ReadInt32();
            drop_item_id_8 = reader.ReadInt32();
            drop_item_value_8 = reader.ReadInt32();
            drop_item_evolution_count_8 = reader.ReadInt32();
            drop_item_per_8 = reader.ReadInt32();
            drop_item_box_8 = reader.ReadInt32();
            drop_item_id_9 = reader.ReadInt32();
            drop_item_value_9 = reader.ReadInt32();
            drop_item_evolution_count_9 = reader.ReadInt32();
            drop_item_per_9 = reader.ReadInt32();
            drop_item_box_9 = reader.ReadInt32();
            drop_item_id_10 = reader.ReadInt32();
            drop_item_value_10 = reader.ReadInt32();
            drop_item_evolution_count_10 = reader.ReadInt32();
            drop_item_per_10 = reader.ReadInt32();
            drop_item_box_10 = reader.ReadInt32();
            drop_item_id_11 = reader.ReadInt32();
            drop_item_value_11 = reader.ReadInt32();
            drop_item_evolution_count_11 = reader.ReadInt32();
            drop_item_per_11 = reader.ReadInt32();
            drop_item_box_11 = reader.ReadInt32();
            drop_item_id_12 = reader.ReadInt32();
            drop_item_value_12 = reader.ReadInt32();
            drop_item_evolution_count_12 = reader.ReadInt32();
            drop_item_per_12 = reader.ReadInt32();
            drop_item_box_12 = reader.ReadInt32();
            drop_item_id_13 = reader.ReadInt32();
            drop_item_value_13 = reader.ReadInt32();
            drop_item_evolution_count_13 = reader.ReadInt32();
            drop_item_per_13 = reader.ReadInt32();
            drop_item_box_13 = reader.ReadInt32();
            drop_item_id_14 = reader.ReadInt32();
            drop_item_value_14 = reader.ReadInt32();
            drop_item_evolution_count_14 = reader.ReadInt32();
            drop_item_per_14 = reader.ReadInt32();
            drop_item_box_14 = reader.ReadInt32();
            drop_item_id_15 = reader.ReadInt32();
            drop_item_value_15 = reader.ReadInt32();
            drop_item_evolution_count_15 = reader.ReadInt32();
            drop_item_per_15 = reader.ReadInt32();
            drop_item_box_15 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            set_boss_elite_ui = reader.ReadInt32();
            stage_placement = reader.ReadString();
            stage_hero_entry_all = reader.ReadInt32();
            monster_ai_id = reader.ReadInt32();
            boss_atk_inc_per = reader.ReadInt32();
            boss_def_inc_per = reader.ReadInt32();
            boss_hp_inc_per = reader.ReadInt32();
            boss_id_1 = reader.ReadInt32();
            boss_level_1 = reader.ReadInt32();
            //array_passive1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v0--;
            }
            boss_material_box_1 = reader.ReadInt32();
            boss_id_2 = reader.ReadInt32();
            boss_level_2 = reader.ReadInt32();
            //array_passive2 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v1--;
            }
            boss_material_box_2 = reader.ReadInt32();
            boss_id_3 = reader.ReadInt32();
            boss_level_3 = reader.ReadInt32();
            //array_passive3 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v2--;
            }
            boss_material_box_3 = reader.ReadInt32();
            boss_id_4 = reader.ReadInt32();
            boss_level_4 = reader.ReadInt32();
            //array_passive4 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_passive4.Add(reader.ReadInt32());
                v3--;
            }
            boss_material_box_4 = reader.ReadInt32();
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v4--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            npc_team_id = reader.ReadInt32();
            season_group = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageBossDestroyRow
    {
        public int region { get; set; } // 0x10
        public int limit_count { get; set; } // 0x14
        public string array_destroy_group { get; set; } // 0x18
        public List<int> list_array_destroy_group = new List<int>(); // 0x20
        public string array_destroy_group_rate { get; set; } // 0x28
        public List<int> list_array_destroy_group_rate = new List<int>(); // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            region = reader.ReadInt32();
            limit_count = reader.ReadInt32();
            //array_destroy_group = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_destroy_group.Add(reader.ReadInt32());
                v0--;
            }
            //array_destroy_group_rate = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_destroy_group_rate.Add(reader.ReadInt32());
                v1--;
            }
            return true;
        }
    }
    public class DBStageChallengeBossRow
    {
        public int id { get; set; } // 0x10
        public int group_id { get; set; } // 0x14
        public string type { get; set; } // 0x18
        public string control_type { get; set; } // 0x20
        public string stage_string { get; set; } // 0x28
        public int region { get; set; } // 0x30
        public int area { get; set; } // 0x34
        public int destroy_index { get; set; } // 0x38
        public int need_quest_id { get; set; } // 0x3C
        public string need_stage_type { get; set; } // 0x40
        public int need_stage_id { get; set; } // 0x48
        public int difficulty { get; set; } // 0x4C
        public int difficulty_lock { get; set; } // 0x50
        public string difficulty_string { get; set; } // 0x58
        public string info_image { get; set; } // 0x60
        public string info_guide { get; set; } // 0x68
        public int bgm_sound_id_1 { get; set; } // 0x70
        public int ambient_sound_id_1 { get; set; } // 0x74
        public int bgm_sound_id_2 { get; set; } // 0x78
        public int ambient_sound_id_2 { get; set; } // 0x7C
        public int start_cut { get; set; } // 0x80
        public int end_cut { get; set; } // 0x84
        public int story_id_1 { get; set; } // 0x88
        public int story_id_2 { get; set; } // 0x8C
        public int story_id_3 { get; set; } // 0x90
        public int need_stamina_item_id { get; set; } // 0x94
        public int need_stamina_count { get; set; } // 0x98
        public int user_exp { get; set; } // 0x9C
        public int hero_exp { get; set; } // 0xA0
        public int guild_exp { get; set; } // 0xA4
        public int guild_skill_point { get; set; } // 0xA8
        public int guild_donation { get; set; } // 0xAC
        public int group_item_rate_add { get; set; } // 0xB0
        public int drop_item_boss_min_count { get; set; } // 0xB4
        public int drop_item_boss_max_count { get; set; } // 0xB8
        public int monster_material_per { get; set; } // 0xBC
        public int drop_item_id_1 { get; set; } // 0xC0
        public int drop_item_value_1 { get; set; } // 0xC4
        public int drop_item_evolution_count_1 { get; set; } // 0xC8
        public int drop_item_per_1 { get; set; } // 0xCC
        public int drop_item_box_1 { get; set; } // 0xD0
        public int drop_item_id_2 { get; set; } // 0xD4
        public int drop_item_value_2 { get; set; } // 0xD8
        public int drop_item_evolution_count_2 { get; set; } // 0xDC
        public int drop_item_per_2 { get; set; } // 0xE0
        public int drop_item_box_2 { get; set; } // 0xE4
        public int drop_item_id_3 { get; set; } // 0xE8
        public int drop_item_value_3 { get; set; } // 0xEC
        public int drop_item_evolution_count_3 { get; set; } // 0xF0
        public int drop_item_per_3 { get; set; } // 0xF4
        public int drop_item_box_3 { get; set; } // 0xF8
        public int drop_item_id_4 { get; set; } // 0xFC
        public int drop_item_value_4 { get; set; } // 0x100
        public int drop_item_evolution_count_4 { get; set; } // 0x104
        public int drop_item_per_4 { get; set; } // 0x108
        public int drop_item_box_4 { get; set; } // 0x10C
        public int drop_item_id_5 { get; set; } // 0x110
        public int drop_item_value_5 { get; set; } // 0x114
        public int drop_item_evolution_count_5 { get; set; } // 0x118
        public int drop_item_per_5 { get; set; } // 0x11C
        public int drop_item_box_5 { get; set; } // 0x120
        public int drop_item_id_6 { get; set; } // 0x124
        public int drop_item_value_6 { get; set; } // 0x128
        public int drop_item_evolution_count_6 { get; set; } // 0x12C
        public int drop_item_per_6 { get; set; } // 0x130
        public int drop_item_box_6 { get; set; } // 0x134
        public int drop_item_id_7 { get; set; } // 0x138
        public int drop_item_value_7 { get; set; } // 0x13C
        public int drop_item_evolution_count_7 { get; set; } // 0x140
        public int drop_item_per_7 { get; set; } // 0x144
        public int drop_item_box_7 { get; set; } // 0x148
        public int drop_item_id_8 { get; set; } // 0x14C
        public int drop_item_value_8 { get; set; } // 0x150
        public int drop_item_evolution_count_8 { get; set; } // 0x154
        public int drop_item_per_8 { get; set; } // 0x158
        public int drop_item_box_8 { get; set; } // 0x15C
        public int drop_item_id_9 { get; set; } // 0x160
        public int drop_item_value_9 { get; set; } // 0x164
        public int drop_item_evolution_count_9 { get; set; } // 0x168
        public int drop_item_per_9 { get; set; } // 0x16C
        public int drop_item_box_9 { get; set; } // 0x170
        public int drop_item_id_10 { get; set; } // 0x174
        public int drop_item_value_10 { get; set; } // 0x178
        public int drop_item_evolution_count_10 { get; set; } // 0x17C
        public int drop_item_per_10 { get; set; } // 0x180
        public int drop_item_box_10 { get; set; } // 0x184
        public int drop_item_id_11 { get; set; } // 0x188
        public int drop_item_value_11 { get; set; } // 0x18C
        public int drop_item_evolution_count_11 { get; set; } // 0x190
        public int drop_item_per_11 { get; set; } // 0x194
        public int drop_item_box_11 { get; set; } // 0x198
        public int drop_item_id_12 { get; set; } // 0x19C
        public int drop_item_value_12 { get; set; } // 0x1A0
        public int drop_item_evolution_count_12 { get; set; } // 0x1A4
        public int drop_item_per_12 { get; set; } // 0x1A8
        public int drop_item_box_12 { get; set; } // 0x1AC
        public int drop_item_id_13 { get; set; } // 0x1B0
        public int drop_item_value_13 { get; set; } // 0x1B4
        public int drop_item_evolution_count_13 { get; set; } // 0x1B8
        public int drop_item_per_13 { get; set; } // 0x1BC
        public int drop_item_box_13 { get; set; } // 0x1C0
        public int drop_item_id_14 { get; set; } // 0x1C4
        public int drop_item_value_14 { get; set; } // 0x1C8
        public int drop_item_evolution_count_14 { get; set; } // 0x1CC
        public int drop_item_per_14 { get; set; } // 0x1D0
        public int drop_item_box_14 { get; set; } // 0x1D4
        public int drop_item_id_15 { get; set; } // 0x1D8
        public int drop_item_value_15 { get; set; } // 0x1DC
        public int drop_item_evolution_count_15 { get; set; } // 0x1E0
        public int drop_item_per_15 { get; set; } // 0x1E4
        public int drop_item_box_15 { get; set; } // 0x1E8
        public int drop_item_id_16 { get; set; } // 0x1EC
        public int drop_item_value_16 { get; set; } // 0x1F0
        public int drop_item_evolution_count_16 { get; set; } // 0x1F4
        public int drop_item_per_16 { get; set; } // 0x1F8
        public int drop_item_box_16 { get; set; } // 0x1FC
        public int drop_item_id_17 { get; set; } // 0x200
        public int drop_item_value_17 { get; set; } // 0x204
        public int drop_item_evolution_count_17 { get; set; } // 0x208
        public int drop_item_per_17 { get; set; } // 0x20C
        public int drop_item_box_17 { get; set; } // 0x210
        public int drop_item_id_18 { get; set; } // 0x214
        public int drop_item_value_18 { get; set; } // 0x218
        public int drop_item_evolution_count_18 { get; set; } // 0x21C
        public int drop_item_per_18 { get; set; } // 0x220
        public int drop_item_box_18 { get; set; } // 0x224
        public string stage_placement { get; set; } // 0x228
        public string situation_behavior_tree_name { get; set; } // 0x230
        public List<int> list_array_destroy_tag = new List<int>(); // 0x238
        public int phase1_boss_atk_inc_per { get; set; } // 0x240
        public int phase1_boss_def_inc_per { get; set; } // 0x244
        public int phase1_boss_hp_inc_per { get; set; } // 0x248
        public int phase1_boss_id_1 { get; set; } // 0x24C
        public int phase1_boss_level_1 { get; set; } // 0x250
        public List<int> list_phase1_array_passive1 = new List<int>(); // 0x258
        public int phase1_boss_material_box_1 { get; set; } // 0x260
        public int phase1_boss_id_2 { get; set; } // 0x264
        public int phase1_boss_level_2 { get; set; } // 0x268
        public List<int> list_phase1_array_passive2 = new List<int>(); // 0x270
        public int phase1_boss_material_box_2 { get; set; } // 0x278
        public int phase1_boss_id_3 { get; set; } // 0x27C
        public int phase1_boss_level_3 { get; set; } // 0x280
        public List<int> list_phase1_array_passive3 = new List<int>(); // 0x288
        public int phase1_boss_material_box_3 { get; set; } // 0x290
        public int phase2_boss_atk_inc_per { get; set; } // 0x294
        public int phase2_boss_def_inc_per { get; set; } // 0x298
        public int phase2_boss_hp_inc_per { get; set; } // 0x29C
        public int phase2_boss_id_1 { get; set; } // 0x2A0
        public int phase2_boss_level_1 { get; set; } // 0x2A4
        public int phase2_boss_skill_level_1 { get; set; } // 0x2A8
        public int phase2_boss_material_box_1 { get; set; } // 0x2AC
        public List<int> list_phase2_array_passive1 = new List<int>(); // 0x2B0
        public int phase2_boss_id_2 { get; set; } // 0x2B8
        public int phase2_boss_level_2 { get; set; } // 0x2BC
        public List<int> list_phase2_array_passive2 = new List<int>(); // 0x2C0
        public int phase2_boss_material_box_2 { get; set; } // 0x2C8
        public int phase2_boss_id_3 { get; set; } // 0x2CC
        public int phase2_boss_level_3 { get; set; } // 0x2D0
        public List<int> list_phase2_array_passive3 = new List<int>(); // 0x2D8
        public int phase2_boss_material_box_3 { get; set; } // 0x2E0
        public int play_boss_spawn { get; set; } // 0x2E4
        public string boss_entry_type { get; set; } // 0x2E8
        public int team_power { get; set; } // 0x2F0
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x2F8
        public string map_filename { get; set; } // 0x300
        public string spawn_prop_filename { get; set; } // 0x308
        public string change_map_filename { get; set; } // 0x310
        public int bgm_sound_id { get; set; } // 0x318
        public int boss_sound_id { get; set; } // 0x31C
        public string EssenCondition_1 { get; set; } // 0x320
        public int EssenConditionValue_1 { get; set; } // 0x328
        public string EssenCondition_2 { get; set; } // 0x330
        public int EssenConditionValue_2 { get; set; } // 0x338
        public string EssenCondition_3 { get; set; } // 0x340
        public int EssenConditionValue_3 { get; set; } // 0x348
        public string EssenCondition_4 { get; set; } // 0x350
        public int EssenConditionValue_4 { get; set; } // 0x358
        public string BanCondition_1 { get; set; } // 0x360
        public int BanConditionValue_1 { get; set; } // 0x368
        public string BanCondition_2 { get; set; } // 0x370
        public int BanConditionValue_2 { get; set; } // 0x378
        public string BanCondition_3 { get; set; } // 0x380
        public int BanConditionValue_3 { get; set; } // 0x388
        public string BanCondition_4 { get; set; } // 0x390
        public int BanConditionValue_4 { get; set; } // 0x398
        public string BanCondition_5 { get; set; } // 0x3A0
        public int BanConditionValue_5 { get; set; } // 0x3A8
        public string BanCondition_6 { get; set; } // 0x3B0
        public int BanConditionValue_6 { get; set; } // 0x3B8
        public int season_id { get; set; } // 0x3BC
        public int season_group { get; set; } // 0x3C0
        public List<int> list_bgm_sound_id = new List<int>(); // 0x3C8
        public List<int> list_ambient_sound_id = new List<int>(); // 0x3D0
        public List<int> list_story_id = new List<int>(); // 0x3D8
        public List<int> list_drop_item_id = new List<int>(); // 0x3E0
        public List<int> list_drop_item_value = new List<int>(); // 0x3E8
        public List<int> list_drop_item_evolution_count = new List<int>(); // 0x3F0
        public List<int> list_drop_item_per = new List<int>(); // 0x3F8
        public List<int> list_drop_item_box = new List<int>(); // 0x400
        public List<int> list_phase1_boss_id = new List<int>(); // 0x408
        public List<int> list_phase1_boss_level = new List<int>(); // 0x410
        public List<int> list_phase1_boss_material_box = new List<int>(); // 0x418
        public List<int> list_phase2_boss_id = new List<int>(); // 0x420
        public List<int> list_phase2_boss_level = new List<int>(); // 0x428
        public List<int> list_phase2_boss_skill_level = new List<int>(); // 0x430
        public List<int> list_phase2_boss_material_box = new List<int>(); // 0x438
        public List<string> list_EssenCondition = new List<string>(); // 0x440
        public List<int> list_EssenConditionValue = new List<int>(); // 0x448
        public List<string> list_BanCondition = new List<string>(); // 0x450
        public List<int> list_BanConditionValue = new List<int>(); // 0x458
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            type = reader.ReadString();
            control_type = reader.ReadString();
            stage_string = reader.ReadString();
            region = reader.ReadInt32();
            area = reader.ReadInt32();
            destroy_index = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            need_stage_type = reader.ReadString();
            need_stage_id = reader.ReadInt32();
            difficulty = reader.ReadInt32();
            difficulty_lock = reader.ReadInt32();
            difficulty_string = reader.ReadString();
            info_image = reader.ReadString();
            info_guide = reader.ReadString();
            bgm_sound_id_1 = reader.ReadInt32();
            ambient_sound_id_1 = reader.ReadInt32();
            bgm_sound_id_2 = reader.ReadInt32();
            ambient_sound_id_2 = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            guild_exp = reader.ReadInt32();
            guild_skill_point = reader.ReadInt32();
            guild_donation = reader.ReadInt32();
            group_item_rate_add = reader.ReadInt32();
            drop_item_boss_min_count = reader.ReadInt32();
            drop_item_boss_max_count = reader.ReadInt32();
            monster_material_per = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_item_value_1 = reader.ReadInt32();
            drop_item_evolution_count_1 = reader.ReadInt32();
            drop_item_per_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_item_value_2 = reader.ReadInt32();
            drop_item_evolution_count_2 = reader.ReadInt32();
            drop_item_per_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_item_value_3 = reader.ReadInt32();
            drop_item_evolution_count_3 = reader.ReadInt32();
            drop_item_per_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            drop_item_id_4 = reader.ReadInt32();
            drop_item_value_4 = reader.ReadInt32();
            drop_item_evolution_count_4 = reader.ReadInt32();
            drop_item_per_4 = reader.ReadInt32();
            drop_item_box_4 = reader.ReadInt32();
            drop_item_id_5 = reader.ReadInt32();
            drop_item_value_5 = reader.ReadInt32();
            drop_item_evolution_count_5 = reader.ReadInt32();
            drop_item_per_5 = reader.ReadInt32();
            drop_item_box_5 = reader.ReadInt32();
            drop_item_id_6 = reader.ReadInt32();
            drop_item_value_6 = reader.ReadInt32();
            drop_item_evolution_count_6 = reader.ReadInt32();
            drop_item_per_6 = reader.ReadInt32();
            drop_item_box_6 = reader.ReadInt32();
            drop_item_id_7 = reader.ReadInt32();
            drop_item_value_7 = reader.ReadInt32();
            drop_item_evolution_count_7 = reader.ReadInt32();
            drop_item_per_7 = reader.ReadInt32();
            drop_item_box_7 = reader.ReadInt32();
            drop_item_id_8 = reader.ReadInt32();
            drop_item_value_8 = reader.ReadInt32();
            drop_item_evolution_count_8 = reader.ReadInt32();
            drop_item_per_8 = reader.ReadInt32();
            drop_item_box_8 = reader.ReadInt32();
            drop_item_id_9 = reader.ReadInt32();
            drop_item_value_9 = reader.ReadInt32();
            drop_item_evolution_count_9 = reader.ReadInt32();
            drop_item_per_9 = reader.ReadInt32();
            drop_item_box_9 = reader.ReadInt32();
            drop_item_id_10 = reader.ReadInt32();
            drop_item_value_10 = reader.ReadInt32();
            drop_item_evolution_count_10 = reader.ReadInt32();
            drop_item_per_10 = reader.ReadInt32();
            drop_item_box_10 = reader.ReadInt32();
            drop_item_id_11 = reader.ReadInt32();
            drop_item_value_11 = reader.ReadInt32();
            drop_item_evolution_count_11 = reader.ReadInt32();
            drop_item_per_11 = reader.ReadInt32();
            drop_item_box_11 = reader.ReadInt32();
            drop_item_id_12 = reader.ReadInt32();
            drop_item_value_12 = reader.ReadInt32();
            drop_item_evolution_count_12 = reader.ReadInt32();
            drop_item_per_12 = reader.ReadInt32();
            drop_item_box_12 = reader.ReadInt32();
            drop_item_id_13 = reader.ReadInt32();
            drop_item_value_13 = reader.ReadInt32();
            drop_item_evolution_count_13 = reader.ReadInt32();
            drop_item_per_13 = reader.ReadInt32();
            drop_item_box_13 = reader.ReadInt32();
            drop_item_id_14 = reader.ReadInt32();
            drop_item_value_14 = reader.ReadInt32();
            drop_item_evolution_count_14 = reader.ReadInt32();
            drop_item_per_14 = reader.ReadInt32();
            drop_item_box_14 = reader.ReadInt32();
            drop_item_id_15 = reader.ReadInt32();
            drop_item_value_15 = reader.ReadInt32();
            drop_item_evolution_count_15 = reader.ReadInt32();
            drop_item_per_15 = reader.ReadInt32();
            drop_item_box_15 = reader.ReadInt32();
            drop_item_id_16 = reader.ReadInt32();
            drop_item_value_16 = reader.ReadInt32();
            drop_item_evolution_count_16 = reader.ReadInt32();
            drop_item_per_16 = reader.ReadInt32();
            drop_item_box_16 = reader.ReadInt32();
            drop_item_id_17 = reader.ReadInt32();
            drop_item_value_17 = reader.ReadInt32();
            drop_item_evolution_count_17 = reader.ReadInt32();
            drop_item_per_17 = reader.ReadInt32();
            drop_item_box_17 = reader.ReadInt32();
            drop_item_id_18 = reader.ReadInt32();
            drop_item_value_18 = reader.ReadInt32();
            drop_item_evolution_count_18 = reader.ReadInt32();
            drop_item_per_18 = reader.ReadInt32();
            drop_item_box_18 = reader.ReadInt32();
            stage_placement = reader.ReadString();
            situation_behavior_tree_name = reader.ReadString();
            //array_destroy_tag = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_destroy_tag.Add(reader.ReadInt32());
                v0--;
            }
            phase1_boss_atk_inc_per = reader.ReadInt32();
            phase1_boss_def_inc_per = reader.ReadInt32();
            phase1_boss_hp_inc_per = reader.ReadInt32();
            phase1_boss_id_1 = reader.ReadInt32();
            phase1_boss_level_1 = reader.ReadInt32();
            //phase1_array_passive1 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_phase1_array_passive1.Add(reader.ReadInt32());
                v1--;
            }
            phase1_boss_material_box_1 = reader.ReadInt32();
            phase1_boss_id_2 = reader.ReadInt32();
            phase1_boss_level_2 = reader.ReadInt32();
            //phase1_array_passive2 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_phase1_array_passive2.Add(reader.ReadInt32());
                v2--;
            }
            phase1_boss_material_box_2 = reader.ReadInt32();
            phase1_boss_id_3 = reader.ReadInt32();
            phase1_boss_level_3 = reader.ReadInt32();
            //phase1_array_passive3 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_phase1_array_passive3.Add(reader.ReadInt32());
                v3--;
            }
            phase1_boss_material_box_3 = reader.ReadInt32();
            phase2_boss_atk_inc_per = reader.ReadInt32();
            phase2_boss_def_inc_per = reader.ReadInt32();
            phase2_boss_hp_inc_per = reader.ReadInt32();
            phase2_boss_id_1 = reader.ReadInt32();
            phase2_boss_level_1 = reader.ReadInt32();
            phase2_boss_skill_level_1 = reader.ReadInt32();
            phase2_boss_material_box_1 = reader.ReadInt32();
            //phase2_array_passive1 = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_phase2_array_passive1.Add(reader.ReadInt32());
                v4--;
            }
            phase2_boss_id_2 = reader.ReadInt32();
            phase2_boss_level_2 = reader.ReadInt32();
            //phase2_array_passive2 = reader.ReadString();
            var v5 = reader.ReadInt32();
            while ((v5 - 1) >= 0)
            {
                list_phase2_array_passive2.Add(reader.ReadInt32());
                v5--;
            }
            phase2_boss_material_box_2 = reader.ReadInt32();
            phase2_boss_id_3 = reader.ReadInt32();
            phase2_boss_level_3 = reader.ReadInt32();
            //phase2_array_passive3 = reader.ReadString();
            var v6 = reader.ReadInt32();
            while ((v6 - 1) >= 0)
            {
                list_phase2_array_passive3.Add(reader.ReadInt32());
                v6--;
            }
            phase2_boss_material_box_3 = reader.ReadInt32();
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            team_power = reader.ReadInt32();
            //array_ally_passive_id = reader.ReadString();
            var v7 = reader.ReadInt32();
            while ((v7 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v7--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            season_id = reader.ReadInt32();
            season_group = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageChallengeBossDescRow
    {
        public int id { get; set; } // 0x10
        public string challenge_boss_strong_skill_desc { get; set; } // 0x18
        public string challenge_boss_pattern_desc { get; set; } // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            challenge_boss_strong_skill_desc = reader.ReadString();
            challenge_boss_pattern_desc = reader.ReadString();
            return true;
        }
    }
    public class DBStageChallengeBossEventRow
    {
        public int id { get; set; } // 0x10
        public int group_id { get; set; } // 0x14
        public string type { get; set; } // 0x18
        public string control_type { get; set; } // 0x20
        public string stage_string { get; set; } // 0x28
        public int limit_index { get; set; } // 0x30
        public int region { get; set; } // 0x34
        public int area { get; set; } // 0x38
        public int destroy_index { get; set; } // 0x3C
        public int need_quest_id { get; set; } // 0x40
        public string need_stage_type { get; set; } // 0x48
        public int need_stage_id { get; set; } // 0x50
        public int difficulty { get; set; } // 0x54
        public int difficulty_lock { get; set; } // 0x58
        public string difficulty_string { get; set; } // 0x60
        public string challenge_boss_pattern_phase01_desc { get; set; } // 0x68
        public string challenge_boss_pattern_phase02_desc { get; set; } // 0x70
        public int bgm_sound_id_1 { get; set; } // 0x78
        public int ambient_sound_id_1 { get; set; } // 0x7C
        public int bgm_sound_id_2 { get; set; } // 0x80
        public int ambient_sound_id_2 { get; set; } // 0x84
        public int start_cut { get; set; } // 0x88
        public int end_cut { get; set; } // 0x8C
        public int story_id_1 { get; set; } // 0x90
        public int story_id_2 { get; set; } // 0x94
        public int story_id_3 { get; set; } // 0x98
        public int need_stamina_item_id { get; set; } // 0x9C
        public int need_stamina_count { get; set; } // 0xA0
        public int user_exp { get; set; } // 0xA4
        public int hero_exp { get; set; } // 0xA8
        public int event_point_id { get; set; } // 0xAC
        public int event_point_count { get; set; } // 0xB0
        public int group_item_rate_add { get; set; } // 0xB4
        public int reward_id { get; set; } // 0xB8
        public int reward_value { get; set; } // 0xBC
        public int reward_value_box { get; set; } // 0xC0
        public int drop_item_boss_min_count { get; set; } // 0xC4
        public int drop_item_boss_max_count { get; set; } // 0xC8
        public int monster_material_per { get; set; } // 0xCC
        public int drop_item_id_1 { get; set; } // 0xD0
        public int drop_item_value_1 { get; set; } // 0xD4
        public int drop_item_evolution_count_1 { get; set; } // 0xD8
        public int drop_item_per_1 { get; set; } // 0xDC
        public int drop_item_box_1 { get; set; } // 0xE0
        public int drop_item_id_2 { get; set; } // 0xE4
        public int drop_item_value_2 { get; set; } // 0xE8
        public int drop_item_evolution_count_2 { get; set; } // 0xEC
        public int drop_item_per_2 { get; set; } // 0xF0
        public int drop_item_box_2 { get; set; } // 0xF4
        public int drop_item_id_3 { get; set; } // 0xF8
        public int drop_item_value_3 { get; set; } // 0xFC
        public int drop_item_evolution_count_3 { get; set; } // 0x100
        public int drop_item_per_3 { get; set; } // 0x104
        public int drop_item_box_3 { get; set; } // 0x108
        public int drop_item_id_4 { get; set; } // 0x10C
        public int drop_item_value_4 { get; set; } // 0x110
        public int drop_item_evolution_count_4 { get; set; } // 0x114
        public int drop_item_per_4 { get; set; } // 0x118
        public int drop_item_box_4 { get; set; } // 0x11C
        public int drop_item_id_5 { get; set; } // 0x120
        public int drop_item_value_5 { get; set; } // 0x124
        public int drop_item_evolution_count_5 { get; set; } // 0x128
        public int drop_item_per_5 { get; set; } // 0x12C
        public int drop_item_box_5 { get; set; } // 0x130
        public int drop_item_id_6 { get; set; } // 0x134
        public int drop_item_value_6 { get; set; } // 0x138
        public int drop_item_evolution_count_6 { get; set; } // 0x13C
        public int drop_item_per_6 { get; set; } // 0x140
        public int drop_item_box_6 { get; set; } // 0x144
        public int drop_item_id_7 { get; set; } // 0x148
        public int drop_item_value_7 { get; set; } // 0x14C
        public int drop_item_evolution_count_7 { get; set; } // 0x150
        public int drop_item_per_7 { get; set; } // 0x154
        public int drop_item_box_7 { get; set; } // 0x158
        public int drop_item_id_8 { get; set; } // 0x15C
        public int drop_item_value_8 { get; set; } // 0x160
        public int drop_item_evolution_count_8 { get; set; } // 0x164
        public int drop_item_per_8 { get; set; } // 0x168
        public int drop_item_box_8 { get; set; } // 0x16C
        public int drop_item_id_9 { get; set; } // 0x170
        public int drop_item_value_9 { get; set; } // 0x174
        public int drop_item_evolution_count_9 { get; set; } // 0x178
        public int drop_item_per_9 { get; set; } // 0x17C
        public int drop_item_box_9 { get; set; } // 0x180
        public int drop_item_id_10 { get; set; } // 0x184
        public int drop_item_value_10 { get; set; } // 0x188
        public int drop_item_evolution_count_10 { get; set; } // 0x18C
        public int drop_item_per_10 { get; set; } // 0x190
        public int drop_item_box_10 { get; set; } // 0x194
        public int drop_item_id_11 { get; set; } // 0x198
        public int drop_item_value_11 { get; set; } // 0x19C
        public int drop_item_evolution_count_11 { get; set; } // 0x1A0
        public int drop_item_per_11 { get; set; } // 0x1A4
        public int drop_item_box_11 { get; set; } // 0x1A8
        public int drop_item_id_12 { get; set; } // 0x1AC
        public int drop_item_value_12 { get; set; } // 0x1B0
        public int drop_item_evolution_count_12 { get; set; } // 0x1B4
        public int drop_item_per_12 { get; set; } // 0x1B8
        public int drop_item_box_12 { get; set; } // 0x1BC
        public int drop_item_id_13 { get; set; } // 0x1C0
        public int drop_item_value_13 { get; set; } // 0x1C4
        public int drop_item_evolution_count_13 { get; set; } // 0x1C8
        public int drop_item_per_13 { get; set; } // 0x1CC
        public int drop_item_box_13 { get; set; } // 0x1D0
        public int drop_item_id_14 { get; set; } // 0x1D4
        public int drop_item_value_14 { get; set; } // 0x1D8
        public int drop_item_evolution_count_14 { get; set; } // 0x1DC
        public int drop_item_per_14 { get; set; } // 0x1E0
        public int drop_item_box_14 { get; set; } // 0x1E4
        public int drop_item_id_15 { get; set; } // 0x1E8
        public int drop_item_value_15 { get; set; } // 0x1EC
        public int drop_item_evolution_count_15 { get; set; } // 0x1F0
        public int drop_item_per_15 { get; set; } // 0x1F4
        public int drop_item_box_15 { get; set; } // 0x1F8
        public int drop_item_id_16 { get; set; } // 0x1FC
        public int drop_item_value_16 { get; set; } // 0x200
        public int drop_item_evolution_count_16 { get; set; } // 0x204
        public int drop_item_per_16 { get; set; } // 0x208
        public int drop_item_box_16 { get; set; } // 0x20C
        public int drop_item_id_17 { get; set; } // 0x210
        public int drop_item_value_17 { get; set; } // 0x214
        public int drop_item_evolution_count_17 { get; set; } // 0x218
        public int drop_item_per_17 { get; set; } // 0x21C
        public int drop_item_box_17 { get; set; } // 0x220
        public int drop_item_id_18 { get; set; } // 0x224
        public int drop_item_value_18 { get; set; } // 0x228
        public int drop_item_evolution_count_18 { get; set; } // 0x22C
        public int drop_item_per_18 { get; set; } // 0x230
        public int drop_item_box_18 { get; set; } // 0x234
        public string stage_placement { get; set; } // 0x238
        public int phase_shift_cinema_two_boss { get; set; } // 0x240
        public string situation_behavior_tree_name { get; set; } // 0x248
        public List<int> list_array_destroy_tag = new List<int>(); // 0x250
        public int phase1_boss_atk_inc_per { get; set; } // 0x258
        public int phase1_boss_def_inc_per { get; set; } // 0x25C
        public int phase1_boss_hp_inc_per { get; set; } // 0x260
        public int phase1_boss_id_1 { get; set; } // 0x264
        public int phase1_boss_level_1 { get; set; } // 0x268
        public List<int> list_phase1_array_passive1 = new List<int>(); // 0x270
        public int phase1_boss_material_box_1 { get; set; } // 0x278
        public int phase1_boss_id_2 { get; set; } // 0x27C
        public int phase1_boss_level_2 { get; set; } // 0x280
        public List<int> list_phase1_array_passive2 = new List<int>(); // 0x288
        public int phase1_boss_material_box_2 { get; set; } // 0x290
        public int phase1_boss_id_3 { get; set; } // 0x294
        public int phase1_boss_level_3 { get; set; } // 0x298
        public List<int> list_phase1_array_passive3 = new List<int>(); // 0x2A0
        public int phase1_boss_material_box_3 { get; set; } // 0x2A8
        public int phase2_boss_atk_inc_per { get; set; } // 0x2AC
        public int phase2_boss_def_inc_per { get; set; } // 0x2B0
        public int phase2_boss_hp_inc_per { get; set; } // 0x2B4
        public int phase2_boss_id_1 { get; set; } // 0x2B8
        public int phase2_boss_level_1 { get; set; } // 0x2BC
        public int phase2_boss_skill_level_1 { get; set; } // 0x2C0
        public int phase2_boss_material_box_1 { get; set; } // 0x2C4
        public List<int> list_phase2_array_passive1 = new List<int>(); // 0x2C8
        public int phase2_boss_id_2 { get; set; } // 0x2D0
        public int phase2_boss_level_2 { get; set; } // 0x2D4
        public List<int> list_phase2_array_passive2 = new List<int>(); // 0x2D8
        public int phase2_boss_material_box_2 { get; set; } // 0x2E0
        public int phase2_boss_id_3 { get; set; } // 0x2E4
        public int phase2_boss_level_3 { get; set; } // 0x2E8
        public List<int> list_phase2_array_passive3 = new List<int>(); // 0x2F0
        public int phase2_boss_material_box_3 { get; set; } // 0x2F8
        public int play_boss_spawn { get; set; } // 0x2FC
        public string boss_entry_type { get; set; } // 0x300
        public int team_power { get; set; } // 0x308
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x310
        public string map_filename { get; set; } // 0x318
        public string spawn_prop_filename { get; set; } // 0x320
        public string change_map_filename { get; set; } // 0x328
        public int bgm_sound_id { get; set; } // 0x330
        public int boss_sound_id { get; set; } // 0x334
        public string EssenCondition_1 { get; set; } // 0x338
        public int EssenConditionValue_1 { get; set; } // 0x340
        public string EssenCondition_2 { get; set; } // 0x348
        public int EssenConditionValue_2 { get; set; } // 0x350
        public string EssenCondition_3 { get; set; } // 0x358
        public int EssenConditionValue_3 { get; set; } // 0x360
        public string EssenCondition_4 { get; set; } // 0x368
        public int EssenConditionValue_4 { get; set; } // 0x370
        public string BanCondition_1 { get; set; } // 0x378
        public int BanConditionValue_1 { get; set; } // 0x380
        public string BanCondition_2 { get; set; } // 0x388
        public int BanConditionValue_2 { get; set; } // 0x390
        public string BanCondition_3 { get; set; } // 0x398
        public int BanConditionValue_3 { get; set; } // 0x3A0
        public string BanCondition_4 { get; set; } // 0x3A8
        public int BanConditionValue_4 { get; set; } // 0x3B0
        public string BanCondition_5 { get; set; } // 0x3B8
        public int BanConditionValue_5 { get; set; } // 0x3C0
        public string BanCondition_6 { get; set; } // 0x3C8
        public int BanConditionValue_6 { get; set; } // 0x3D0
        public List<int> list_bgm_sound_id = new List<int>(); // 0x3D8
        public List<int> list_ambient_sound_id = new List<int>(); // 0x3E0
        public List<int> list_story_id = new List<int>(); // 0x3E8
        public List<int> list_drop_item_id = new List<int>(); // 0x3F0
        public List<int> list_drop_item_value = new List<int>(); // 0x3F8
        public List<int> list_drop_item_evolution_count = new List<int>(); // 0x400
        public List<int> list_drop_item_per = new List<int>(); // 0x408
        public List<int> list_drop_item_box = new List<int>(); // 0x410
        public List<int> list_phase1_boss_id = new List<int>(); // 0x418
        public List<int> list_phase1_boss_level = new List<int>(); // 0x420
        public List<int> list_phase1_boss_material_box = new List<int>(); // 0x428
        public List<int> list_phase2_boss_id = new List<int>(); // 0x430
        public List<int> list_phase2_boss_level = new List<int>(); // 0x438
        public List<int> list_phase2_boss_skill_level = new List<int>(); // 0x440
        public List<int> list_phase2_boss_material_box = new List<int>(); // 0x448
        public List<string> list_EssenCondition = new List<string>(); // 0x450
        public List<int> list_EssenConditionValue = new List<int>(); // 0x458
        public List<string> list_BanCondition = new List<string>(); // 0x460
        public List<int> list_BanConditionValue = new List<int>(); // 0x468
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            type = reader.ReadString();
            control_type = reader.ReadString();
            stage_string = reader.ReadString();
            limit_index = reader.ReadInt32();
            region = reader.ReadInt32();
            area = reader.ReadInt32();
            destroy_index = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            need_stage_type = reader.ReadString();
            need_stage_id = reader.ReadInt32();
            difficulty = reader.ReadInt32();
            difficulty_lock = reader.ReadInt32();
            difficulty_string = reader.ReadString();
            challenge_boss_pattern_phase01_desc = reader.ReadString();
            challenge_boss_pattern_phase02_desc = reader.ReadString();
            bgm_sound_id_1 = reader.ReadInt32();
            ambient_sound_id_1 = reader.ReadInt32();
            bgm_sound_id_2 = reader.ReadInt32();
            ambient_sound_id_2 = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            event_point_id = reader.ReadInt32();
            event_point_count = reader.ReadInt32();
            group_item_rate_add = reader.ReadInt32();
            reward_id = reader.ReadInt32();
            reward_value = reader.ReadInt32();
            reward_value_box = reader.ReadInt32();
            drop_item_boss_min_count = reader.ReadInt32();
            drop_item_boss_max_count = reader.ReadInt32();
            monster_material_per = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_item_value_1 = reader.ReadInt32();
            drop_item_evolution_count_1 = reader.ReadInt32();
            drop_item_per_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_item_value_2 = reader.ReadInt32();
            drop_item_evolution_count_2 = reader.ReadInt32();
            drop_item_per_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_item_value_3 = reader.ReadInt32();
            drop_item_evolution_count_3 = reader.ReadInt32();
            drop_item_per_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            drop_item_id_4 = reader.ReadInt32();
            drop_item_value_4 = reader.ReadInt32();
            drop_item_evolution_count_4 = reader.ReadInt32();
            drop_item_per_4 = reader.ReadInt32();
            drop_item_box_4 = reader.ReadInt32();
            drop_item_id_5 = reader.ReadInt32();
            drop_item_value_5 = reader.ReadInt32();
            drop_item_evolution_count_5 = reader.ReadInt32();
            drop_item_per_5 = reader.ReadInt32();
            drop_item_box_5 = reader.ReadInt32();
            drop_item_id_6 = reader.ReadInt32();
            drop_item_value_6 = reader.ReadInt32();
            drop_item_evolution_count_6 = reader.ReadInt32();
            drop_item_per_6 = reader.ReadInt32();
            drop_item_box_6 = reader.ReadInt32();
            drop_item_id_7 = reader.ReadInt32();
            drop_item_value_7 = reader.ReadInt32();
            drop_item_evolution_count_7 = reader.ReadInt32();
            drop_item_per_7 = reader.ReadInt32();
            drop_item_box_7 = reader.ReadInt32();
            drop_item_id_8 = reader.ReadInt32();
            drop_item_value_8 = reader.ReadInt32();
            drop_item_evolution_count_8 = reader.ReadInt32();
            drop_item_per_8 = reader.ReadInt32();
            drop_item_box_8 = reader.ReadInt32();
            drop_item_id_9 = reader.ReadInt32();
            drop_item_value_9 = reader.ReadInt32();
            drop_item_evolution_count_9 = reader.ReadInt32();
            drop_item_per_9 = reader.ReadInt32();
            drop_item_box_9 = reader.ReadInt32();
            drop_item_id_10 = reader.ReadInt32();
            drop_item_value_10 = reader.ReadInt32();
            drop_item_evolution_count_10 = reader.ReadInt32();
            drop_item_per_10 = reader.ReadInt32();
            drop_item_box_10 = reader.ReadInt32();
            drop_item_id_11 = reader.ReadInt32();
            drop_item_value_11 = reader.ReadInt32();
            drop_item_evolution_count_11 = reader.ReadInt32();
            drop_item_per_11 = reader.ReadInt32();
            drop_item_box_11 = reader.ReadInt32();
            drop_item_id_12 = reader.ReadInt32();
            drop_item_value_12 = reader.ReadInt32();
            drop_item_evolution_count_12 = reader.ReadInt32();
            drop_item_per_12 = reader.ReadInt32();
            drop_item_box_12 = reader.ReadInt32();
            drop_item_id_13 = reader.ReadInt32();
            drop_item_value_13 = reader.ReadInt32();
            drop_item_evolution_count_13 = reader.ReadInt32();
            drop_item_per_13 = reader.ReadInt32();
            drop_item_box_13 = reader.ReadInt32();
            drop_item_id_14 = reader.ReadInt32();
            drop_item_value_14 = reader.ReadInt32();
            drop_item_evolution_count_14 = reader.ReadInt32();
            drop_item_per_14 = reader.ReadInt32();
            drop_item_box_14 = reader.ReadInt32();
            drop_item_id_15 = reader.ReadInt32();
            drop_item_value_15 = reader.ReadInt32();
            drop_item_evolution_count_15 = reader.ReadInt32();
            drop_item_per_15 = reader.ReadInt32();
            drop_item_box_15 = reader.ReadInt32();
            drop_item_id_16 = reader.ReadInt32();
            drop_item_value_16 = reader.ReadInt32();
            drop_item_evolution_count_16 = reader.ReadInt32();
            drop_item_per_16 = reader.ReadInt32();
            drop_item_box_16 = reader.ReadInt32();
            drop_item_id_17 = reader.ReadInt32();
            drop_item_value_17 = reader.ReadInt32();
            drop_item_evolution_count_17 = reader.ReadInt32();
            drop_item_per_17 = reader.ReadInt32();
            drop_item_box_17 = reader.ReadInt32();
            drop_item_id_18 = reader.ReadInt32();
            drop_item_value_18 = reader.ReadInt32();
            drop_item_evolution_count_18 = reader.ReadInt32();
            drop_item_per_18 = reader.ReadInt32();
            drop_item_box_18 = reader.ReadInt32();
            stage_placement = reader.ReadString();
            phase_shift_cinema_two_boss = reader.ReadInt32();
            situation_behavior_tree_name = reader.ReadString();
            //array_destroy_tag = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_destroy_tag.Add(reader.ReadInt32());
                v0--;
            }
            phase1_boss_atk_inc_per = reader.ReadInt32();
            phase1_boss_def_inc_per = reader.ReadInt32();
            phase1_boss_hp_inc_per = reader.ReadInt32();
            phase1_boss_id_1 = reader.ReadInt32();
            phase1_boss_level_1 = reader.ReadInt32();
            //phase1_array_passive1 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_phase1_array_passive1.Add(reader.ReadInt32());
                v1--;
            }
            phase1_boss_material_box_1 = reader.ReadInt32();
            phase1_boss_id_2 = reader.ReadInt32();
            phase1_boss_level_2 = reader.ReadInt32();
            //phase1_array_passive2 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_phase1_array_passive2.Add(reader.ReadInt32());
                v2--;
            }
            phase1_boss_material_box_2 = reader.ReadInt32();
            phase1_boss_id_3 = reader.ReadInt32();
            phase1_boss_level_3 = reader.ReadInt32();
            //phase1_array_passive3 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_phase1_array_passive3.Add(reader.ReadInt32());
                v3--;
            }
            phase1_boss_material_box_3 = reader.ReadInt32();
            phase2_boss_atk_inc_per = reader.ReadInt32();
            phase2_boss_def_inc_per = reader.ReadInt32();
            phase2_boss_hp_inc_per = reader.ReadInt32();
            phase2_boss_id_1 = reader.ReadInt32();
            phase2_boss_level_1 = reader.ReadInt32();
            phase2_boss_skill_level_1 = reader.ReadInt32();
            phase2_boss_material_box_1 = reader.ReadInt32();
            //phase2_array_passive1 = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_phase2_array_passive1.Add(reader.ReadInt32());
                v4--;
            }
            phase2_boss_id_2 = reader.ReadInt32();
            phase2_boss_level_2 = reader.ReadInt32();
            //phase2_array_passive2 = reader.ReadString();
            var v5 = reader.ReadInt32();
            while ((v5 - 1) >= 0)
            {
                list_phase2_array_passive2.Add(reader.ReadInt32());
                v5--;
            }
            phase2_boss_material_box_2 = reader.ReadInt32();
            phase2_boss_id_3 = reader.ReadInt32();
            phase2_boss_level_3 = reader.ReadInt32();
            //phase2_array_passive3 = reader.ReadString();
            var v6 = reader.ReadInt32();
            while ((v6 - 1) >= 0)
            {
                list_phase2_array_passive3.Add(reader.ReadInt32());
                v6--;
            }
            phase2_boss_material_box_3 = reader.ReadInt32();
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            team_power = reader.ReadInt32();
            //array_ally_passive_id = reader.ReadString();
            var v7 = reader.ReadInt32();
            while ((v7 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v7--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageChallengeBossGroupRow
    {
        public int group_id { get; set; } // 0x10
        public int event_sub_index { get; set; } // 0x14
        public int group_hero_id { get; set; } // 0x18
        public string group_string { get; set; } // 0x20
        public string info_image { get; set; } // 0x28
        public string challenge_boss_strong_skill_desc { get; set; } // 0x30
        public int result_score_list { get; set; } // 0x38
        public string result_score_name { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            group_id = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            group_hero_id = reader.ReadInt32();
            group_string = reader.ReadString();
            info_image = reader.ReadString();
            challenge_boss_strong_skill_desc = reader.ReadString();
            result_score_list = reader.ReadInt32();
            result_score_name = reader.ReadString();
            return true;
        }
    }
    public class DBStageDestroyCommonRow
    {
        public int boss_id { get; set; } // 0x10
        public int team_index { get; set; } // 0x14
        public int change_hell_team_index { get; set; } // 0x18
        public int event_type { get; set; } // 0x1C
        public int event_sub_index { get; set; } // 0x20
        public int repulse_drop_item_id { get; set; } // 0x24
        public int repulse_drop_item_value { get; set; } // 0x28
        public int repulse_drop_item_box { get; set; } // 0x2C
        public bool ReadToStream(BinaryReader reader)
        {
            boss_id = reader.ReadInt32();
            team_index = reader.ReadInt32();
            change_hell_team_index = reader.ReadInt32();
            event_type = reader.ReadInt32();
            event_sub_index = reader.ReadInt32();
            repulse_drop_item_id = reader.ReadInt32();
            repulse_drop_item_value = reader.ReadInt32();
            repulse_drop_item_box = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageDestroyDescRow
    {
        public int id { get; set; } // 0x10
        public string destroy_strong_tribe_desc { get; set; } // 0x18
        public string destroy_weak_tribe_desc { get; set; } // 0x20
        public string destroy_strong_skill_desc { get; set; } // 0x28
        public string destroy_pattern_desc { get; set; } // 0x30
        public string destroy_skill_desc { get; set; } // 0x38
        public string destroy_passive_desc { get; set; } // 0x40
        public string destroy_idle_path { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            destroy_strong_tribe_desc = reader.ReadString();
            destroy_weak_tribe_desc = reader.ReadString();
            destroy_strong_skill_desc = reader.ReadString();
            destroy_pattern_desc = reader.ReadString();
            destroy_skill_desc = reader.ReadString();
            destroy_passive_desc = reader.ReadString();
            destroy_idle_path = reader.ReadString();
            return true;
        }
    }
    public class DBStageEventMonthlyRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string stage_string { get; set; } // 0x20
        public int essen_hero_setting { get; set; } // 0x28
        public string control_type { get; set; } // 0x30
        public int region { get; set; } // 0x38
        public int index { get; set; } // 0x3C
        public int area { get; set; } // 0x40
        public int side { get; set; } // 0x44
        public int start_quest_id { get; set; } // 0x48
        public int need_quest_id { get; set; } // 0x4C
        public int need_stage_side { get; set; } // 0x50
        public int extra_group_id { get; set; } // 0x54
        public int need_stage_id { get; set; } // 0x58
        public int next_stage_side { get; set; } // 0x5C
        public int next_stage_id { get; set; } // 0x60
        public int start_cut { get; set; } // 0x64
        public int end_cut { get; set; } // 0x68
        public int story_id_1 { get; set; } // 0x6C
        public int story_id_2 { get; set; } // 0x70
        public int story_id_3 { get; set; } // 0x74
        public int need_stamina_item_id { get; set; } // 0x78
        public int need_stamina_count { get; set; } // 0x7C
        public int team_power { get; set; } // 0x80
        public int monster_count { get; set; } // 0x84
        public int monster_atk_inc_per { get; set; } // 0x88
        public int monster_def_inc_per { get; set; } // 0x8C
        public int monster_hp_inc_per { get; set; } // 0x90
        public int monster_level { get; set; } // 0x94
        public int monster_id_1 { get; set; } // 0x98
        public int monster_id_2 { get; set; } // 0x9C
        public int monster_id_3 { get; set; } // 0xA0
        public int monster_id_4 { get; set; } // 0xA4
        public int monster_id_5 { get; set; } // 0xA8
        public int monster_id_6 { get; set; } // 0xAC
        public int is_turn_pivot { get; set; } // 0xB0
        public string stage_placement { get; set; } // 0xB8
        public int stage_hero_entry_all { get; set; } // 0xC0
        public int monster_ai_id { get; set; } // 0xC4
        public int boss_atk_inc_per { get; set; } // 0xC8
        public int boss_def_inc_per { get; set; } // 0xCC
        public int boss_hp_inc_per { get; set; } // 0xD0
        public int boss_id_1 { get; set; } // 0xD4
        public int boss_level_1 { get; set; } // 0xD8
        public string array_passive1 { get; set; } // 0xE0
        public List<int> list_array_passive1 = new List<int>(); // 0xE8
        public int boss_id_2 { get; set; } // 0xF0
        public int boss_level_2 { get; set; } // 0xF4
        public string array_passive2 { get; set; } // 0xF8
        public List<int> list_array_passive2 = new List<int>(); // 0x100
        public int boss_id_3 { get; set; } // 0x108
        public int boss_level_3 { get; set; } // 0x10C
        public string array_passive3 { get; set; } // 0x110
        public List<int> list_array_passive3 = new List<int>(); // 0x118
        public int boss_id_4 { get; set; } // 0x120
        public int boss_level_4 { get; set; } // 0x124
        public string array_passive4 { get; set; } // 0x128
        public List<int> list_array_passive4 = new List<int>(); // 0x130
        public int play_boss_spawn { get; set; } // 0x138
        public string boss_entry_type { get; set; } // 0x140
        public string array_ally_passive_id { get; set; } // 0x148
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x150
        public string map_filename { get; set; } // 0x158
        public string spawn_prop_filename { get; set; } // 0x160
        public string change_map_filename { get; set; } // 0x168
        public int bgm_sound_id { get; set; } // 0x170
        public int boss_sound_id { get; set; } // 0x174
        public int user_exp { get; set; } // 0x178
        public int hero_exp { get; set; } // 0x17C
        public int gold_value { get; set; } // 0x180
        public int reward_id_1 { get; set; } // 0x184
        public int reward_value_1 { get; set; } // 0x188
        public int reward_value_box_1 { get; set; } // 0x18C
        public int reward_hero_lv_1 { get; set; } // 0x190
        public int first_reward_id { get; set; } // 0x194
        public int first_reward_value { get; set; } // 0x198
        public int first_reward_hero_lv { get; set; } // 0x19C
        public string EssenCondition_1 { get; set; } // 0x1A0
        public int EssenConditionValue_1 { get; set; } // 0x1A8
        public string EssenCondition_2 { get; set; } // 0x1B0
        public int EssenConditionValue_2 { get; set; } // 0x1B8
        public string EssenCondition_3 { get; set; } // 0x1C0
        public int EssenConditionValue_3 { get; set; } // 0x1C8
        public string EssenCondition_4 { get; set; } // 0x1D0
        public int EssenConditionValue_4 { get; set; } // 0x1D8
        public string BanCondition_1 { get; set; } // 0x1E0
        public int BanConditionValue_1 { get; set; } // 0x1E8
        public string BanCondition_2 { get; set; } // 0x1F0
        public int BanConditionValue_2 { get; set; } // 0x1F8
        public string BanCondition_3 { get; set; } // 0x200
        public int BanConditionValue_3 { get; set; } // 0x208
        public string BanCondition_4 { get; set; } // 0x210
        public int BanConditionValue_4 { get; set; } // 0x218
        public string BanCondition_5 { get; set; } // 0x220
        public int BanConditionValue_5 { get; set; } // 0x228
        public string BanCondition_6 { get; set; } // 0x230
        public int BanConditionValue_6 { get; set; } // 0x238
        public int Hrun_reward_max_value { get; set; } // 0x23C
        public string Hrun_map { get; set; } // 0x240
        public string Hrun_bg { get; set; } // 0x248
        public int npc_team_id { get; set; } // 0x250
        public List<int> list_story_id = new List<int>(); // 0x258
        public List<int> list_monster_id = new List<int>(); // 0x260
        public List<int> list_boss_id = new List<int>(); // 0x268
        public List<int> list_boss_level = new List<int>(); // 0x270
        public List<int> list_reward_id = new List<int>(); // 0x278
        public List<int> list_reward_value = new List<int>(); // 0x280
        public List<int> list_reward_value_box = new List<int>(); // 0x288
        public List<int> list_reward_hero_lv = new List<int>(); // 0x290
        public List<string> list_EssenCondition = new List<string>(); // 0x298
        public List<int> list_EssenConditionValue = new List<int>(); // 0x2A0
        public List<string> list_BanCondition = new List<string>(); // 0x2A8
        public List<int> list_BanConditionValue = new List<int>(); // 0x2B0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            stage_string = reader.ReadString();
            essen_hero_setting = reader.ReadInt32();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            index = reader.ReadInt32();
            area = reader.ReadInt32();
            side = reader.ReadInt32();
            start_quest_id = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            need_stage_side = reader.ReadInt32();
            extra_group_id = reader.ReadInt32();
            need_stage_id = reader.ReadInt32();
            next_stage_side = reader.ReadInt32();
            next_stage_id = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            team_power = reader.ReadInt32();
            monster_count = reader.ReadInt32();
            monster_atk_inc_per = reader.ReadInt32();
            monster_def_inc_per = reader.ReadInt32();
            monster_hp_inc_per = reader.ReadInt32();
            monster_level = reader.ReadInt32();
            monster_id_1 = reader.ReadInt32();
            monster_id_2 = reader.ReadInt32();
            monster_id_3 = reader.ReadInt32();
            monster_id_4 = reader.ReadInt32();
            monster_id_5 = reader.ReadInt32();
            monster_id_6 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            stage_placement = reader.ReadString();
            stage_hero_entry_all = reader.ReadInt32();
            monster_ai_id = reader.ReadInt32();
            boss_atk_inc_per = reader.ReadInt32();
            boss_def_inc_per = reader.ReadInt32();
            boss_hp_inc_per = reader.ReadInt32();
            boss_id_1 = reader.ReadInt32();
            boss_level_1 = reader.ReadInt32();
            //array_passive1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v0--;
            }
            boss_id_2 = reader.ReadInt32();
            boss_level_2 = reader.ReadInt32();
            //array_passive2 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v1--;
            }
            boss_id_3 = reader.ReadInt32();
            boss_level_3 = reader.ReadInt32();
            //array_passive3 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v2--;
            }
            boss_id_4 = reader.ReadInt32();
            boss_level_4 = reader.ReadInt32();
            //array_passive4 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_passive4.Add(reader.ReadInt32());
                v3--;
            }
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v4--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_value_1 = reader.ReadInt32();
            reward_value_box_1 = reader.ReadInt32();
            reward_hero_lv_1 = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            first_reward_hero_lv = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            Hrun_reward_max_value = reader.ReadInt32();
            Hrun_map = reader.ReadString();
            Hrun_bg = reader.ReadString();
            npc_team_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageExtraRow
    {
        public int id { get; set; } // 0x10
        public int group_id { get; set; } // 0x14
        public string extra_type { get; set; } // 0x18
        public int stage_link { get; set; } // 0x20
        public string control_type { get; set; } // 0x28
        public int region { get; set; } // 0x30
        public int area { get; set; } // 0x34
        public string extra_stage_name { get; set; } // 0x38
        public string extra_icon_info { get; set; } // 0x40
        public string large_popup { get; set; } // 0x48
        public string event_banner { get; set; } // 0x50
        public int event_banner_link { get; set; } // 0x58
        public string open_type { get; set; } // 0x60
        public int open_id { get; set; } // 0x68
        public string reward_desc { get; set; } // 0x70
        public string reward_image { get; set; } // 0x78
        public int contents_quicklink { get; set; } // 0x80
        public int stage_first_time_link_id { get; set; } // 0x84
        public int start_npc { get; set; } // 0x88
        public int end_npc { get; set; } // 0x8C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            extra_type = reader.ReadString();
            stage_link = reader.ReadInt32();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            area = reader.ReadInt32();
            extra_stage_name = reader.ReadString();
            extra_icon_info = reader.ReadString();
            large_popup = reader.ReadString();
            event_banner = reader.ReadString();
            event_banner_link = reader.ReadInt32();
            open_type = reader.ReadString();
            open_id = reader.ReadInt32();
            reward_desc = reader.ReadString();
            reward_image = reader.ReadString();
            contents_quicklink = reader.ReadInt32();
            stage_first_time_link_id = reader.ReadInt32();
            start_npc = reader.ReadInt32();
            end_npc = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageFinalBossRow
    {
        public int id { get; set; } // 0x10
        public int group_id { get; set; } // 0x14
        public int final_boss_point_group_id { get; set; } // 0x18
        public string stage_type { get; set; } // 0x20
        public string control_type { get; set; } // 0x28
        public int limit_index { get; set; } // 0x30
        public int region { get; set; } // 0x34
        public int final_boss_index { get; set; } // 0x38
        public int area { get; set; } // 0x3C
        public string need_stage_type { get; set; } // 0x40
        public int need_stage_id { get; set; } // 0x48
        public int difficulty { get; set; } // 0x4C
        public string difficulty_string { get; set; } // 0x50
        public int before_loading_id { get; set; } // 0x58
        public int after_loading_id { get; set; } // 0x5C
        public int start_cut { get; set; } // 0x60
        public int end_cut { get; set; } // 0x64
        public int story_id_1 { get; set; } // 0x68
        public int story_id_2 { get; set; } // 0x6C
        public int story_id_3 { get; set; } // 0x70
        public int team_power { get; set; } // 0x74
        public int need_open_item_id { get; set; } // 0x78
        public int need_open_count { get; set; } // 0x7C
        public int need_stamina_item_id { get; set; } // 0x80
        public int need_stamina_count { get; set; } // 0x84
        public int user_exp { get; set; } // 0x88
        public int hero_exp { get; set; } // 0x8C
        public int gold_value { get; set; } // 0x90
        public int first_reward_id { get; set; } // 0x94
        public int first_reward_value { get; set; } // 0x98
        public int first_evolution_count { get; set; } // 0x9C
        public int clear_item_box { get; set; } // 0xA0
        public int clear_reward_id { get; set; } // 0xA4
        public int clear_reward_value { get; set; } // 0xA8
        public int drop_item_boss_min_count { get; set; } // 0xAC
        public int drop_item_boss_max_count { get; set; } // 0xB0
        public int monster_material_per { get; set; } // 0xB4
        public int drop_item_id_1 { get; set; } // 0xB8
        public int drop_item_value_1 { get; set; } // 0xBC
        public int drop_item_evolution_count_1 { get; set; } // 0xC0
        public int drop_item_per_1 { get; set; } // 0xC4
        public int drop_item_box_1 { get; set; } // 0xC8
        public int drop_item_id_2 { get; set; } // 0xCC
        public int drop_item_value_2 { get; set; } // 0xD0
        public int drop_item_evolution_count_2 { get; set; } // 0xD4
        public int drop_item_per_2 { get; set; } // 0xD8
        public int drop_item_box_2 { get; set; } // 0xDC
        public int drop_item_id_3 { get; set; } // 0xE0
        public int drop_item_value_3 { get; set; } // 0xE4
        public int drop_item_evolution_count_3 { get; set; } // 0xE8
        public int drop_item_per_3 { get; set; } // 0xEC
        public int drop_item_box_3 { get; set; } // 0xF0
        public int drop_item_id_4 { get; set; } // 0xF4
        public int drop_item_value_4 { get; set; } // 0xF8
        public int drop_item_evolution_count_4 { get; set; } // 0xFC
        public int drop_item_per_4 { get; set; } // 0x100
        public int drop_item_box_4 { get; set; } // 0x104
        public int drop_item_id_5 { get; set; } // 0x108
        public int drop_item_value_5 { get; set; } // 0x10C
        public int drop_item_evolution_count_5 { get; set; } // 0x110
        public int drop_item_per_5 { get; set; } // 0x114
        public int drop_item_box_5 { get; set; } // 0x118
        public int drop_item_id_6 { get; set; } // 0x11C
        public int drop_item_value_6 { get; set; } // 0x120
        public int drop_item_evolution_count_6 { get; set; } // 0x124
        public int drop_item_per_6 { get; set; } // 0x128
        public int drop_item_box_6 { get; set; } // 0x12C
        public int drop_item_id_7 { get; set; } // 0x130
        public int drop_item_value_7 { get; set; } // 0x134
        public int drop_item_evolution_count_7 { get; set; } // 0x138
        public int drop_item_per_7 { get; set; } // 0x13C
        public int drop_item_box_7 { get; set; } // 0x140
        public int drop_item_id_8 { get; set; } // 0x144
        public int drop_item_value_8 { get; set; } // 0x148
        public int drop_item_evolution_count_8 { get; set; } // 0x14C
        public int drop_item_per_8 { get; set; } // 0x150
        public int drop_item_box_8 { get; set; } // 0x154
        public int drop_item_id_9 { get; set; } // 0x158
        public int drop_item_value_9 { get; set; } // 0x15C
        public int drop_item_evolution_count_9 { get; set; } // 0x160
        public int drop_item_per_9 { get; set; } // 0x164
        public int drop_item_box_9 { get; set; } // 0x168
        public int drop_item_id_10 { get; set; } // 0x16C
        public int drop_item_value_10 { get; set; } // 0x170
        public int drop_item_evolution_count_10 { get; set; } // 0x174
        public int drop_item_per_10 { get; set; } // 0x178
        public int drop_item_box_10 { get; set; } // 0x17C
        public int drop_item_id_11 { get; set; } // 0x180
        public int drop_item_value_11 { get; set; } // 0x184
        public int drop_item_evolution_count_11 { get; set; } // 0x188
        public int drop_item_per_11 { get; set; } // 0x18C
        public int drop_item_box_11 { get; set; } // 0x190
        public int drop_item_id_12 { get; set; } // 0x194
        public int drop_item_value_12 { get; set; } // 0x198
        public int drop_item_evolution_count_12 { get; set; } // 0x19C
        public int drop_item_per_12 { get; set; } // 0x1A0
        public int drop_item_box_12 { get; set; } // 0x1A4
        public int drop_item_id_13 { get; set; } // 0x1A8
        public int drop_item_value_13 { get; set; } // 0x1AC
        public int drop_item_evolution_count_13 { get; set; } // 0x1B0
        public int drop_item_per_13 { get; set; } // 0x1B4
        public int drop_item_box_13 { get; set; } // 0x1B8
        public int drop_item_id_14 { get; set; } // 0x1BC
        public int drop_item_value_14 { get; set; } // 0x1C0
        public int drop_item_evolution_count_14 { get; set; } // 0x1C4
        public int drop_item_per_14 { get; set; } // 0x1C8
        public int drop_item_box_14 { get; set; } // 0x1CC
        public int drop_item_id_15 { get; set; } // 0x1D0
        public int drop_item_value_15 { get; set; } // 0x1D4
        public int drop_item_evolution_count_15 { get; set; } // 0x1D8
        public int drop_item_per_15 { get; set; } // 0x1DC
        public int drop_item_box_15 { get; set; } // 0x1E0
        public int is_turn_pivot { get; set; } // 0x1E4
        public string stage_placement { get; set; } // 0x1E8
        public int stage_hero_entry_all { get; set; } // 0x1F0
        public int phase1_monster_ai_id { get; set; } // 0x1F4
        public int phase1_image { get; set; } // 0x1F8
        public int phase1_boss_effect_id { get; set; } // 0x1FC
        public int phase1_boss_atk_inc_per { get; set; } // 0x200
        public int phase1_boss_def_inc_per { get; set; } // 0x204
        public int phase1_boss_hp_inc_per { get; set; } // 0x208
        public int phase1_boss_id_1 { get; set; } // 0x20C
        public int phase1_boss_level_1 { get; set; } // 0x210
        public string phase1_array_passive1 { get; set; } // 0x218
        public List<int> list_phase1_array_passive1 = new List<int>(); // 0x220
        public int phase1_boss_material_box_1 { get; set; } // 0x228
        public int phase1_boss_id_2 { get; set; } // 0x22C
        public int phase1_boss_level_2 { get; set; } // 0x230
        public string phase1_array_passive2 { get; set; } // 0x238
        public List<int> list_phase1_array_passive2 = new List<int>(); // 0x240
        public int phase1_boss_material_box_2 { get; set; } // 0x248
        public int phase1_boss_id_3 { get; set; } // 0x24C
        public int phase1_boss_level_3 { get; set; } // 0x250
        public string phase1_array_passive3 { get; set; } // 0x258
        public List<int> list_phase1_array_passive3 = new List<int>(); // 0x260
        public int phase1_boss_material_box_3 { get; set; } // 0x268
        public int phase2_monster_ai_id { get; set; } // 0x26C
        public int phase2_image { get; set; } // 0x270
        public int phase2_boss_effect_id { get; set; } // 0x274
        public int phase2_boss_atk_inc_per { get; set; } // 0x278
        public int phase2_boss_def_inc_per { get; set; } // 0x27C
        public int phase2_boss_hp_inc_per { get; set; } // 0x280
        public int phase2_boss_id_1 { get; set; } // 0x284
        public int phase2_boss_level_1 { get; set; } // 0x288
        public string phase2_array_passive1 { get; set; } // 0x290
        public List<int> list_phase2_array_passive1 = new List<int>(); // 0x298
        public int phase2_boss_material_box_1 { get; set; } // 0x2A0
        public int phase2_boss_id_2 { get; set; } // 0x2A4
        public int phase2_boss_level_2 { get; set; } // 0x2A8
        public string phase2_array_passive2 { get; set; } // 0x2B0
        public List<int> list_phase2_array_passive2 = new List<int>(); // 0x2B8
        public int phase2_boss_material_box_2 { get; set; } // 0x2C0
        public int phase2_boss_id_3 { get; set; } // 0x2C4
        public int phase2_boss_level_3 { get; set; } // 0x2C8
        public string phase2_array_passive3 { get; set; } // 0x2D0
        public List<int> list_phase2_array_passive3 = new List<int>(); // 0x2D8
        public int phase2_boss_material_box_3 { get; set; } // 0x2E0
        public int phase3_monster_ai_id { get; set; } // 0x2E4
        public int phase3_image { get; set; } // 0x2E8
        public int phase3_boss_effect_id { get; set; } // 0x2EC
        public int phase3_boss_atk_inc_per { get; set; } // 0x2F0
        public int phase3_boss_def_inc_per { get; set; } // 0x2F4
        public int phase3_boss_hp_inc_per { get; set; } // 0x2F8
        public int Phase3_boss_id_1 { get; set; } // 0x2FC
        public int Phase3_boss_level_1 { get; set; } // 0x300
        public string phase3_array_passive1 { get; set; } // 0x308
        public List<int> list_phase3_array_passive1 = new List<int>(); // 0x310
        public int phase3_boss_material_box_1 { get; set; } // 0x318
        public int Phase3_boss_id_2 { get; set; } // 0x31C
        public int Phase3_boss_level_2 { get; set; } // 0x320
        public string phase3_array_passive2 { get; set; } // 0x328
        public List<int> list_phase3_array_passive2 = new List<int>(); // 0x330
        public int phase3_boss_material_box_2 { get; set; } // 0x338
        public int Phase3_boss_id_3 { get; set; } // 0x33C
        public int Phase3_boss_level_3 { get; set; } // 0x340
        public string phase3_array_passive3 { get; set; } // 0x348
        public List<int> list_phase3_array_passive3 = new List<int>(); // 0x350
        public int phase3_boss_material_box_3 { get; set; } // 0x358
        public int play_boss_spawn { get; set; } // 0x35C
        public string boss_entry_type { get; set; } // 0x360
        public string array_ally_passive_id { get; set; } // 0x368
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x370
        public string map_filename { get; set; } // 0x378
        public string spawn_prop_filename { get; set; } // 0x380
        public string change_map_filename { get; set; } // 0x388
        public int bgm_sound_id { get; set; } // 0x390
        public int boss_sound_id { get; set; } // 0x394
        public string EssenCondition_1 { get; set; } // 0x398
        public int EssenConditionValue_1 { get; set; } // 0x3A0
        public string EssenCondition_2 { get; set; } // 0x3A8
        public int EssenConditionValue_2 { get; set; } // 0x3B0
        public string EssenCondition_3 { get; set; } // 0x3B8
        public int EssenConditionValue_3 { get; set; } // 0x3C0
        public string EssenCondition_4 { get; set; } // 0x3C8
        public int EssenConditionValue_4 { get; set; } // 0x3D0
        public string BanCondition_1 { get; set; } // 0x3D8
        public int BanConditionValue_1 { get; set; } // 0x3E0
        public string BanCondition_2 { get; set; } // 0x3E8
        public int BanConditionValue_2 { get; set; } // 0x3F0
        public string BanCondition_3 { get; set; } // 0x3F8
        public int BanConditionValue_3 { get; set; } // 0x400
        public string BanCondition_4 { get; set; } // 0x408
        public int BanConditionValue_4 { get; set; } // 0x410
        public string BanCondition_5 { get; set; } // 0x418
        public int BanConditionValue_5 { get; set; } // 0x420
        public string BanCondition_6 { get; set; } // 0x428
        public int BanConditionValue_6 { get; set; } // 0x430
        public int npc_team_id { get; set; } // 0x434
        public List<int> list_story_id = new List<int>(); // 0x438
        public List<int> list_drop_item_id = new List<int>(); // 0x440
        public List<int> list_drop_item_value = new List<int>(); // 0x448
        public List<int> list_drop_item_evolution_count = new List<int>(); // 0x450
        public List<int> list_drop_item_per = new List<int>(); // 0x458
        public List<int> list_drop_item_box = new List<int>(); // 0x460
        public List<int> list_phase1_boss_id = new List<int>(); // 0x468
        public List<int> list_phase1_boss_level = new List<int>(); // 0x470
        public List<int> list_phase1_boss_material_box = new List<int>(); // 0x478
        public List<int> list_phase2_boss_id = new List<int>(); // 0x480
        public List<int> list_phase2_boss_level = new List<int>(); // 0x488
        public List<int> list_phase2_boss_material_box = new List<int>(); // 0x490
        public List<int> list_Phase3_boss_id = new List<int>(); // 0x498
        public List<int> list_Phase3_boss_level = new List<int>(); // 0x4A0
        public List<int> list_phase3_boss_material_box = new List<int>(); // 0x4A8
        public List<string> list_EssenCondition = new List<string>(); // 0x4B0
        public List<int> list_EssenConditionValue = new List<int>(); // 0x4B8
        public List<string> list_BanCondition = new List<string>(); // 0x4C0
        public List<int> list_BanConditionValue = new List<int>(); // 0x4C8
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            final_boss_point_group_id = reader.ReadInt32();
            stage_type = reader.ReadString();
            control_type = reader.ReadString();
            limit_index = reader.ReadInt32();
            region = reader.ReadInt32();
            final_boss_index = reader.ReadInt32();
            area = reader.ReadInt32();
            need_stage_type = reader.ReadString();
            need_stage_id = reader.ReadInt32();
            difficulty = reader.ReadInt32();
            difficulty_string = reader.ReadString();
            before_loading_id = reader.ReadInt32();
            after_loading_id = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            team_power = reader.ReadInt32();
            need_open_item_id = reader.ReadInt32();
            need_open_count = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            first_evolution_count = reader.ReadInt32();
            clear_item_box = reader.ReadInt32();
            clear_reward_id = reader.ReadInt32();
            clear_reward_value = reader.ReadInt32();
            drop_item_boss_min_count = reader.ReadInt32();
            drop_item_boss_max_count = reader.ReadInt32();
            monster_material_per = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_item_value_1 = reader.ReadInt32();
            drop_item_evolution_count_1 = reader.ReadInt32();
            drop_item_per_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_item_value_2 = reader.ReadInt32();
            drop_item_evolution_count_2 = reader.ReadInt32();
            drop_item_per_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_item_value_3 = reader.ReadInt32();
            drop_item_evolution_count_3 = reader.ReadInt32();
            drop_item_per_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            drop_item_id_4 = reader.ReadInt32();
            drop_item_value_4 = reader.ReadInt32();
            drop_item_evolution_count_4 = reader.ReadInt32();
            drop_item_per_4 = reader.ReadInt32();
            drop_item_box_4 = reader.ReadInt32();
            drop_item_id_5 = reader.ReadInt32();
            drop_item_value_5 = reader.ReadInt32();
            drop_item_evolution_count_5 = reader.ReadInt32();
            drop_item_per_5 = reader.ReadInt32();
            drop_item_box_5 = reader.ReadInt32();
            drop_item_id_6 = reader.ReadInt32();
            drop_item_value_6 = reader.ReadInt32();
            drop_item_evolution_count_6 = reader.ReadInt32();
            drop_item_per_6 = reader.ReadInt32();
            drop_item_box_6 = reader.ReadInt32();
            drop_item_id_7 = reader.ReadInt32();
            drop_item_value_7 = reader.ReadInt32();
            drop_item_evolution_count_7 = reader.ReadInt32();
            drop_item_per_7 = reader.ReadInt32();
            drop_item_box_7 = reader.ReadInt32();
            drop_item_id_8 = reader.ReadInt32();
            drop_item_value_8 = reader.ReadInt32();
            drop_item_evolution_count_8 = reader.ReadInt32();
            drop_item_per_8 = reader.ReadInt32();
            drop_item_box_8 = reader.ReadInt32();
            drop_item_id_9 = reader.ReadInt32();
            drop_item_value_9 = reader.ReadInt32();
            drop_item_evolution_count_9 = reader.ReadInt32();
            drop_item_per_9 = reader.ReadInt32();
            drop_item_box_9 = reader.ReadInt32();
            drop_item_id_10 = reader.ReadInt32();
            drop_item_value_10 = reader.ReadInt32();
            drop_item_evolution_count_10 = reader.ReadInt32();
            drop_item_per_10 = reader.ReadInt32();
            drop_item_box_10 = reader.ReadInt32();
            drop_item_id_11 = reader.ReadInt32();
            drop_item_value_11 = reader.ReadInt32();
            drop_item_evolution_count_11 = reader.ReadInt32();
            drop_item_per_11 = reader.ReadInt32();
            drop_item_box_11 = reader.ReadInt32();
            drop_item_id_12 = reader.ReadInt32();
            drop_item_value_12 = reader.ReadInt32();
            drop_item_evolution_count_12 = reader.ReadInt32();
            drop_item_per_12 = reader.ReadInt32();
            drop_item_box_12 = reader.ReadInt32();
            drop_item_id_13 = reader.ReadInt32();
            drop_item_value_13 = reader.ReadInt32();
            drop_item_evolution_count_13 = reader.ReadInt32();
            drop_item_per_13 = reader.ReadInt32();
            drop_item_box_13 = reader.ReadInt32();
            drop_item_id_14 = reader.ReadInt32();
            drop_item_value_14 = reader.ReadInt32();
            drop_item_evolution_count_14 = reader.ReadInt32();
            drop_item_per_14 = reader.ReadInt32();
            drop_item_box_14 = reader.ReadInt32();
            drop_item_id_15 = reader.ReadInt32();
            drop_item_value_15 = reader.ReadInt32();
            drop_item_evolution_count_15 = reader.ReadInt32();
            drop_item_per_15 = reader.ReadInt32();
            drop_item_box_15 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            stage_placement = reader.ReadString();
            stage_hero_entry_all = reader.ReadInt32();
            phase1_monster_ai_id = reader.ReadInt32();
            phase1_image = reader.ReadInt32();
            phase1_boss_effect_id = reader.ReadInt32();
            phase1_boss_atk_inc_per = reader.ReadInt32();
            phase1_boss_def_inc_per = reader.ReadInt32();
            phase1_boss_hp_inc_per = reader.ReadInt32();
            phase1_boss_id_1 = reader.ReadInt32();
            phase1_boss_level_1 = reader.ReadInt32();
            //phase1_array_passive1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_phase1_array_passive1.Add(reader.ReadInt32());
                v0--;
            }
            phase1_boss_material_box_1 = reader.ReadInt32();
            phase1_boss_id_2 = reader.ReadInt32();
            phase1_boss_level_2 = reader.ReadInt32();
            //phase1_array_passive2 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_phase1_array_passive2.Add(reader.ReadInt32());
                v1--;
            }
            phase1_boss_material_box_2 = reader.ReadInt32();
            phase1_boss_id_3 = reader.ReadInt32();
            phase1_boss_level_3 = reader.ReadInt32();
            //phase1_array_passive3 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_phase1_array_passive3.Add(reader.ReadInt32());
                v2--;
            }
            phase1_boss_material_box_3 = reader.ReadInt32();
            phase2_monster_ai_id = reader.ReadInt32();
            phase2_image = reader.ReadInt32();
            phase2_boss_effect_id = reader.ReadInt32();
            phase2_boss_atk_inc_per = reader.ReadInt32();
            phase2_boss_def_inc_per = reader.ReadInt32();
            phase2_boss_hp_inc_per = reader.ReadInt32();
            phase2_boss_id_1 = reader.ReadInt32();
            phase2_boss_level_1 = reader.ReadInt32();
            //phase2_array_passive1 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_phase2_array_passive1.Add(reader.ReadInt32());
                v3--;
            }
            phase2_boss_material_box_1 = reader.ReadInt32();
            phase2_boss_id_2 = reader.ReadInt32();
            phase2_boss_level_2 = reader.ReadInt32();
            //phase2_array_passive2 = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_phase2_array_passive2.Add(reader.ReadInt32());
                v4--;
            }
            phase2_boss_material_box_2 = reader.ReadInt32();
            phase2_boss_id_3 = reader.ReadInt32();
            phase2_boss_level_3 = reader.ReadInt32();
            //phase2_array_passive3 = reader.ReadString();
            var v5 = reader.ReadInt32();
            while ((v5 - 1) >= 0)
            {
                list_phase2_array_passive3.Add(reader.ReadInt32());
                v5--;
            }
            phase2_boss_material_box_3 = reader.ReadInt32();
            phase3_monster_ai_id = reader.ReadInt32();
            phase3_image = reader.ReadInt32();
            phase3_boss_effect_id = reader.ReadInt32();
            phase3_boss_atk_inc_per = reader.ReadInt32();
            phase3_boss_def_inc_per = reader.ReadInt32();
            phase3_boss_hp_inc_per = reader.ReadInt32();
            Phase3_boss_id_1 = reader.ReadInt32();
            Phase3_boss_level_1 = reader.ReadInt32();
            //phase3_array_passive1 = reader.ReadString();
            var v6 = reader.ReadInt32();
            while ((v6 - 1) >= 0)
            {
                list_phase3_array_passive1.Add(reader.ReadInt32());
                v6--;
            }
            phase3_boss_material_box_1 = reader.ReadInt32();
            Phase3_boss_id_2 = reader.ReadInt32();
            Phase3_boss_level_2 = reader.ReadInt32();
            //phase3_array_passive2 = reader.ReadString();
            var v7 = reader.ReadInt32();
            while ((v7 - 1) >= 0)
            {
                list_phase3_array_passive2.Add(reader.ReadInt32());
                v7--;
            }
            phase3_boss_material_box_2 = reader.ReadInt32();
            Phase3_boss_id_3 = reader.ReadInt32();
            Phase3_boss_level_3 = reader.ReadInt32();
            //phase3_array_passive3 = reader.ReadString();
            var v8 = reader.ReadInt32();
            while ((v8 - 1) >= 0)
            {
                list_phase3_array_passive3.Add(reader.ReadInt32());
                v8--;
            }
            phase3_boss_material_box_3 = reader.ReadInt32();
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v9 = reader.ReadInt32();
            while ((v9 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v9--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            npc_team_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageFinalBossBattlescoreRow
    {
        public int id { get; set; } // 0x10
        public int battlescore_group_id { get; set; } // 0x14
        public string checklist_name { get; set; } // 0x18
        public int battlescore_category { get; set; } // 0x20
        public string battlescore_type { get; set; } // 0x28
        public int client_visible { get; set; } // 0x30
        public float checklist_value { get; set; } // 0x34
        public string array_type_id { get; set; } // 0x38
        public List<int> list_array_type_id = new List<int>(); // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            battlescore_group_id = reader.ReadInt32();
            checklist_name = reader.ReadString();
            battlescore_category = reader.ReadInt32();
            battlescore_type = reader.ReadString();
            client_visible = reader.ReadInt32();
            checklist_value = reader.ReadSingle();
            //array_type_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_type_id.Add(reader.ReadInt32());
                v0--;
            }
            return true;
        }
    }
    public class DBStageFinalBossEventRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string stage_string { get; set; } // 0x20
        public int limit_index { get; set; } // 0x28
        public string control_type { get; set; } // 0x30
        public int region { get; set; } // 0x38
        public int final_boss_index { get; set; } // 0x3C
        public int area { get; set; } // 0x40
        public int need_quest_id { get; set; } // 0x44
        public string need_stage_type { get; set; } // 0x48
        public int need_stage_id { get; set; } // 0x50
        public int next_stage_id { get; set; } // 0x54
        public int difficulty { get; set; } // 0x58
        public string difficulty_string { get; set; } // 0x60
        public int before_loading_id { get; set; } // 0x68
        public int after_loading_id { get; set; } // 0x6C
        public int start_cut { get; set; } // 0x70
        public int end_cut { get; set; } // 0x74
        public int story_id_1 { get; set; } // 0x78
        public int story_id_2 { get; set; } // 0x7C
        public int story_id_3 { get; set; } // 0x80
        public int team_power { get; set; } // 0x84
        public int need_open_item_id { get; set; } // 0x88
        public int need_open_count { get; set; } // 0x8C
        public int need_stamina_item_id { get; set; } // 0x90
        public int need_stamina_count { get; set; } // 0x94
        public int user_exp { get; set; } // 0x98
        public int hero_exp { get; set; } // 0x9C
        public int gold_value { get; set; } // 0xA0
        public int first_reward_id { get; set; } // 0xA4
        public int first_reward_value { get; set; } // 0xA8
        public int first_evolution_count { get; set; } // 0xAC
        public int clear_item_box { get; set; } // 0xB0
        public int clear_reward_id { get; set; } // 0xB4
        public int clear_reward_value { get; set; } // 0xB8
        public int drop_item_boss_min_count { get; set; } // 0xBC
        public int drop_item_boss_max_count { get; set; } // 0xC0
        public int monster_material_per { get; set; } // 0xC4
        public int drop_item_id_1 { get; set; } // 0xC8
        public int drop_item_value_1 { get; set; } // 0xCC
        public int drop_item_evolution_count_1 { get; set; } // 0xD0
        public int drop_item_per_1 { get; set; } // 0xD4
        public int drop_item_box_1 { get; set; } // 0xD8
        public int drop_item_id_2 { get; set; } // 0xDC
        public int drop_item_value_2 { get; set; } // 0xE0
        public int drop_item_evolution_count_2 { get; set; } // 0xE4
        public int drop_item_per_2 { get; set; } // 0xE8
        public int drop_item_box_2 { get; set; } // 0xEC
        public int drop_item_id_3 { get; set; } // 0xF0
        public int drop_item_value_3 { get; set; } // 0xF4
        public int drop_item_evolution_count_3 { get; set; } // 0xF8
        public int drop_item_per_3 { get; set; } // 0xFC
        public int drop_item_box_3 { get; set; } // 0x100
        public int drop_item_id_4 { get; set; } // 0x104
        public int drop_item_value_4 { get; set; } // 0x108
        public int drop_item_evolution_count_4 { get; set; } // 0x10C
        public int drop_item_per_4 { get; set; } // 0x110
        public int drop_item_box_4 { get; set; } // 0x114
        public int drop_item_id_5 { get; set; } // 0x118
        public int drop_item_value_5 { get; set; } // 0x11C
        public int drop_item_evolution_count_5 { get; set; } // 0x120
        public int drop_item_per_5 { get; set; } // 0x124
        public int drop_item_box_5 { get; set; } // 0x128
        public int drop_item_id_6 { get; set; } // 0x12C
        public int drop_item_value_6 { get; set; } // 0x130
        public int drop_item_evolution_count_6 { get; set; } // 0x134
        public int drop_item_per_6 { get; set; } // 0x138
        public int drop_item_box_6 { get; set; } // 0x13C
        public int drop_item_id_7 { get; set; } // 0x140
        public int drop_item_value_7 { get; set; } // 0x144
        public int drop_item_evolution_count_7 { get; set; } // 0x148
        public int drop_item_per_7 { get; set; } // 0x14C
        public int drop_item_box_7 { get; set; } // 0x150
        public int drop_item_id_8 { get; set; } // 0x154
        public int drop_item_value_8 { get; set; } // 0x158
        public int drop_item_evolution_count_8 { get; set; } // 0x15C
        public int drop_item_per_8 { get; set; } // 0x160
        public int drop_item_box_8 { get; set; } // 0x164
        public int drop_item_id_9 { get; set; } // 0x168
        public int drop_item_value_9 { get; set; } // 0x16C
        public int drop_item_evolution_count_9 { get; set; } // 0x170
        public int drop_item_per_9 { get; set; } // 0x174
        public int drop_item_box_9 { get; set; } // 0x178
        public int drop_item_id_10 { get; set; } // 0x17C
        public int drop_item_value_10 { get; set; } // 0x180
        public int drop_item_evolution_count_10 { get; set; } // 0x184
        public int drop_item_per_10 { get; set; } // 0x188
        public int drop_item_box_10 { get; set; } // 0x18C
        public int drop_item_id_11 { get; set; } // 0x190
        public int drop_item_value_11 { get; set; } // 0x194
        public int drop_item_evolution_count_11 { get; set; } // 0x198
        public int drop_item_per_11 { get; set; } // 0x19C
        public int drop_item_box_11 { get; set; } // 0x1A0
        public int drop_item_id_12 { get; set; } // 0x1A4
        public int drop_item_value_12 { get; set; } // 0x1A8
        public int drop_item_evolution_count_12 { get; set; } // 0x1AC
        public int drop_item_per_12 { get; set; } // 0x1B0
        public int drop_item_box_12 { get; set; } // 0x1B4
        public int drop_item_id_13 { get; set; } // 0x1B8
        public int drop_item_value_13 { get; set; } // 0x1BC
        public int drop_item_evolution_count_13 { get; set; } // 0x1C0
        public int drop_item_per_13 { get; set; } // 0x1C4
        public int drop_item_box_13 { get; set; } // 0x1C8
        public int drop_item_id_14 { get; set; } // 0x1CC
        public int drop_item_value_14 { get; set; } // 0x1D0
        public int drop_item_evolution_count_14 { get; set; } // 0x1D4
        public int drop_item_per_14 { get; set; } // 0x1D8
        public int drop_item_box_14 { get; set; } // 0x1DC
        public int drop_item_id_15 { get; set; } // 0x1E0
        public int drop_item_value_15 { get; set; } // 0x1E4
        public int drop_item_evolution_count_15 { get; set; } // 0x1E8
        public int drop_item_per_15 { get; set; } // 0x1EC
        public int drop_item_box_15 { get; set; } // 0x1F0
        public int is_turn_pivot { get; set; } // 0x1F4
        public string stage_placement { get; set; } // 0x1F8
        public int stage_hero_entry_all { get; set; } // 0x200
        public int phase1_monster_ai_id { get; set; } // 0x204
        public int phase1_image { get; set; } // 0x208
        public int phase1_boss_effect_id { get; set; } // 0x20C
        public int phase1_boss_atk_inc_per { get; set; } // 0x210
        public int phase1_boss_def_inc_per { get; set; } // 0x214
        public int phase1_boss_hp_inc_per { get; set; } // 0x218
        public int phase1_boss_id_1 { get; set; } // 0x21C
        public int phase1_boss_level_1 { get; set; } // 0x220
        public string phase1_array_passive1 { get; set; } // 0x228
        public List<int> list_phase1_array_passive1 = new List<int>(); // 0x230
        public int phase1_boss_material_box_1 { get; set; } // 0x238
        public int phase1_boss_id_2 { get; set; } // 0x23C
        public int phase1_boss_level_2 { get; set; } // 0x240
        public string phase1_array_passive2 { get; set; } // 0x248
        public List<int> list_phase1_array_passive2 = new List<int>(); // 0x250
        public int phase1_boss_material_box_2 { get; set; } // 0x258
        public int phase1_boss_id_3 { get; set; } // 0x25C
        public int phase1_boss_level_3 { get; set; } // 0x260
        public string phase1_array_passive3 { get; set; } // 0x268
        public List<int> list_phase1_array_passive3 = new List<int>(); // 0x270
        public int phase1_boss_material_box_3 { get; set; } // 0x278
        public int phase2_monster_ai_id { get; set; } // 0x27C
        public int phase2_image { get; set; } // 0x280
        public int phase2_boss_effect_id { get; set; } // 0x284
        public int phase2_boss_atk_inc_per { get; set; } // 0x288
        public int phase2_boss_def_inc_per { get; set; } // 0x28C
        public int phase2_boss_hp_inc_per { get; set; } // 0x290
        public int phase2_boss_id_1 { get; set; } // 0x294
        public int phase2_boss_level_1 { get; set; } // 0x298
        public string phase2_array_passive1 { get; set; } // 0x2A0
        public List<int> list_phase2_array_passive1 = new List<int>(); // 0x2A8
        public int phase2_boss_material_box_1 { get; set; } // 0x2B0
        public int phase2_boss_id_2 { get; set; } // 0x2B4
        public int phase2_boss_level_2 { get; set; } // 0x2B8
        public string phase2_array_passive2 { get; set; } // 0x2C0
        public List<int> list_phase2_array_passive2 = new List<int>(); // 0x2C8
        public int phase2_boss_material_box_2 { get; set; } // 0x2D0
        public int phase2_boss_id_3 { get; set; } // 0x2D4
        public int phase2_boss_level_3 { get; set; } // 0x2D8
        public string phase2_array_passive3 { get; set; } // 0x2E0
        public List<int> list_phase2_array_passive3 = new List<int>(); // 0x2E8
        public int phase2_boss_material_box_3 { get; set; } // 0x2F0
        public int phase3_monster_ai_id { get; set; } // 0x2F4
        public int phase3_image { get; set; } // 0x2F8
        public int phase3_boss_effect_id { get; set; } // 0x2FC
        public int phase3_boss_atk_inc_per { get; set; } // 0x300
        public int phase3_boss_def_inc_per { get; set; } // 0x304
        public int phase3_boss_hp_inc_per { get; set; } // 0x308
        public int Phase3_boss_id_1 { get; set; } // 0x30C
        public int Phase3_boss_level_1 { get; set; } // 0x310
        public string phase3_array_passive1 { get; set; } // 0x318
        public List<int> list_phase3_array_passive1 = new List<int>(); // 0x320
        public int phase3_boss_material_box_1 { get; set; } // 0x328
        public int Phase3_boss_id_2 { get; set; } // 0x32C
        public int Phase3_boss_level_2 { get; set; } // 0x330
        public string phase3_array_passive2 { get; set; } // 0x338
        public List<int> list_phase3_array_passive2 = new List<int>(); // 0x340
        public int phase3_boss_material_box_2 { get; set; } // 0x348
        public int Phase3_boss_id_3 { get; set; } // 0x34C
        public int Phase3_boss_level_3 { get; set; } // 0x350
        public string phase3_array_passive3 { get; set; } // 0x358
        public List<int> list_phase3_array_passive3 = new List<int>(); // 0x360
        public int phase3_boss_material_box_3 { get; set; } // 0x368
        public int play_boss_spawn { get; set; } // 0x36C
        public string boss_entry_type { get; set; } // 0x370
        public string array_ally_passive_id { get; set; } // 0x378
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x380
        public string map_filename { get; set; } // 0x388
        public string spawn_prop_filename { get; set; } // 0x390
        public string change_map_filename { get; set; } // 0x398
        public int bgm_sound_id { get; set; } // 0x3A0
        public int boss_sound_id { get; set; } // 0x3A4
        public string EssenCondition_1 { get; set; } // 0x3A8
        public int EssenConditionValue_1 { get; set; } // 0x3B0
        public string EssenCondition_2 { get; set; } // 0x3B8
        public int EssenConditionValue_2 { get; set; } // 0x3C0
        public string EssenCondition_3 { get; set; } // 0x3C8
        public int EssenConditionValue_3 { get; set; } // 0x3D0
        public string EssenCondition_4 { get; set; } // 0x3D8
        public int EssenConditionValue_4 { get; set; } // 0x3E0
        public string BanCondition_1 { get; set; } // 0x3E8
        public int BanConditionValue_1 { get; set; } // 0x3F0
        public string BanCondition_2 { get; set; } // 0x3F8
        public int BanConditionValue_2 { get; set; } // 0x400
        public string BanCondition_3 { get; set; } // 0x408
        public int BanConditionValue_3 { get; set; } // 0x410
        public string BanCondition_4 { get; set; } // 0x418
        public int BanConditionValue_4 { get; set; } // 0x420
        public string BanCondition_5 { get; set; } // 0x428
        public int BanConditionValue_5 { get; set; } // 0x430
        public string BanCondition_6 { get; set; } // 0x438
        public int BanConditionValue_6 { get; set; } // 0x440
        public int npc_team_id { get; set; } // 0x444
        public List<int> list_story_id = new List<int>(); // 0x448
        public List<int> list_drop_item_id = new List<int>(); // 0x450
        public List<int> list_drop_item_value = new List<int>(); // 0x458
        public List<int> list_drop_item_evolution_count = new List<int>(); // 0x460
        public List<int> list_drop_item_per = new List<int>(); // 0x468
        public List<int> list_drop_item_box = new List<int>(); // 0x470
        public List<int> list_phase1_boss_id = new List<int>(); // 0x478
        public List<int> list_phase1_boss_level = new List<int>(); // 0x480
        public List<int> list_phase1_boss_material_box = new List<int>(); // 0x488
        public List<int> list_phase2_boss_id = new List<int>(); // 0x490
        public List<int> list_phase2_boss_level = new List<int>(); // 0x498
        public List<int> list_phase2_boss_material_box = new List<int>(); // 0x4A0
        public List<int> list_Phase3_boss_id = new List<int>(); // 0x4A8
        public List<int> list_Phase3_boss_level = new List<int>(); // 0x4B0
        public List<int> list_phase3_boss_material_box = new List<int>(); // 0x4B8
        public List<string> list_EssenCondition = new List<string>(); // 0x4C0
        public List<int> list_EssenConditionValue = new List<int>(); // 0x4C8
        public List<string> list_BanCondition = new List<string>(); // 0x4D0
        public List<int> list_BanConditionValue = new List<int>(); // 0x4D8
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            stage_string = reader.ReadString();
            limit_index = reader.ReadInt32();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            final_boss_index = reader.ReadInt32();
            area = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            need_stage_type = reader.ReadString();
            need_stage_id = reader.ReadInt32();
            next_stage_id = reader.ReadInt32();
            difficulty = reader.ReadInt32();
            difficulty_string = reader.ReadString();
            before_loading_id = reader.ReadInt32();
            after_loading_id = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            team_power = reader.ReadInt32();
            need_open_item_id = reader.ReadInt32();
            need_open_count = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            first_evolution_count = reader.ReadInt32();
            clear_item_box = reader.ReadInt32();
            clear_reward_id = reader.ReadInt32();
            clear_reward_value = reader.ReadInt32();
            drop_item_boss_min_count = reader.ReadInt32();
            drop_item_boss_max_count = reader.ReadInt32();
            monster_material_per = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_item_value_1 = reader.ReadInt32();
            drop_item_evolution_count_1 = reader.ReadInt32();
            drop_item_per_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_item_value_2 = reader.ReadInt32();
            drop_item_evolution_count_2 = reader.ReadInt32();
            drop_item_per_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_item_value_3 = reader.ReadInt32();
            drop_item_evolution_count_3 = reader.ReadInt32();
            drop_item_per_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            drop_item_id_4 = reader.ReadInt32();
            drop_item_value_4 = reader.ReadInt32();
            drop_item_evolution_count_4 = reader.ReadInt32();
            drop_item_per_4 = reader.ReadInt32();
            drop_item_box_4 = reader.ReadInt32();
            drop_item_id_5 = reader.ReadInt32();
            drop_item_value_5 = reader.ReadInt32();
            drop_item_evolution_count_5 = reader.ReadInt32();
            drop_item_per_5 = reader.ReadInt32();
            drop_item_box_5 = reader.ReadInt32();
            drop_item_id_6 = reader.ReadInt32();
            drop_item_value_6 = reader.ReadInt32();
            drop_item_evolution_count_6 = reader.ReadInt32();
            drop_item_per_6 = reader.ReadInt32();
            drop_item_box_6 = reader.ReadInt32();
            drop_item_id_7 = reader.ReadInt32();
            drop_item_value_7 = reader.ReadInt32();
            drop_item_evolution_count_7 = reader.ReadInt32();
            drop_item_per_7 = reader.ReadInt32();
            drop_item_box_7 = reader.ReadInt32();
            drop_item_id_8 = reader.ReadInt32();
            drop_item_value_8 = reader.ReadInt32();
            drop_item_evolution_count_8 = reader.ReadInt32();
            drop_item_per_8 = reader.ReadInt32();
            drop_item_box_8 = reader.ReadInt32();
            drop_item_id_9 = reader.ReadInt32();
            drop_item_value_9 = reader.ReadInt32();
            drop_item_evolution_count_9 = reader.ReadInt32();
            drop_item_per_9 = reader.ReadInt32();
            drop_item_box_9 = reader.ReadInt32();
            drop_item_id_10 = reader.ReadInt32();
            drop_item_value_10 = reader.ReadInt32();
            drop_item_evolution_count_10 = reader.ReadInt32();
            drop_item_per_10 = reader.ReadInt32();
            drop_item_box_10 = reader.ReadInt32();
            drop_item_id_11 = reader.ReadInt32();
            drop_item_value_11 = reader.ReadInt32();
            drop_item_evolution_count_11 = reader.ReadInt32();
            drop_item_per_11 = reader.ReadInt32();
            drop_item_box_11 = reader.ReadInt32();
            drop_item_id_12 = reader.ReadInt32();
            drop_item_value_12 = reader.ReadInt32();
            drop_item_evolution_count_12 = reader.ReadInt32();
            drop_item_per_12 = reader.ReadInt32();
            drop_item_box_12 = reader.ReadInt32();
            drop_item_id_13 = reader.ReadInt32();
            drop_item_value_13 = reader.ReadInt32();
            drop_item_evolution_count_13 = reader.ReadInt32();
            drop_item_per_13 = reader.ReadInt32();
            drop_item_box_13 = reader.ReadInt32();
            drop_item_id_14 = reader.ReadInt32();
            drop_item_value_14 = reader.ReadInt32();
            drop_item_evolution_count_14 = reader.ReadInt32();
            drop_item_per_14 = reader.ReadInt32();
            drop_item_box_14 = reader.ReadInt32();
            drop_item_id_15 = reader.ReadInt32();
            drop_item_value_15 = reader.ReadInt32();
            drop_item_evolution_count_15 = reader.ReadInt32();
            drop_item_per_15 = reader.ReadInt32();
            drop_item_box_15 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            stage_placement = reader.ReadString();
            stage_hero_entry_all = reader.ReadInt32();
            phase1_monster_ai_id = reader.ReadInt32();
            phase1_image = reader.ReadInt32();
            phase1_boss_effect_id = reader.ReadInt32();
            phase1_boss_atk_inc_per = reader.ReadInt32();
            phase1_boss_def_inc_per = reader.ReadInt32();
            phase1_boss_hp_inc_per = reader.ReadInt32();
            phase1_boss_id_1 = reader.ReadInt32();
            phase1_boss_level_1 = reader.ReadInt32();
            //phase1_array_passive1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_phase1_array_passive1.Add(reader.ReadInt32());
                v0--;
            }
            phase1_boss_material_box_1 = reader.ReadInt32();
            phase1_boss_id_2 = reader.ReadInt32();
            phase1_boss_level_2 = reader.ReadInt32();
            //phase1_array_passive2 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_phase1_array_passive2.Add(reader.ReadInt32());
                v1--;
            }
            phase1_boss_material_box_2 = reader.ReadInt32();
            phase1_boss_id_3 = reader.ReadInt32();
            phase1_boss_level_3 = reader.ReadInt32();
            //phase1_array_passive3 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_phase1_array_passive3.Add(reader.ReadInt32());
                v2--;
            }
            phase1_boss_material_box_3 = reader.ReadInt32();
            phase2_monster_ai_id = reader.ReadInt32();
            phase2_image = reader.ReadInt32();
            phase2_boss_effect_id = reader.ReadInt32();
            phase2_boss_atk_inc_per = reader.ReadInt32();
            phase2_boss_def_inc_per = reader.ReadInt32();
            phase2_boss_hp_inc_per = reader.ReadInt32();
            phase2_boss_id_1 = reader.ReadInt32();
            phase2_boss_level_1 = reader.ReadInt32();
            //phase2_array_passive1 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_phase2_array_passive1.Add(reader.ReadInt32());
                v3--;
            }
            phase2_boss_material_box_1 = reader.ReadInt32();
            phase2_boss_id_2 = reader.ReadInt32();
            phase2_boss_level_2 = reader.ReadInt32();
            //phase2_array_passive2 = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_phase2_array_passive2.Add(reader.ReadInt32());
                v4--;
            }
            phase2_boss_material_box_2 = reader.ReadInt32();
            phase2_boss_id_3 = reader.ReadInt32();
            phase2_boss_level_3 = reader.ReadInt32();
            //phase2_array_passive3 = reader.ReadString();
            var v5 = reader.ReadInt32();
            while ((v5 - 1) >= 0)
            {
                list_phase2_array_passive3.Add(reader.ReadInt32());
                v5--;
            }
            phase2_boss_material_box_3 = reader.ReadInt32();
            phase3_monster_ai_id = reader.ReadInt32();
            phase3_image = reader.ReadInt32();
            phase3_boss_effect_id = reader.ReadInt32();
            phase3_boss_atk_inc_per = reader.ReadInt32();
            phase3_boss_def_inc_per = reader.ReadInt32();
            phase3_boss_hp_inc_per = reader.ReadInt32();
            Phase3_boss_id_1 = reader.ReadInt32();
            Phase3_boss_level_1 = reader.ReadInt32();
            //phase3_array_passive1 = reader.ReadString();
            var v6 = reader.ReadInt32();
            while ((v6 - 1) >= 0)
            {
                list_phase3_array_passive1.Add(reader.ReadInt32());
                v6--;
            }
            phase3_boss_material_box_1 = reader.ReadInt32();
            Phase3_boss_id_2 = reader.ReadInt32();
            Phase3_boss_level_2 = reader.ReadInt32();
            //phase3_array_passive2 = reader.ReadString();
            var v7 = reader.ReadInt32();
            while ((v7 - 1) >= 0)
            {
                list_phase3_array_passive2.Add(reader.ReadInt32());
                v7--;
            }
            phase3_boss_material_box_2 = reader.ReadInt32();
            Phase3_boss_id_3 = reader.ReadInt32();
            Phase3_boss_level_3 = reader.ReadInt32();
            //phase3_array_passive3 = reader.ReadString();
            var v8 = reader.ReadInt32();
            while ((v8 - 1) >= 0)
            {
                list_phase3_array_passive3.Add(reader.ReadInt32());
                v8--;
            }
            phase3_boss_material_box_3 = reader.ReadInt32();
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v9 = reader.ReadInt32();
            while ((v9 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v9--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            npc_team_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageFinalBossGroupRow
    {
        public int group_id { get; set; } // 0x10
        public int group_hero_id_1 { get; set; } // 0x14
        public int group_hero_id_2 { get; set; } // 0x18
        public string group_string { get; set; } // 0x20
        public string stage_string { get; set; } // 0x28
        public string info_image_1 { get; set; } // 0x30
        public string info_image_2 { get; set; } // 0x38
        public string array_final_boss_strong_hero { get; set; } // 0x40
        public List<int> list_array_final_boss_strong_hero = new List<int>(); // 0x48
        public string final_boss_pattern_phase01_desc { get; set; } // 0x50
        public string final_boss_pattern_phase02_desc { get; set; } // 0x58
        public List<int> list_group_hero_id = new List<int>(); // 0x60
        public List<string> list_info_image = new List<string>(); // 0x68
        public bool ReadToStream(BinaryReader reader)
        {
            group_id = reader.ReadInt32();
            group_hero_id_1 = reader.ReadInt32();
            group_hero_id_2 = reader.ReadInt32();
            group_string = reader.ReadString();
            stage_string = reader.ReadString();
            info_image_1 = reader.ReadString();
            info_image_2 = reader.ReadString();
            //array_final_boss_strong_hero = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_final_boss_strong_hero.Add(reader.ReadInt32());
                v0--;
            }
            final_boss_pattern_phase01_desc = reader.ReadString();
            final_boss_pattern_phase02_desc = reader.ReadString();
            return true;
        }
    }
    public class DBStageFinalBossMissionRow
    {
        public int id { get; set; } // 0x10
        public int mission_group_id { get; set; } // 0x14
        public string mission_name { get; set; } // 0x18
        public string mission_type { get; set; } // 0x20
        public int mission_type_value { get; set; } // 0x28
        public int localize_display_type { get; set; } // 0x2C
        public float mission_reward_value { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            mission_group_id = reader.ReadInt32();
            mission_name = reader.ReadString();
            mission_type = reader.ReadString();
            mission_type_value = reader.ReadInt32();
            localize_display_type = reader.ReadInt32();
            mission_reward_value = reader.ReadSingle();
            return true;
        }
    }
    public class DBStageFinalBossRankRewardRow
    {
        public int id { get; set; } // 0x10
        public int rank_group_id { get; set; } // 0x14
        public string rank_type { get; set; } // 0x18
        public int rank_value_min { get; set; } // 0x20
        public int rank_value_max { get; set; } // 0x24
        public int rank_percentage_min { get; set; } // 0x28
        public int rank_percentage_max { get; set; } // 0x2C
        public int rank_reward_score { get; set; } // 0x30
        public int reward_id_1 { get; set; } // 0x34
        public int reward_count_1 { get; set; } // 0x38
        public int reward_id_2 { get; set; } // 0x3C
        public int reward_count_2 { get; set; } // 0x40
        public List<int> list_reward_id = new List<int>(); // 0x48
        public List<int> list_reward_count = new List<int>(); // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            rank_group_id = reader.ReadInt32();
            rank_type = reader.ReadString();
            rank_value_min = reader.ReadInt32();
            rank_value_max = reader.ReadInt32();
            rank_percentage_min = reader.ReadInt32();
            rank_percentage_max = reader.ReadInt32();
            rank_reward_score = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_count_1 = reader.ReadInt32();
            reward_id_2 = reader.ReadInt32();
            reward_count_2 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageFinalBossScoreGroupRow
    {
        public int final_boss_score_group_id { get; set; } // 0x10
        public string array_mission_group_id { get; set; } // 0x18
        public List<int> list_array_mission_group_id = new List<int>(); // 0x20
        public string array_battlescore_group_id { get; set; } // 0x28
        public List<int> list_array_battlescore_group_id = new List<int>(); // 0x30
        public int lotation_period { get; set; } // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            final_boss_score_group_id = reader.ReadInt32();
            //array_mission_group_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_mission_group_id.Add(reader.ReadInt32());
                v0--;
            }
            //array_battlescore_group_id = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_battlescore_group_id.Add(reader.ReadInt32());
                v1--;
            }
            lotation_period = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageFreeRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string stage_string { get; set; } // 0x20
        public int essen_hero_setting { get; set; } // 0x28
        public string control_type { get; set; } // 0x30
        public int region { get; set; } // 0x38
        public int free_index { get; set; } // 0x3C
        public int limit_index { get; set; } // 0x40
        public string need_stage_type { get; set; } // 0x48
        public int need_stage_id { get; set; } // 0x50
        public int need_base_fellow_id { get; set; } // 0x54
        public int need_base_fellow_level { get; set; } // 0x58
        public int need_hero_id { get; set; } // 0x5C
        public int need_quest_id { get; set; } // 0x60
        public int area { get; set; } // 0x64
        public int difficulty { get; set; } // 0x68
        public string difficulty_string { get; set; } // 0x70
        public int pre_start_cut { get; set; } // 0x78
        public int start_cut { get; set; } // 0x7C
        public int end_cut { get; set; } // 0x80
        public int story_id_1 { get; set; } // 0x84
        public int story_id_2 { get; set; } // 0x88
        public int story_id_3 { get; set; } // 0x8C
        public int need_stamina_item_id { get; set; } // 0x90
        public int need_stamina_count { get; set; } // 0x94
        public int team_power { get; set; } // 0x98
        public int monster_count { get; set; } // 0x9C
        public int monster_atk_inc_per { get; set; } // 0xA0
        public int monster_def_inc_per { get; set; } // 0xA4
        public int monster_hp_inc_per { get; set; } // 0xA8
        public int monster_level { get; set; } // 0xAC
        public int monster_id_1 { get; set; } // 0xB0
        public int monster_id_2 { get; set; } // 0xB4
        public int monster_id_3 { get; set; } // 0xB8
        public int monster_id_4 { get; set; } // 0xBC
        public int monster_id_5 { get; set; } // 0xC0
        public int monster_id_6 { get; set; } // 0xC4
        public int monster_id_7 { get; set; } // 0xC8
        public int monster_id_8 { get; set; } // 0xCC
        public int monster_material_box_1 { get; set; } // 0xD0
        public int is_turn_pivot { get; set; } // 0xD4
        public int set_boss_elite_ui { get; set; } // 0xD8
        public string stage_placement { get; set; } // 0xE0
        public int stage_hero_entry_all { get; set; } // 0xE8
        public int monster_ai_id { get; set; } // 0xEC
        public int boss_atk_inc_per { get; set; } // 0xF0
        public int boss_def_inc_per { get; set; } // 0xF4
        public int boss_hp_inc_per { get; set; } // 0xF8
        public int boss_id_1 { get; set; } // 0xFC
        public int boss_level_1 { get; set; } // 0x100
        public string array_passive1 { get; set; } // 0x108
        public List<int> list_array_passive1 = new List<int>(); // 0x110
        public int boss_material_box_1 { get; set; } // 0x118
        public int boss_id_2 { get; set; } // 0x11C
        public int boss_level_2 { get; set; } // 0x120
        public string array_passive2 { get; set; } // 0x128
        public List<int> list_array_passive2 = new List<int>(); // 0x130
        public int boss_material_box_2 { get; set; } // 0x138
        public int boss_id_3 { get; set; } // 0x13C
        public int boss_level_3 { get; set; } // 0x140
        public string array_passive3 { get; set; } // 0x148
        public List<int> list_array_passive3 = new List<int>(); // 0x150
        public int boss_material_box_3 { get; set; } // 0x158
        public int boss_id_4 { get; set; } // 0x15C
        public int boss_level_4 { get; set; } // 0x160
        public string array_passive4 { get; set; } // 0x168
        public List<int> list_array_passive4 = new List<int>(); // 0x170
        public int boss_material_box_4 { get; set; } // 0x178
        public int play_boss_spawn { get; set; } // 0x17C
        public string boss_entry_type { get; set; } // 0x180
        public string array_ally_passive_id { get; set; } // 0x188
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x190
        public string map_filename { get; set; } // 0x198
        public string spawn_prop_filename { get; set; } // 0x1A0
        public string change_map_filename { get; set; } // 0x1A8
        public int bgm_sound_id { get; set; } // 0x1B0
        public int boss_sound_id { get; set; } // 0x1B4
        public int user_exp { get; set; } // 0x1B8
        public int hero_exp { get; set; } // 0x1BC
        public int gold_value { get; set; } // 0x1C0
        public int first_reward_id { get; set; } // 0x1C4
        public int first_reward_value { get; set; } // 0x1C8
        public int drop_item_normal_min_count { get; set; } // 0x1CC
        public int drop_item_normal_max_count { get; set; } // 0x1D0
        public int drop_item_boss_min_count { get; set; } // 0x1D4
        public int drop_item_boss_max_count { get; set; } // 0x1D8
        public int monster_material_per { get; set; } // 0x1DC
        public int drop_item_id_1 { get; set; } // 0x1E0
        public int drop_item_value_1 { get; set; } // 0x1E4
        public int drop_item_evolution_count_1 { get; set; } // 0x1E8
        public int drop_item_per_1 { get; set; } // 0x1EC
        public int drop_item_box_1 { get; set; } // 0x1F0
        public int drop_item_id_2 { get; set; } // 0x1F4
        public int drop_item_value_2 { get; set; } // 0x1F8
        public int drop_item_evolution_count_2 { get; set; } // 0x1FC
        public int drop_item_per_2 { get; set; } // 0x200
        public int drop_item_box_2 { get; set; } // 0x204
        public int drop_item_id_3 { get; set; } // 0x208
        public int drop_item_value_3 { get; set; } // 0x20C
        public int drop_item_evolution_count_3 { get; set; } // 0x210
        public int drop_item_per_3 { get; set; } // 0x214
        public int drop_item_box_3 { get; set; } // 0x218
        public int drop_item_id_4 { get; set; } // 0x21C
        public int drop_item_value_4 { get; set; } // 0x220
        public int drop_item_evolution_count_4 { get; set; } // 0x224
        public int drop_item_per_4 { get; set; } // 0x228
        public int drop_item_box_4 { get; set; } // 0x22C
        public int drop_item_id_5 { get; set; } // 0x230
        public int drop_item_value_5 { get; set; } // 0x234
        public int drop_item_evolution_count_5 { get; set; } // 0x238
        public int drop_item_per_5 { get; set; } // 0x23C
        public int drop_item_box_5 { get; set; } // 0x240
        public int drop_item_id_6 { get; set; } // 0x244
        public int drop_item_value_6 { get; set; } // 0x248
        public int drop_item_evolution_count_6 { get; set; } // 0x24C
        public int drop_item_per_6 { get; set; } // 0x250
        public int drop_item_box_6 { get; set; } // 0x254
        public int drop_item_id_7 { get; set; } // 0x258
        public int drop_item_value_7 { get; set; } // 0x25C
        public int drop_item_evolution_count_7 { get; set; } // 0x260
        public int drop_item_per_7 { get; set; } // 0x264
        public int drop_item_box_7 { get; set; } // 0x268
        public int drop_item_id_8 { get; set; } // 0x26C
        public int drop_item_value_8 { get; set; } // 0x270
        public int drop_item_evolution_count_8 { get; set; } // 0x274
        public int drop_item_per_8 { get; set; } // 0x278
        public int drop_item_box_8 { get; set; } // 0x27C
        public int drop_item_id_9 { get; set; } // 0x280
        public int drop_item_value_9 { get; set; } // 0x284
        public int drop_item_evolution_count_9 { get; set; } // 0x288
        public int drop_item_per_9 { get; set; } // 0x28C
        public int drop_item_box_9 { get; set; } // 0x290
        public int drop_item_id_10 { get; set; } // 0x294
        public int drop_item_value_10 { get; set; } // 0x298
        public int drop_item_evolution_count_10 { get; set; } // 0x29C
        public int drop_item_per_10 { get; set; } // 0x2A0
        public int drop_item_box_10 { get; set; } // 0x2A4
        public int drop_item_id_11 { get; set; } // 0x2A8
        public int drop_item_value_11 { get; set; } // 0x2AC
        public int drop_item_evolution_count_11 { get; set; } // 0x2B0
        public int drop_item_per_11 { get; set; } // 0x2B4
        public int drop_item_box_11 { get; set; } // 0x2B8
        public int drop_item_id_12 { get; set; } // 0x2BC
        public int drop_item_value_12 { get; set; } // 0x2C0
        public int drop_item_evolution_count_12 { get; set; } // 0x2C4
        public int drop_item_per_12 { get; set; } // 0x2C8
        public int drop_item_box_12 { get; set; } // 0x2CC
        public int drop_item_id_13 { get; set; } // 0x2D0
        public int drop_item_value_13 { get; set; } // 0x2D4
        public int drop_item_evolution_count_13 { get; set; } // 0x2D8
        public int drop_item_per_13 { get; set; } // 0x2DC
        public int drop_item_box_13 { get; set; } // 0x2E0
        public int drop_item_id_14 { get; set; } // 0x2E4
        public int drop_item_value_14 { get; set; } // 0x2E8
        public int drop_item_evolution_count_14 { get; set; } // 0x2EC
        public int drop_item_per_14 { get; set; } // 0x2F0
        public int drop_item_box_14 { get; set; } // 0x2F4
        public int drop_item_id_15 { get; set; } // 0x2F8
        public int drop_item_value_15 { get; set; } // 0x2FC
        public int drop_item_evolution_count_15 { get; set; } // 0x300
        public int drop_item_per_15 { get; set; } // 0x304
        public int drop_item_box_15 { get; set; } // 0x308
        public string EssenCondition_1 { get; set; } // 0x310
        public int EssenConditionValue_1 { get; set; } // 0x318
        public string EssenCondition_2 { get; set; } // 0x320
        public int EssenConditionValue_2 { get; set; } // 0x328
        public string EssenCondition_3 { get; set; } // 0x330
        public int EssenConditionValue_3 { get; set; } // 0x338
        public string EssenCondition_4 { get; set; } // 0x340
        public int EssenConditionValue_4 { get; set; } // 0x348
        public string BanCondition_1 { get; set; } // 0x350
        public int BanConditionValue_1 { get; set; } // 0x358
        public string BanCondition_2 { get; set; } // 0x360
        public int BanConditionValue_2 { get; set; } // 0x368
        public string BanCondition_3 { get; set; } // 0x370
        public int BanConditionValue_3 { get; set; } // 0x378
        public string BanCondition_4 { get; set; } // 0x380
        public int BanConditionValue_4 { get; set; } // 0x388
        public string BanCondition_5 { get; set; } // 0x390
        public int BanConditionValue_5 { get; set; } // 0x398
        public string BanCondition_6 { get; set; } // 0x3A0
        public int BanConditionValue_6 { get; set; } // 0x3A8
        public int npc_team_id { get; set; } // 0x3AC
        public List<int> list_story_id = new List<int>(); // 0x3B0
        public List<int> list_monster_id = new List<int>(); // 0x3B8
        public List<int> list_monster_material_box = new List<int>(); // 0x3C0
        public List<int> list_boss_id = new List<int>(); // 0x3C8
        public List<int> list_boss_level = new List<int>(); // 0x3D0
        public List<int> list_boss_material_box = new List<int>(); // 0x3D8
        public List<int> list_drop_item_id = new List<int>(); // 0x3E0
        public List<int> list_drop_item_value = new List<int>(); // 0x3E8
        public List<int> list_drop_item_evolution_count = new List<int>(); // 0x3F0
        public List<int> list_drop_item_per = new List<int>(); // 0x3F8
        public List<int> list_drop_item_box = new List<int>(); // 0x400
        public List<string> list_EssenCondition = new List<string>(); // 0x408
        public List<int> list_EssenConditionValue = new List<int>(); // 0x410
        public List<string> list_BanCondition = new List<string>(); // 0x418
        public List<int> list_BanConditionValue = new List<int>(); // 0x420
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            stage_string = reader.ReadString();
            essen_hero_setting = reader.ReadInt32();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            free_index = reader.ReadInt32();
            limit_index = reader.ReadInt32();
            need_stage_type = reader.ReadString();
            need_stage_id = reader.ReadInt32();
            need_base_fellow_id = reader.ReadInt32();
            need_base_fellow_level = reader.ReadInt32();
            need_hero_id = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            area = reader.ReadInt32();
            difficulty = reader.ReadInt32();
            difficulty_string = reader.ReadString();
            pre_start_cut = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            team_power = reader.ReadInt32();
            monster_count = reader.ReadInt32();
            monster_atk_inc_per = reader.ReadInt32();
            monster_def_inc_per = reader.ReadInt32();
            monster_hp_inc_per = reader.ReadInt32();
            monster_level = reader.ReadInt32();
            monster_id_1 = reader.ReadInt32();
            monster_id_2 = reader.ReadInt32();
            monster_id_3 = reader.ReadInt32();
            monster_id_4 = reader.ReadInt32();
            monster_id_5 = reader.ReadInt32();
            monster_id_6 = reader.ReadInt32();
            monster_id_7 = reader.ReadInt32();
            monster_id_8 = reader.ReadInt32();
            monster_material_box_1 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            set_boss_elite_ui = reader.ReadInt32();
            stage_placement = reader.ReadString();
            stage_hero_entry_all = reader.ReadInt32();
            monster_ai_id = reader.ReadInt32();
            boss_atk_inc_per = reader.ReadInt32();
            boss_def_inc_per = reader.ReadInt32();
            boss_hp_inc_per = reader.ReadInt32();
            boss_id_1 = reader.ReadInt32();
            boss_level_1 = reader.ReadInt32();
            //array_passive1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v0--;
            }
            boss_material_box_1 = reader.ReadInt32();
            boss_id_2 = reader.ReadInt32();
            boss_level_2 = reader.ReadInt32();
            //array_passive2 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v1--;
            }
            boss_material_box_2 = reader.ReadInt32();
            boss_id_3 = reader.ReadInt32();
            boss_level_3 = reader.ReadInt32();
            //array_passive3 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v2--;
            }
            boss_material_box_3 = reader.ReadInt32();
            boss_id_4 = reader.ReadInt32();
            boss_level_4 = reader.ReadInt32();
            //array_passive4 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_passive4.Add(reader.ReadInt32());
                v3--;
            }
            boss_material_box_4 = reader.ReadInt32();
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v4--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            drop_item_normal_min_count = reader.ReadInt32();
            drop_item_normal_max_count = reader.ReadInt32();
            drop_item_boss_min_count = reader.ReadInt32();
            drop_item_boss_max_count = reader.ReadInt32();
            monster_material_per = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_item_value_1 = reader.ReadInt32();
            drop_item_evolution_count_1 = reader.ReadInt32();
            drop_item_per_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_item_value_2 = reader.ReadInt32();
            drop_item_evolution_count_2 = reader.ReadInt32();
            drop_item_per_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_item_value_3 = reader.ReadInt32();
            drop_item_evolution_count_3 = reader.ReadInt32();
            drop_item_per_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            drop_item_id_4 = reader.ReadInt32();
            drop_item_value_4 = reader.ReadInt32();
            drop_item_evolution_count_4 = reader.ReadInt32();
            drop_item_per_4 = reader.ReadInt32();
            drop_item_box_4 = reader.ReadInt32();
            drop_item_id_5 = reader.ReadInt32();
            drop_item_value_5 = reader.ReadInt32();
            drop_item_evolution_count_5 = reader.ReadInt32();
            drop_item_per_5 = reader.ReadInt32();
            drop_item_box_5 = reader.ReadInt32();
            drop_item_id_6 = reader.ReadInt32();
            drop_item_value_6 = reader.ReadInt32();
            drop_item_evolution_count_6 = reader.ReadInt32();
            drop_item_per_6 = reader.ReadInt32();
            drop_item_box_6 = reader.ReadInt32();
            drop_item_id_7 = reader.ReadInt32();
            drop_item_value_7 = reader.ReadInt32();
            drop_item_evolution_count_7 = reader.ReadInt32();
            drop_item_per_7 = reader.ReadInt32();
            drop_item_box_7 = reader.ReadInt32();
            drop_item_id_8 = reader.ReadInt32();
            drop_item_value_8 = reader.ReadInt32();
            drop_item_evolution_count_8 = reader.ReadInt32();
            drop_item_per_8 = reader.ReadInt32();
            drop_item_box_8 = reader.ReadInt32();
            drop_item_id_9 = reader.ReadInt32();
            drop_item_value_9 = reader.ReadInt32();
            drop_item_evolution_count_9 = reader.ReadInt32();
            drop_item_per_9 = reader.ReadInt32();
            drop_item_box_9 = reader.ReadInt32();
            drop_item_id_10 = reader.ReadInt32();
            drop_item_value_10 = reader.ReadInt32();
            drop_item_evolution_count_10 = reader.ReadInt32();
            drop_item_per_10 = reader.ReadInt32();
            drop_item_box_10 = reader.ReadInt32();
            drop_item_id_11 = reader.ReadInt32();
            drop_item_value_11 = reader.ReadInt32();
            drop_item_evolution_count_11 = reader.ReadInt32();
            drop_item_per_11 = reader.ReadInt32();
            drop_item_box_11 = reader.ReadInt32();
            drop_item_id_12 = reader.ReadInt32();
            drop_item_value_12 = reader.ReadInt32();
            drop_item_evolution_count_12 = reader.ReadInt32();
            drop_item_per_12 = reader.ReadInt32();
            drop_item_box_12 = reader.ReadInt32();
            drop_item_id_13 = reader.ReadInt32();
            drop_item_value_13 = reader.ReadInt32();
            drop_item_evolution_count_13 = reader.ReadInt32();
            drop_item_per_13 = reader.ReadInt32();
            drop_item_box_13 = reader.ReadInt32();
            drop_item_id_14 = reader.ReadInt32();
            drop_item_value_14 = reader.ReadInt32();
            drop_item_evolution_count_14 = reader.ReadInt32();
            drop_item_per_14 = reader.ReadInt32();
            drop_item_box_14 = reader.ReadInt32();
            drop_item_id_15 = reader.ReadInt32();
            drop_item_value_15 = reader.ReadInt32();
            drop_item_evolution_count_15 = reader.ReadInt32();
            drop_item_per_15 = reader.ReadInt32();
            drop_item_box_15 = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            npc_team_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageGlobalDropRow
    {
        public int group_id { get; set; } // 0x10
        public int global_drop_item_max { get; set; } // 0x14
        public int global_box_min { get; set; } // 0x18
        public int global_box_max { get; set; } // 0x1C
        public int global_drop_item_id_1 { get; set; } // 0x20
        public int global_drop_item_count_1 { get; set; } // 0x24
        public int global_drop_item_per_1 { get; set; } // 0x28
        public int global_drop_item_evolution_1 { get; set; } // 0x2C
        public int global_drop_item_box_1 { get; set; } // 0x30
        public int global_drop_item_id_2 { get; set; } // 0x34
        public int global_drop_item_count_2 { get; set; } // 0x38
        public int global_drop_item_per_2 { get; set; } // 0x3C
        public int global_drop_item_evolution_2 { get; set; } // 0x40
        public int global_drop_item_box_2 { get; set; } // 0x44
        public int global_drop_item_id_3 { get; set; } // 0x48
        public int global_drop_item_count_3 { get; set; } // 0x4C
        public int global_drop_item_per_3 { get; set; } // 0x50
        public int global_drop_item_evolution_3 { get; set; } // 0x54
        public int global_drop_item_box_3 { get; set; } // 0x58
        public int global_drop_item_id_4 { get; set; } // 0x5C
        public int global_drop_item_count_4 { get; set; } // 0x60
        public int global_drop_item_per_4 { get; set; } // 0x64
        public int global_drop_item_evolution_4 { get; set; } // 0x68
        public int global_drop_item_box_4 { get; set; } // 0x6C
        public int global_drop_item_id_5 { get; set; } // 0x70
        public int global_drop_item_count_5 { get; set; } // 0x74
        public int global_drop_item_per_5 { get; set; } // 0x78
        public int global_drop_item_evolution_5 { get; set; } // 0x7C
        public int global_drop_item_box_5 { get; set; } // 0x80
        public int global_drop_item_id_6 { get; set; } // 0x84
        public int global_drop_item_count_6 { get; set; } // 0x88
        public int global_drop_item_per_6 { get; set; } // 0x8C
        public int global_drop_item_evolution_6 { get; set; } // 0x90
        public int global_drop_item_box_6 { get; set; } // 0x94
        public int global_drop_item_id_7 { get; set; } // 0x98
        public int global_drop_item_count_7 { get; set; } // 0x9C
        public int global_drop_item_per_7 { get; set; } // 0xA0
        public int global_drop_item_evolution_7 { get; set; } // 0xA4
        public int global_drop_item_box_7 { get; set; } // 0xA8
        public int global_drop_item_id_8 { get; set; } // 0xAC
        public int global_drop_item_count_8 { get; set; } // 0xB0
        public int global_drop_item_per_8 { get; set; } // 0xB4
        public int global_drop_item_evolution_8 { get; set; } // 0xB8
        public int global_drop_item_box_8 { get; set; } // 0xBC
        public int global_drop_item_id_9 { get; set; } // 0xC0
        public int global_drop_item_count_9 { get; set; } // 0xC4
        public int global_drop_item_per_9 { get; set; } // 0xC8
        public int global_drop_item_evolution_9 { get; set; } // 0xCC
        public int global_drop_item_box_9 { get; set; } // 0xD0
        public int global_drop_item_id_10 { get; set; } // 0xD4
        public int global_drop_item_count_10 { get; set; } // 0xD8
        public int global_drop_item_per_10 { get; set; } // 0xDC
        public int global_drop_item_evolution_10 { get; set; } // 0xE0
        public int global_drop_item_box_10 { get; set; } // 0xE4
        public List<int> list_global_drop_item_id = new List<int>(); // 0xE8
        public List<int> list_global_drop_item_count = new List<int>(); // 0xF0
        public List<int> list_global_drop_item_per = new List<int>(); // 0xF8
        public List<int> list_global_drop_item_evolution = new List<int>(); // 0x100
        public List<int> list_global_drop_item_box = new List<int>(); // 0x108
        public bool ReadToStream(BinaryReader reader)
        {
            group_id = reader.ReadInt32();
            global_drop_item_max = reader.ReadInt32();
            global_box_min = reader.ReadInt32();
            global_box_max = reader.ReadInt32();
            global_drop_item_id_1 = reader.ReadInt32();
            global_drop_item_count_1 = reader.ReadInt32();
            global_drop_item_per_1 = reader.ReadInt32();
            global_drop_item_evolution_1 = reader.ReadInt32();
            global_drop_item_box_1 = reader.ReadInt32();
            global_drop_item_id_2 = reader.ReadInt32();
            global_drop_item_count_2 = reader.ReadInt32();
            global_drop_item_per_2 = reader.ReadInt32();
            global_drop_item_evolution_2 = reader.ReadInt32();
            global_drop_item_box_2 = reader.ReadInt32();
            global_drop_item_id_3 = reader.ReadInt32();
            global_drop_item_count_3 = reader.ReadInt32();
            global_drop_item_per_3 = reader.ReadInt32();
            global_drop_item_evolution_3 = reader.ReadInt32();
            global_drop_item_box_3 = reader.ReadInt32();
            global_drop_item_id_4 = reader.ReadInt32();
            global_drop_item_count_4 = reader.ReadInt32();
            global_drop_item_per_4 = reader.ReadInt32();
            global_drop_item_evolution_4 = reader.ReadInt32();
            global_drop_item_box_4 = reader.ReadInt32();
            global_drop_item_id_5 = reader.ReadInt32();
            global_drop_item_count_5 = reader.ReadInt32();
            global_drop_item_per_5 = reader.ReadInt32();
            global_drop_item_evolution_5 = reader.ReadInt32();
            global_drop_item_box_5 = reader.ReadInt32();
            global_drop_item_id_6 = reader.ReadInt32();
            global_drop_item_count_6 = reader.ReadInt32();
            global_drop_item_per_6 = reader.ReadInt32();
            global_drop_item_evolution_6 = reader.ReadInt32();
            global_drop_item_box_6 = reader.ReadInt32();
            global_drop_item_id_7 = reader.ReadInt32();
            global_drop_item_count_7 = reader.ReadInt32();
            global_drop_item_per_7 = reader.ReadInt32();
            global_drop_item_evolution_7 = reader.ReadInt32();
            global_drop_item_box_7 = reader.ReadInt32();
            global_drop_item_id_8 = reader.ReadInt32();
            global_drop_item_count_8 = reader.ReadInt32();
            global_drop_item_per_8 = reader.ReadInt32();
            global_drop_item_evolution_8 = reader.ReadInt32();
            global_drop_item_box_8 = reader.ReadInt32();
            global_drop_item_id_9 = reader.ReadInt32();
            global_drop_item_count_9 = reader.ReadInt32();
            global_drop_item_per_9 = reader.ReadInt32();
            global_drop_item_evolution_9 = reader.ReadInt32();
            global_drop_item_box_9 = reader.ReadInt32();
            global_drop_item_id_10 = reader.ReadInt32();
            global_drop_item_count_10 = reader.ReadInt32();
            global_drop_item_per_10 = reader.ReadInt32();
            global_drop_item_evolution_10 = reader.ReadInt32();
            global_drop_item_box_10 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageGlobalTypeRow
    {
        public int id { get; set; } // 0x10
        public string stage_type { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            stage_type = reader.ReadString();
            return true;
        }
    }
    public class DBStageGuildWarRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string stage_string { get; set; } // 0x20
        public string control_type { get; set; } // 0x28
        public int region { get; set; } // 0x30
        public int guild_war_area_id { get; set; } // 0x34
        public int index { get; set; } // 0x38
        public int need_stamina_item_id { get; set; } // 0x3C
        public int need_stamina_count { get; set; } // 0x40
        public int reward_id_1 { get; set; } // 0x44
        public int reward_value_1 { get; set; } // 0x48
        public int reward_value_box_1 { get; set; } // 0x4C
        public int is_turn_pivot { get; set; } // 0x50
        public int play_boss_spawn { get; set; } // 0x54
        public string boss_entry_type { get; set; } // 0x58
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x60
        public string map_filename { get; set; } // 0x68
        public string spawn_prop_filename { get; set; } // 0x70
        public string change_map_filename { get; set; } // 0x78
        public int bgm_sound_id { get; set; } // 0x80
        public int boss_sound_id { get; set; } // 0x84
        public int Hrun_reward_max_value { get; set; } // 0x88
        public string Hrun_map { get; set; } // 0x90
        public string Hrun_bg { get; set; } // 0x98
        public int npc_team_id { get; set; } // 0xA0
        public List<int> list_reward_id = new List<int>(); // 0xA8
        public List<int> list_reward_value = new List<int>(); // 0xB0
        public List<int> list_reward_value_box = new List<int>(); // 0xB8
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            stage_string = reader.ReadString();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            guild_war_area_id = reader.ReadInt32();
            index = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_value_1 = reader.ReadInt32();
            reward_value_box_1 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v0--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            Hrun_reward_max_value = reader.ReadInt32();
            Hrun_map = reader.ReadString();
            Hrun_bg = reader.ReadString();
            npc_team_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageLimitedRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public int open_quest_id { get; set; } // 0x20
        public int start_quest_id { get; set; } // 0x24
        public string stage_close { get; set; } // 0x28
        public string stage_string { get; set; } // 0x30
        public string control_type { get; set; } // 0x38
        public int region { get; set; } // 0x40
        public int limited_index { get; set; } // 0x44
        public int need_stage_id { get; set; } // 0x48
        public int area { get; set; } // 0x4C
        public int start_cut { get; set; } // 0x50
        public int end_cut { get; set; } // 0x54
        public int story_id_1 { get; set; } // 0x58
        public int story_id_2 { get; set; } // 0x5C
        public int story_id_3 { get; set; } // 0x60
        public int need_stamina_item_id { get; set; } // 0x64
        public int need_stamina_count { get; set; } // 0x68
        public int team_power { get; set; } // 0x6C
        public int monster_count { get; set; } // 0x70
        public int monster_atk_inc_per { get; set; } // 0x74
        public int monster_def_inc_per { get; set; } // 0x78
        public int monster_hp_inc_per { get; set; } // 0x7C
        public int monster_level { get; set; } // 0x80
        public int monster_id_1 { get; set; } // 0x84
        public int monster_id_2 { get; set; } // 0x88
        public int monster_id_3 { get; set; } // 0x8C
        public int monster_id_4 { get; set; } // 0x90
        public int monster_id_5 { get; set; } // 0x94
        public int monster_id_6 { get; set; } // 0x98
        public int monster_id_7 { get; set; } // 0x9C
        public int monster_id_8 { get; set; } // 0xA0
        public int monster_material_box_1 { get; set; } // 0xA4
        public int is_turn_pivot { get; set; } // 0xA8
        public int set_boss_elite_ui { get; set; } // 0xAC
        public string stage_placement { get; set; } // 0xB0
        public int stage_hero_entry_all { get; set; } // 0xB8
        public int monster_ai_id { get; set; } // 0xBC
        public int boss_atk_inc_per { get; set; } // 0xC0
        public int boss_def_inc_per { get; set; } // 0xC4
        public int boss_hp_inc_per { get; set; } // 0xC8
        public int boss_id_1 { get; set; } // 0xCC
        public int boss_level_1 { get; set; } // 0xD0
        public string array_passive1 { get; set; } // 0xD8
        public List<int> list_array_passive1 = new List<int>(); // 0xE0
        public int boss_material_box_1 { get; set; } // 0xE8
        public int boss_id_2 { get; set; } // 0xEC
        public int boss_level_2 { get; set; } // 0xF0
        public string array_passive2 { get; set; } // 0xF8
        public List<int> list_array_passive2 = new List<int>(); // 0x100
        public int boss_material_box_2 { get; set; } // 0x108
        public int boss_id_3 { get; set; } // 0x10C
        public int boss_level_3 { get; set; } // 0x110
        public string array_passive3 { get; set; } // 0x118
        public List<int> list_array_passive3 = new List<int>(); // 0x120
        public int boss_material_box_3 { get; set; } // 0x128
        public int boss_id_4 { get; set; } // 0x12C
        public int boss_level_4 { get; set; } // 0x130
        public string array_passive4 { get; set; } // 0x138
        public List<int> list_array_passive4 = new List<int>(); // 0x140
        public int boss_material_box_4 { get; set; } // 0x148
        public int play_boss_spawn { get; set; } // 0x14C
        public string boss_entry_type { get; set; } // 0x150
        public string array_ally_passive_id { get; set; } // 0x158
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x160
        public string map_filename { get; set; } // 0x168
        public string spawn_prop_filename { get; set; } // 0x170
        public string change_map_filename { get; set; } // 0x178
        public int bgm_sound_id { get; set; } // 0x180
        public int boss_sound_id { get; set; } // 0x184
        public int user_exp { get; set; } // 0x188
        public int hero_exp { get; set; } // 0x18C
        public int gold_value { get; set; } // 0x190
        public int first_reward_id { get; set; } // 0x194
        public int first_reward_value { get; set; } // 0x198
        public int drop_item_normal_min_count { get; set; } // 0x19C
        public int drop_item_normal_max_count { get; set; } // 0x1A0
        public int drop_item_boss_min_count { get; set; } // 0x1A4
        public int drop_item_boss_max_count { get; set; } // 0x1A8
        public int monster_material_per { get; set; } // 0x1AC
        public int drop_item_id_1 { get; set; } // 0x1B0
        public int drop_item_value_1 { get; set; } // 0x1B4
        public int drop_item_per_1 { get; set; } // 0x1B8
        public int drop_item_box_1 { get; set; } // 0x1BC
        public int drop_item_id_2 { get; set; } // 0x1C0
        public int drop_item_value_2 { get; set; } // 0x1C4
        public int drop_item_per_2 { get; set; } // 0x1C8
        public int drop_item_box_2 { get; set; } // 0x1CC
        public int drop_item_id_3 { get; set; } // 0x1D0
        public int drop_item_value_3 { get; set; } // 0x1D4
        public int drop_item_per_3 { get; set; } // 0x1D8
        public int drop_item_box_3 { get; set; } // 0x1DC
        public string EssenCondition_1 { get; set; } // 0x1E0
        public int EssenConditionValue_1 { get; set; } // 0x1E8
        public string EssenCondition_2 { get; set; } // 0x1F0
        public int EssenConditionValue_2 { get; set; } // 0x1F8
        public string EssenCondition_3 { get; set; } // 0x200
        public int EssenConditionValue_3 { get; set; } // 0x208
        public string EssenCondition_4 { get; set; } // 0x210
        public int EssenConditionValue_4 { get; set; } // 0x218
        public string BanCondition_1 { get; set; } // 0x220
        public int BanConditionValue_1 { get; set; } // 0x228
        public string BanCondition_2 { get; set; } // 0x230
        public int BanConditionValue_2 { get; set; } // 0x238
        public string BanCondition_3 { get; set; } // 0x240
        public int BanConditionValue_3 { get; set; } // 0x248
        public string BanCondition_4 { get; set; } // 0x250
        public int BanConditionValue_4 { get; set; } // 0x258
        public string BanCondition_5 { get; set; } // 0x260
        public int BanConditionValue_5 { get; set; } // 0x268
        public string BanCondition_6 { get; set; } // 0x270
        public int BanConditionValue_6 { get; set; } // 0x278
        public int npc_team_id { get; set; } // 0x27C
        public List<int> list_story_id = new List<int>(); // 0x280
        public List<int> list_monster_id = new List<int>(); // 0x288
        public List<int> list_monster_material_box = new List<int>(); // 0x290
        public List<int> list_boss_id = new List<int>(); // 0x298
        public List<int> list_boss_level = new List<int>(); // 0x2A0
        public List<int> list_boss_material_box = new List<int>(); // 0x2A8
        public List<int> list_drop_item_id = new List<int>(); // 0x2B0
        public List<int> list_drop_item_value = new List<int>(); // 0x2B8
        public List<int> list_drop_item_per = new List<int>(); // 0x2C0
        public List<int> list_drop_item_box = new List<int>(); // 0x2C8
        public List<string> list_EssenCondition = new List<string>(); // 0x2D0
        public List<int> list_EssenConditionValue = new List<int>(); // 0x2D8
        public List<string> list_BanCondition = new List<string>(); // 0x2E0
        public List<int> list_BanConditionValue = new List<int>(); // 0x2E8
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            open_quest_id = reader.ReadInt32();
            start_quest_id = reader.ReadInt32();
            stage_close = reader.ReadString();
            stage_string = reader.ReadString();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            limited_index = reader.ReadInt32();
            need_stage_id = reader.ReadInt32();
            area = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            team_power = reader.ReadInt32();
            monster_count = reader.ReadInt32();
            monster_atk_inc_per = reader.ReadInt32();
            monster_def_inc_per = reader.ReadInt32();
            monster_hp_inc_per = reader.ReadInt32();
            monster_level = reader.ReadInt32();
            monster_id_1 = reader.ReadInt32();
            monster_id_2 = reader.ReadInt32();
            monster_id_3 = reader.ReadInt32();
            monster_id_4 = reader.ReadInt32();
            monster_id_5 = reader.ReadInt32();
            monster_id_6 = reader.ReadInt32();
            monster_id_7 = reader.ReadInt32();
            monster_id_8 = reader.ReadInt32();
            monster_material_box_1 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            set_boss_elite_ui = reader.ReadInt32();
            stage_placement = reader.ReadString();
            stage_hero_entry_all = reader.ReadInt32();
            monster_ai_id = reader.ReadInt32();
            boss_atk_inc_per = reader.ReadInt32();
            boss_def_inc_per = reader.ReadInt32();
            boss_hp_inc_per = reader.ReadInt32();
            boss_id_1 = reader.ReadInt32();
            boss_level_1 = reader.ReadInt32();
            //array_passive1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v0--;
            }
            boss_material_box_1 = reader.ReadInt32();
            boss_id_2 = reader.ReadInt32();
            boss_level_2 = reader.ReadInt32();
            //array_passive2 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v1--;
            }
            boss_material_box_2 = reader.ReadInt32();
            boss_id_3 = reader.ReadInt32();
            boss_level_3 = reader.ReadInt32();
            //array_passive3 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v2--;
            }
            boss_material_box_3 = reader.ReadInt32();
            boss_id_4 = reader.ReadInt32();
            boss_level_4 = reader.ReadInt32();
            //array_passive4 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_passive4.Add(reader.ReadInt32());
                v3--;
            }
            boss_material_box_4 = reader.ReadInt32();
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v4--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            drop_item_normal_min_count = reader.ReadInt32();
            drop_item_normal_max_count = reader.ReadInt32();
            drop_item_boss_min_count = reader.ReadInt32();
            drop_item_boss_max_count = reader.ReadInt32();
            monster_material_per = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_item_value_1 = reader.ReadInt32();
            drop_item_per_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_item_value_2 = reader.ReadInt32();
            drop_item_per_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_item_value_3 = reader.ReadInt32();
            drop_item_per_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            npc_team_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageMemorialRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string type_local { get; set; } // 0x20
        public string stage_string { get; set; } // 0x28
        public string control_type { get; set; } // 0x30
        public int log_region { get; set; } // 0x38
        public int log_index { get; set; } // 0x3C
        public string memorial_image { get; set; } // 0x40
        public int hero_id { get; set; } // 0x48
        public int Essen_hero_id { get; set; } // 0x4C
        public int unlock_memorial_id { get; set; } // 0x50
        public int open_level { get; set; } // 0x54
        public int list_cut { get; set; } // 0x58
        public string before_loading_chapter_no { get; set; } // 0x60
        public string before_loading_title { get; set; } // 0x68
        public int start_cut { get; set; } // 0x70
        public int end_cut { get; set; } // 0x74
        public int need_stamina_item_id { get; set; } // 0x78
        public int need_stamina_count { get; set; } // 0x7C
        public int user_exp { get; set; } // 0x80
        public int hero_exp { get; set; } // 0x84
        public int battle_check { get; set; } // 0x88
        public int first_reward_id { get; set; } // 0x8C
        public int first_reward_value { get; set; } // 0x90
        public int monster_count { get; set; } // 0x94
        public int monster_atk_inc_per { get; set; } // 0x98
        public int monster_def_inc_per { get; set; } // 0x9C
        public int monster_hp_inc_per { get; set; } // 0xA0
        public int monster_level { get; set; } // 0xA4
        public int monster_id_1 { get; set; } // 0xA8
        public int monster_id_2 { get; set; } // 0xAC
        public int monster_id_3 { get; set; } // 0xB0
        public int monster_id_4 { get; set; } // 0xB4
        public int monster_id_5 { get; set; } // 0xB8
        public int monster_id_6 { get; set; } // 0xBC
        public int monster_id_7 { get; set; } // 0xC0
        public int monster_id_8 { get; set; } // 0xC4
        public int is_turn_pivot { get; set; } // 0xC8
        public string stage_placement { get; set; } // 0xD0
        public int monster_ai_id { get; set; } // 0xD8
        public int boss_atk_inc_per { get; set; } // 0xDC
        public int boss_def_inc_per { get; set; } // 0xE0
        public int boss_hp_inc_per { get; set; } // 0xE4
        public int boss_id_1 { get; set; } // 0xE8
        public int boss_level_1 { get; set; } // 0xEC
        public string array_passive1 { get; set; } // 0xF0
        public List<int> list_array_passive1 = new List<int>(); // 0xF8
        public int boss_id_2 { get; set; } // 0x100
        public int boss_level_2 { get; set; } // 0x104
        public string array_passive2 { get; set; } // 0x108
        public List<int> list_array_passive2 = new List<int>(); // 0x110
        public int boss_id_3 { get; set; } // 0x118
        public int boss_level_3 { get; set; } // 0x11C
        public string array_passive3 { get; set; } // 0x120
        public List<int> list_array_passive3 = new List<int>(); // 0x128
        public int boss_id_4 { get; set; } // 0x130
        public int boss_level_4 { get; set; } // 0x134
        public string array_passive4 { get; set; } // 0x138
        public List<int> list_array_passive4 = new List<int>(); // 0x140
        public int play_boss_spawn { get; set; } // 0x148
        public string boss_entry_type { get; set; } // 0x150
        public string array_ally_passive_id { get; set; } // 0x158
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x160
        public int team_power { get; set; } // 0x168
        public string map_filename { get; set; } // 0x170
        public string spawn_prop_filename { get; set; } // 0x178
        public string change_map_filename { get; set; } // 0x180
        public int bgm_sound_id { get; set; } // 0x188
        public int boss_sound_id { get; set; } // 0x18C
        public string EssenCondition_1 { get; set; } // 0x190
        public int EssenConditionValue_1 { get; set; } // 0x198
        public string EssenCondition_2 { get; set; } // 0x1A0
        public int EssenConditionValue_2 { get; set; } // 0x1A8
        public string EssenCondition_3 { get; set; } // 0x1B0
        public int EssenConditionValue_3 { get; set; } // 0x1B8
        public string EssenCondition_4 { get; set; } // 0x1C0
        public int EssenConditionValue_4 { get; set; } // 0x1C8
        public string BanCondition_1 { get; set; } // 0x1D0
        public int BanConditionValue_1 { get; set; } // 0x1D8
        public string BanCondition_2 { get; set; } // 0x1E0
        public int BanConditionValue_2 { get; set; } // 0x1E8
        public string BanCondition_3 { get; set; } // 0x1F0
        public int BanConditionValue_3 { get; set; } // 0x1F8
        public string BanCondition_4 { get; set; } // 0x200
        public int BanConditionValue_4 { get; set; } // 0x208
        public string BanCondition_5 { get; set; } // 0x210
        public int BanConditionValue_5 { get; set; } // 0x218
        public string BanCondition_6 { get; set; } // 0x220
        public int BanConditionValue_6 { get; set; } // 0x228
        public List<int> list_monster_id = new List<int>(); // 0x230
        public List<int> list_boss_id = new List<int>(); // 0x238
        public List<int> list_boss_level = new List<int>(); // 0x240
        public List<string> list_EssenCondition = new List<string>(); // 0x248
        public List<int> list_EssenConditionValue = new List<int>(); // 0x250
        public List<string> list_BanCondition = new List<string>(); // 0x258
        public List<int> list_BanConditionValue = new List<int>(); // 0x260
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            type_local = reader.ReadString();
            stage_string = reader.ReadString();
            control_type = reader.ReadString();
            log_region = reader.ReadInt32();
            log_index = reader.ReadInt32();
            memorial_image = reader.ReadString();
            hero_id = reader.ReadInt32();
            Essen_hero_id = reader.ReadInt32();
            unlock_memorial_id = reader.ReadInt32();
            open_level = reader.ReadInt32();
            list_cut = reader.ReadInt32();
            before_loading_chapter_no = reader.ReadString();
            before_loading_title = reader.ReadString();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            battle_check = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            monster_count = reader.ReadInt32();
            monster_atk_inc_per = reader.ReadInt32();
            monster_def_inc_per = reader.ReadInt32();
            monster_hp_inc_per = reader.ReadInt32();
            monster_level = reader.ReadInt32();
            monster_id_1 = reader.ReadInt32();
            monster_id_2 = reader.ReadInt32();
            monster_id_3 = reader.ReadInt32();
            monster_id_4 = reader.ReadInt32();
            monster_id_5 = reader.ReadInt32();
            monster_id_6 = reader.ReadInt32();
            monster_id_7 = reader.ReadInt32();
            monster_id_8 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            stage_placement = reader.ReadString();
            monster_ai_id = reader.ReadInt32();
            boss_atk_inc_per = reader.ReadInt32();
            boss_def_inc_per = reader.ReadInt32();
            boss_hp_inc_per = reader.ReadInt32();
            boss_id_1 = reader.ReadInt32();
            boss_level_1 = reader.ReadInt32();
            //array_passive1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v0--;
            }
            boss_id_2 = reader.ReadInt32();
            boss_level_2 = reader.ReadInt32();
            //array_passive2 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v1--;
            }
            boss_id_3 = reader.ReadInt32();
            boss_level_3 = reader.ReadInt32();
            //array_passive3 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v2--;
            }
            boss_id_4 = reader.ReadInt32();
            boss_level_4 = reader.ReadInt32();
            //array_passive4 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_passive4.Add(reader.ReadInt32());
                v3--;
            }
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v4--;
            }
            team_power = reader.ReadInt32();
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageNpcBaseRow
    {
        public int npc_id { get; set; } // 0x10
        public int skin_id { get; set; } // 0x14
        public int exclusive_condition { get; set; } // 0x18
        public int level { get; set; } // 0x1C
        public int max_level { get; set; } // 0x20
        public int weapon_costume_id { get; set; } // 0x24
        public int skin_costume_id { get; set; } // 0x28
        public int head_costume_id { get; set; } // 0x2C
        public string npc_icon { get; set; } // 0x30
        public string npc_nickname { get; set; } // 0x38
        public string item_name { get; set; } // 0x40
        public int costume_rating { get; set; } // 0x48
        public int role { get; set; } // 0x4C
        public int attribute { get; set; } // 0x50
        public float atk_inc_per { get; set; } // 0x54
        public float def_inc_per { get; set; } // 0x58
        public float hp_inc_per { get; set; } // 0x5C
        public float atk { get; set; } // 0x60
        public float fixed_atk_per { get; set; } // 0x64
        public float crit_per { get; set; } // 0x68
        public float crit_atk_per { get; set; } // 0x6C
        public float def { get; set; } // 0x70
        public float fixed_def_per { get; set; } // 0x74
        public float crit_res_per { get; set; } // 0x78
        public float crit_def_per { get; set; } // 0x7C
        public float hp { get; set; } // 0x80
        public float hp_regen_per { get; set; } // 0x84
        public float hp_recovery_per { get; set; } // 0x88
        public float hp_steal_per { get; set; } // 0x8C
        public float atk_add { get; set; } // 0x90
        public float def_add { get; set; } // 0x94
        public float hp_add { get; set; } // 0x98
        public bool ReadToStream(BinaryReader reader)
        {
            npc_id = reader.ReadInt32();
            skin_id = reader.ReadInt32();
            exclusive_condition = reader.ReadInt32();
            level = reader.ReadInt32();
            max_level = reader.ReadInt32();
            weapon_costume_id = reader.ReadInt32();
            skin_costume_id = reader.ReadInt32();
            head_costume_id = reader.ReadInt32();
            npc_icon = reader.ReadString();
            npc_nickname = reader.ReadString();
            item_name = reader.ReadString();
            costume_rating = reader.ReadInt32();
            role = reader.ReadInt32();
            attribute = reader.ReadInt32();
            atk_inc_per = reader.ReadSingle();
            def_inc_per = reader.ReadSingle();
            hp_inc_per = reader.ReadSingle();
            atk = reader.ReadSingle();
            fixed_atk_per = reader.ReadSingle();
            crit_per = reader.ReadSingle();
            crit_atk_per = reader.ReadSingle();
            def = reader.ReadSingle();
            fixed_def_per = reader.ReadSingle();
            crit_res_per = reader.ReadSingle();
            crit_def_per = reader.ReadSingle();
            hp = reader.ReadSingle();
            hp_regen_per = reader.ReadSingle();
            hp_recovery_per = reader.ReadSingle();
            hp_steal_per = reader.ReadSingle();
            atk_add = reader.ReadSingle();
            def_add = reader.ReadSingle();
            hp_add = reader.ReadSingle();
            return true;
        }
    }
    public class DBStageNpcSettingRow
    {
        public int id { get; set; } // 0x10
        public string event_type { get; set; } // 0x18
        public int stage_npc_slot_1 { get; set; } // 0x20
        public int stage_npc_slot_2 { get; set; } // 0x24
        public int stage_npc_slot_3 { get; set; } // 0x28
        public int stage_npc_slot_4 { get; set; } // 0x2C
        public string npc_team_name { get; set; } // 0x30
        public int main_hero_id_1 { get; set; } // 0x38
        public int main_hero_id_2 { get; set; } // 0x3C
        public int main_hero_id_3 { get; set; } // 0x40
        public int main_hero_id_4 { get; set; } // 0x44
        public List<int> list_stage_npc_slot = new List<int>(); // 0x48
        public List<int> list_main_hero_id = new List<int>(); // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            event_type = reader.ReadString();
            stage_npc_slot_1 = reader.ReadInt32();
            stage_npc_slot_2 = reader.ReadInt32();
            stage_npc_slot_3 = reader.ReadInt32();
            stage_npc_slot_4 = reader.ReadInt32();
            npc_team_name = reader.ReadString();
            main_hero_id_1 = reader.ReadInt32();
            main_hero_id_2 = reader.ReadInt32();
            main_hero_id_3 = reader.ReadInt32();
            main_hero_id_4 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStagePlayCountRow
    {
        public int id { get; set; } // 0x10
        public int limit_index { get; set; } // 0x14
        public int play_count { get; set; } // 0x18
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            limit_index = reader.ReadInt32();
            play_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageQuestRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string type_local { get; set; } // 0x20
        public string stage_string { get; set; } // 0x28
        public int essen_hero_setting { get; set; } // 0x30
        public int ep { get; set; } // 0x34
        public string control_type { get; set; } // 0x38
        public int region { get; set; } // 0x40
        public int index { get; set; } // 0x44
        public int area { get; set; } // 0x48
        public int start_quest_id { get; set; } // 0x4C
        public int stage_end_character_area { get; set; } // 0x50
        public int character_area_change { get; set; } // 0x54
        public int start_cut { get; set; } // 0x58
        public int end_cut { get; set; } // 0x5C
        public int story_id_1 { get; set; } // 0x60
        public int story_id_2 { get; set; } // 0x64
        public int story_id_3 { get; set; } // 0x68
        public int need_stamina_item_id { get; set; } // 0x6C
        public int need_stamina_count { get; set; } // 0x70
        public int user_exp { get; set; } // 0x74
        public int hero_exp { get; set; } // 0x78
        public int gold_value { get; set; } // 0x7C
        public int monster_count { get; set; } // 0x80
        public int monster_atk_inc_per { get; set; } // 0x84
        public int monster_def_inc_per { get; set; } // 0x88
        public int monster_hp_inc_per { get; set; } // 0x8C
        public int monster_level { get; set; } // 0x90
        public int monster_id_1 { get; set; } // 0x94
        public int monster_id_2 { get; set; } // 0x98
        public int monster_id_3 { get; set; } // 0x9C
        public int monster_id_4 { get; set; } // 0xA0
        public int monster_id_5 { get; set; } // 0xA4
        public int monster_id_6 { get; set; } // 0xA8
        public int monster_id_7 { get; set; } // 0xAC
        public int monster_id_8 { get; set; } // 0xB0
        public int is_turn_pivot { get; set; } // 0xB4
        public int set_boss_elite_ui { get; set; } // 0xB8
        public string stage_placement { get; set; } // 0xC0
        public int stage_hero_entry_all { get; set; } // 0xC8
        public int monster_ai_id { get; set; } // 0xCC
        public int boss_atk_inc_per { get; set; } // 0xD0
        public int boss_def_inc_per { get; set; } // 0xD4
        public int boss_hp_inc_per { get; set; } // 0xD8
        public int boss_id_1 { get; set; } // 0xDC
        public int boss_level_1 { get; set; } // 0xE0
        public int boss_skill_level_1 { get; set; } // 0xE4
        public List<int> list_array_passive1 = new List<int>(); // 0xE8
        public int boss_id_2 { get; set; } // 0xF0
        public int boss_level_2 { get; set; } // 0xF4
        public int boss_skill_level_2 { get; set; } // 0xF8
        public List<int> list_array_passive2 = new List<int>(); // 0x100
        public int boss_id_3 { get; set; } // 0x108
        public int boss_level_3 { get; set; } // 0x10C
        public int boss_skill_level_3 { get; set; } // 0x110
        public List<int> list_array_passive3 = new List<int>(); // 0x118
        public int boss_id_4 { get; set; } // 0x120
        public int boss_level_4 { get; set; } // 0x124
        public int boss_skill_level_4 { get; set; } // 0x128
        public List<int> list_array_passive4 = new List<int>(); // 0x130
        public int play_boss_spawn { get; set; } // 0x138
        public string boss_entry_type { get; set; } // 0x140
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x148
        public int team_power { get; set; } // 0x150
        public string map_filename { get; set; } // 0x158
        public string spawn_prop_filename { get; set; } // 0x160
        public string change_map_filename { get; set; } // 0x168
        public int bgm_sound_id { get; set; } // 0x170
        public int boss_sound_id { get; set; } // 0x174
        public string EssenCondition_1 { get; set; } // 0x178
        public int EssenConditionValue_1 { get; set; } // 0x180
        public string EssenCondition_2 { get; set; } // 0x188
        public int EssenConditionValue_2 { get; set; } // 0x190
        public string EssenCondition_3 { get; set; } // 0x198
        public int EssenConditionValue_3 { get; set; } // 0x1A0
        public string EssenCondition_4 { get; set; } // 0x1A8
        public int EssenConditionValue_4 { get; set; } // 0x1B0
        public string BanCondition_1 { get; set; } // 0x1B8
        public int BanConditionValue_1 { get; set; } // 0x1C0
        public string BanCondition_2 { get; set; } // 0x1C8
        public int BanConditionValue_2 { get; set; } // 0x1D0
        public string BanCondition_3 { get; set; } // 0x1D8
        public int BanConditionValue_3 { get; set; } // 0x1E0
        public string BanCondition_4 { get; set; } // 0x1E8
        public int BanConditionValue_4 { get; set; } // 0x1F0
        public string BanCondition_5 { get; set; } // 0x1F8
        public int BanConditionValue_5 { get; set; } // 0x200
        public string BanCondition_6 { get; set; } // 0x208
        public int BanConditionValue_6 { get; set; } // 0x210
        public int npc_team_id { get; set; } // 0x214
        public List<int> list_story_id = new List<int>(); // 0x218
        public List<int> list_monster_id = new List<int>(); // 0x220
        public List<int> list_boss_id = new List<int>(); // 0x228
        public List<int> list_boss_level = new List<int>(); // 0x230
        public List<int> list_boss_skill_level = new List<int>(); // 0x238
        public List<string> list_EssenCondition = new List<string>(); // 0x240
        public List<int> list_EssenConditionValue = new List<int>(); // 0x248
        public List<string> list_BanCondition = new List<string>(); // 0x250
        public List<int> list_BanConditionValue = new List<int>(); // 0x258
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            type_local = reader.ReadString();
            stage_string = reader.ReadString();
            essen_hero_setting = reader.ReadInt32();
            ep = reader.ReadInt32();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            index = reader.ReadInt32();
            area = reader.ReadInt32();
            start_quest_id = reader.ReadInt32();
            stage_end_character_area = reader.ReadInt32();
            character_area_change = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            monster_count = reader.ReadInt32();
            monster_atk_inc_per = reader.ReadInt32();
            monster_def_inc_per = reader.ReadInt32();
            monster_hp_inc_per = reader.ReadInt32();
            monster_level = reader.ReadInt32();
            monster_id_1 = reader.ReadInt32();
            monster_id_2 = reader.ReadInt32();
            monster_id_3 = reader.ReadInt32();
            monster_id_4 = reader.ReadInt32();
            monster_id_5 = reader.ReadInt32();
            monster_id_6 = reader.ReadInt32();
            monster_id_7 = reader.ReadInt32();
            monster_id_8 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            set_boss_elite_ui = reader.ReadInt32();
            stage_placement = reader.ReadString();
            stage_hero_entry_all = reader.ReadInt32();
            monster_ai_id = reader.ReadInt32();
            boss_atk_inc_per = reader.ReadInt32();
            boss_def_inc_per = reader.ReadInt32();
            boss_hp_inc_per = reader.ReadInt32();
            boss_id_1 = reader.ReadInt32();
            boss_level_1 = reader.ReadInt32();
            boss_skill_level_1 = reader.ReadInt32();
            //array_passive1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v0--;
            }
            boss_id_2 = reader.ReadInt32();
            boss_level_2 = reader.ReadInt32();
            boss_skill_level_2 = reader.ReadInt32();
            //array_passive2 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v1--;
            }
            boss_id_3 = reader.ReadInt32();
            boss_level_3 = reader.ReadInt32();
            boss_skill_level_3 = reader.ReadInt32();
            //array_passive3 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v2--;
            }
            boss_id_4 = reader.ReadInt32();
            boss_level_4 = reader.ReadInt32();
            boss_skill_level_4 = reader.ReadInt32();
            //array_passive4 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_passive4.Add(reader.ReadInt32());
                v3--;
            }
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v4--;
            }
            team_power = reader.ReadInt32();
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            npc_team_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageReverseRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string control_type { get; set; } // 0x20
        public string stage_string { get; set; } // 0x28
        public int essen_hero_setting { get; set; } // 0x30
        public int season_id { get; set; } // 0x34
        public int group_id { get; set; } // 0x38
        public int server_stage_index { get; set; } // 0x3C
        public int start_quest_id { get; set; } // 0x40
        public int need_quest_id { get; set; } // 0x44
        public int need_stage_side { get; set; } // 0x48
        public int extra_group_id { get; set; } // 0x4C
        public int need_stage_id { get; set; } // 0x50
        public int next_stage_side { get; set; } // 0x54
        public int next_stage_id { get; set; } // 0x58
        public int pre_start_cut { get; set; } // 0x5C
        public int start_cut { get; set; } // 0x60
        public int end_cut { get; set; } // 0x64
        public int story_id_1 { get; set; } // 0x68
        public int story_id_2 { get; set; } // 0x6C
        public int story_id_3 { get; set; } // 0x70
        public int need_stamina_item_id { get; set; } // 0x74
        public int need_stamina_count { get; set; } // 0x78
        public int team_power { get; set; } // 0x7C
        public int monster_count { get; set; } // 0x80
        public int monster_atk_inc_per { get; set; } // 0x84
        public int monster_def_inc_per { get; set; } // 0x88
        public int monster_hp_inc_per { get; set; } // 0x8C
        public int monster_level { get; set; } // 0x90
        public int monster_id_1 { get; set; } // 0x94
        public int monster_id_2 { get; set; } // 0x98
        public int monster_id_3 { get; set; } // 0x9C
        public int monster_id_4 { get; set; } // 0xA0
        public int monster_id_5 { get; set; } // 0xA4
        public int monster_id_6 { get; set; } // 0xA8
        public int is_turn_pivot { get; set; } // 0xAC
        public int set_boss_elite_ui { get; set; } // 0xB0
        public string stage_placement { get; set; } // 0xB8
        public int monster_ai_id { get; set; } // 0xC0
        public int boss_atk_inc_per { get; set; } // 0xC4
        public int boss_def_inc_per { get; set; } // 0xC8
        public int boss_hp_inc_per { get; set; } // 0xCC
        public int boss_id_1 { get; set; } // 0xD0
        public int boss_level_1 { get; set; } // 0xD4
        public string array_passive1 { get; set; } // 0xD8
        public List<int> list_array_passive1 = new List<int>(); // 0xE0
        public int boss_id_2 { get; set; } // 0xE8
        public int boss_level_2 { get; set; } // 0xEC
        public string array_passive2 { get; set; } // 0xF0
        public List<int> list_array_passive2 = new List<int>(); // 0xF8
        public int boss_id_3 { get; set; } // 0x100
        public int boss_level_3 { get; set; } // 0x104
        public string array_passive3 { get; set; } // 0x108
        public List<int> list_array_passive3 = new List<int>(); // 0x110
        public int boss_id_4 { get; set; } // 0x118
        public int boss_level_4 { get; set; } // 0x11C
        public string array_passive4 { get; set; } // 0x120
        public List<int> list_array_passive4 = new List<int>(); // 0x128
        public int play_boss_spawn { get; set; } // 0x130
        public string boss_entry_type { get; set; } // 0x138
        public string array_ally_passive_id { get; set; } // 0x140
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x148
        public string map_filename { get; set; } // 0x150
        public string spawn_prop_filename { get; set; } // 0x158
        public string change_map_filename { get; set; } // 0x160
        public int bgm_sound_id { get; set; } // 0x168
        public int boss_sound_id { get; set; } // 0x16C
        public int user_exp { get; set; } // 0x170
        public int hero_exp { get; set; } // 0x174
        public int gold_value { get; set; } // 0x178
        public int first_reward_id { get; set; } // 0x17C
        public int first_reward_value { get; set; } // 0x180
        public int drop_item_normal_min_count { get; set; } // 0x184
        public int drop_item_normal_max_count { get; set; } // 0x188
        public int drop_item_boss_min_count { get; set; } // 0x18C
        public int drop_item_boss_max_count { get; set; } // 0x190
        public int monster_material_per { get; set; } // 0x194
        public int drop_item_id_1 { get; set; } // 0x198
        public int drop_item_value_1 { get; set; } // 0x19C
        public int drop_item_evolution_count_1 { get; set; } // 0x1A0
        public int drop_item_per_1 { get; set; } // 0x1A4
        public int drop_item_box_1 { get; set; } // 0x1A8
        public int drop_item_id_2 { get; set; } // 0x1AC
        public int drop_item_value_2 { get; set; } // 0x1B0
        public int drop_item_evolution_count_2 { get; set; } // 0x1B4
        public int drop_item_per_2 { get; set; } // 0x1B8
        public int drop_item_box_2 { get; set; } // 0x1BC
        public int drop_item_id_3 { get; set; } // 0x1C0
        public int drop_item_value_3 { get; set; } // 0x1C4
        public int drop_item_evolution_count_3 { get; set; } // 0x1C8
        public int drop_item_per_3 { get; set; } // 0x1CC
        public int drop_item_box_3 { get; set; } // 0x1D0
        public int drop_item_id_4 { get; set; } // 0x1D4
        public int drop_item_value_4 { get; set; } // 0x1D8
        public int drop_item_evolution_count_4 { get; set; } // 0x1DC
        public int drop_item_per_4 { get; set; } // 0x1E0
        public int drop_item_box_4 { get; set; } // 0x1E4
        public int drop_item_id_5 { get; set; } // 0x1E8
        public int drop_item_value_5 { get; set; } // 0x1EC
        public int drop_item_evolution_count_5 { get; set; } // 0x1F0
        public int drop_item_per_5 { get; set; } // 0x1F4
        public int drop_item_box_5 { get; set; } // 0x1F8
        public int drop_item_id_6 { get; set; } // 0x1FC
        public int drop_item_value_6 { get; set; } // 0x200
        public int drop_item_evolution_count_6 { get; set; } // 0x204
        public int drop_item_per_6 { get; set; } // 0x208
        public int drop_item_box_6 { get; set; } // 0x20C
        public int drop_item_id_7 { get; set; } // 0x210
        public int drop_item_value_7 { get; set; } // 0x214
        public int drop_item_evolution_count_7 { get; set; } // 0x218
        public int drop_item_per_7 { get; set; } // 0x21C
        public int drop_item_box_7 { get; set; } // 0x220
        public int drop_item_id_8 { get; set; } // 0x224
        public int drop_item_value_8 { get; set; } // 0x228
        public int drop_item_evolution_count_8 { get; set; } // 0x22C
        public int drop_item_per_8 { get; set; } // 0x230
        public int drop_item_box_8 { get; set; } // 0x234
        public int drop_item_id_9 { get; set; } // 0x238
        public int drop_item_value_9 { get; set; } // 0x23C
        public int drop_item_evolution_count_9 { get; set; } // 0x240
        public int drop_item_per_9 { get; set; } // 0x244
        public int drop_item_box_9 { get; set; } // 0x248
        public int drop_item_id_10 { get; set; } // 0x24C
        public int drop_item_value_10 { get; set; } // 0x250
        public int drop_item_evolution_count_10 { get; set; } // 0x254
        public int drop_item_per_10 { get; set; } // 0x258
        public int drop_item_box_10 { get; set; } // 0x25C
        public int drop_item_id_11 { get; set; } // 0x260
        public int drop_item_value_11 { get; set; } // 0x264
        public int drop_item_evolution_count_11 { get; set; } // 0x268
        public int drop_item_per_11 { get; set; } // 0x26C
        public int drop_item_box_11 { get; set; } // 0x270
        public int drop_item_id_12 { get; set; } // 0x274
        public int drop_item_value_12 { get; set; } // 0x278
        public int drop_item_evolution_count_12 { get; set; } // 0x27C
        public int drop_item_per_12 { get; set; } // 0x280
        public int drop_item_box_12 { get; set; } // 0x284
        public int drop_item_id_13 { get; set; } // 0x288
        public int drop_item_value_13 { get; set; } // 0x28C
        public int drop_item_evolution_count_13 { get; set; } // 0x290
        public int drop_item_per_13 { get; set; } // 0x294
        public int drop_item_box_13 { get; set; } // 0x298
        public int drop_item_id_14 { get; set; } // 0x29C
        public int drop_item_value_14 { get; set; } // 0x2A0
        public int drop_item_evolution_count_14 { get; set; } // 0x2A4
        public int drop_item_per_14 { get; set; } // 0x2A8
        public int drop_item_box_14 { get; set; } // 0x2AC
        public int drop_item_id_15 { get; set; } // 0x2B0
        public int drop_item_value_15 { get; set; } // 0x2B4
        public int drop_item_evolution_count_15 { get; set; } // 0x2B8
        public int drop_item_per_15 { get; set; } // 0x2BC
        public int drop_item_box_15 { get; set; } // 0x2C0
        public string essen_hero_potrait_base_1 { get; set; } // 0x2C8
        public string essen_hero_icon_1 { get; set; } // 0x2D0
        public string essen_hero_potrait_base_2 { get; set; } // 0x2D8
        public string essen_hero_icon_2 { get; set; } // 0x2E0
        public string essen_hero_potrait_base_3 { get; set; } // 0x2E8
        public string essen_hero_icon_3 { get; set; } // 0x2F0
        public string essen_hero_potrait_base_4 { get; set; } // 0x2F8
        public string essen_hero_icon_4 { get; set; } // 0x300
        public string EssenCondition_1 { get; set; } // 0x308
        public int EssenConditionValue_1 { get; set; } // 0x310
        public string EssenCondition_2 { get; set; } // 0x318
        public int EssenConditionValue_2 { get; set; } // 0x320
        public string EssenCondition_3 { get; set; } // 0x328
        public int EssenConditionValue_3 { get; set; } // 0x330
        public string EssenCondition_4 { get; set; } // 0x338
        public int EssenConditionValue_4 { get; set; } // 0x340
        public string BanCondition_1 { get; set; } // 0x348
        public int BanConditionValue_1 { get; set; } // 0x350
        public string BanCondition_2 { get; set; } // 0x358
        public int BanConditionValue_2 { get; set; } // 0x360
        public string BanCondition_3 { get; set; } // 0x368
        public int BanConditionValue_3 { get; set; } // 0x370
        public string BanCondition_4 { get; set; } // 0x378
        public int BanConditionValue_4 { get; set; } // 0x380
        public string BanCondition_5 { get; set; } // 0x388
        public int BanConditionValue_5 { get; set; } // 0x390
        public string BanCondition_6 { get; set; } // 0x398
        public int BanConditionValue_6 { get; set; } // 0x3A0
        public int npc_team_id { get; set; } // 0x3A4
        public List<int> list_story_id = new List<int>(); // 0x3A8
        public List<int> list_monster_id = new List<int>(); // 0x3B0
        public List<int> list_boss_id = new List<int>(); // 0x3B8
        public List<int> list_boss_level = new List<int>(); // 0x3C0
        public List<int> list_drop_item_id = new List<int>(); // 0x3C8
        public List<int> list_drop_item_value = new List<int>(); // 0x3D0
        public List<int> list_drop_item_evolution_count = new List<int>(); // 0x3D8
        public List<int> list_drop_item_per = new List<int>(); // 0x3E0
        public List<int> list_drop_item_box = new List<int>(); // 0x3E8
        public List<string> list_essen_hero_potrait_base = new List<string>(); // 0x3F0
        public List<string> list_essen_hero_icon = new List<string>(); // 0x3F8
        public List<string> list_EssenCondition = new List<string>(); // 0x400
        public List<int> list_EssenConditionValue = new List<int>(); // 0x408
        public List<string> list_BanCondition = new List<string>(); // 0x410
        public List<int> list_BanConditionValue = new List<int>(); // 0x418
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            control_type = reader.ReadString();
            stage_string = reader.ReadString();
            essen_hero_setting = reader.ReadInt32();
            season_id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            server_stage_index = reader.ReadInt32();
            start_quest_id = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            need_stage_side = reader.ReadInt32();
            extra_group_id = reader.ReadInt32();
            need_stage_id = reader.ReadInt32();
            next_stage_side = reader.ReadInt32();
            next_stage_id = reader.ReadInt32();
            pre_start_cut = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            team_power = reader.ReadInt32();
            monster_count = reader.ReadInt32();
            monster_atk_inc_per = reader.ReadInt32();
            monster_def_inc_per = reader.ReadInt32();
            monster_hp_inc_per = reader.ReadInt32();
            monster_level = reader.ReadInt32();
            monster_id_1 = reader.ReadInt32();
            monster_id_2 = reader.ReadInt32();
            monster_id_3 = reader.ReadInt32();
            monster_id_4 = reader.ReadInt32();
            monster_id_5 = reader.ReadInt32();
            monster_id_6 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            set_boss_elite_ui = reader.ReadInt32();
            stage_placement = reader.ReadString();
            monster_ai_id = reader.ReadInt32();
            boss_atk_inc_per = reader.ReadInt32();
            boss_def_inc_per = reader.ReadInt32();
            boss_hp_inc_per = reader.ReadInt32();
            boss_id_1 = reader.ReadInt32();
            boss_level_1 = reader.ReadInt32();
            //array_passive1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v0--;
            }
            boss_id_2 = reader.ReadInt32();
            boss_level_2 = reader.ReadInt32();
            //array_passive2 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v1--;
            }
            boss_id_3 = reader.ReadInt32();
            boss_level_3 = reader.ReadInt32();
            //array_passive3 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v2--;
            }
            boss_id_4 = reader.ReadInt32();
            boss_level_4 = reader.ReadInt32();
            //array_passive4 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_passive4.Add(reader.ReadInt32());
                v3--;
            }
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v4--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            drop_item_normal_min_count = reader.ReadInt32();
            drop_item_normal_max_count = reader.ReadInt32();
            drop_item_boss_min_count = reader.ReadInt32();
            drop_item_boss_max_count = reader.ReadInt32();
            monster_material_per = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_item_value_1 = reader.ReadInt32();
            drop_item_evolution_count_1 = reader.ReadInt32();
            drop_item_per_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_item_value_2 = reader.ReadInt32();
            drop_item_evolution_count_2 = reader.ReadInt32();
            drop_item_per_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_item_value_3 = reader.ReadInt32();
            drop_item_evolution_count_3 = reader.ReadInt32();
            drop_item_per_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            drop_item_id_4 = reader.ReadInt32();
            drop_item_value_4 = reader.ReadInt32();
            drop_item_evolution_count_4 = reader.ReadInt32();
            drop_item_per_4 = reader.ReadInt32();
            drop_item_box_4 = reader.ReadInt32();
            drop_item_id_5 = reader.ReadInt32();
            drop_item_value_5 = reader.ReadInt32();
            drop_item_evolution_count_5 = reader.ReadInt32();
            drop_item_per_5 = reader.ReadInt32();
            drop_item_box_5 = reader.ReadInt32();
            drop_item_id_6 = reader.ReadInt32();
            drop_item_value_6 = reader.ReadInt32();
            drop_item_evolution_count_6 = reader.ReadInt32();
            drop_item_per_6 = reader.ReadInt32();
            drop_item_box_6 = reader.ReadInt32();
            drop_item_id_7 = reader.ReadInt32();
            drop_item_value_7 = reader.ReadInt32();
            drop_item_evolution_count_7 = reader.ReadInt32();
            drop_item_per_7 = reader.ReadInt32();
            drop_item_box_7 = reader.ReadInt32();
            drop_item_id_8 = reader.ReadInt32();
            drop_item_value_8 = reader.ReadInt32();
            drop_item_evolution_count_8 = reader.ReadInt32();
            drop_item_per_8 = reader.ReadInt32();
            drop_item_box_8 = reader.ReadInt32();
            drop_item_id_9 = reader.ReadInt32();
            drop_item_value_9 = reader.ReadInt32();
            drop_item_evolution_count_9 = reader.ReadInt32();
            drop_item_per_9 = reader.ReadInt32();
            drop_item_box_9 = reader.ReadInt32();
            drop_item_id_10 = reader.ReadInt32();
            drop_item_value_10 = reader.ReadInt32();
            drop_item_evolution_count_10 = reader.ReadInt32();
            drop_item_per_10 = reader.ReadInt32();
            drop_item_box_10 = reader.ReadInt32();
            drop_item_id_11 = reader.ReadInt32();
            drop_item_value_11 = reader.ReadInt32();
            drop_item_evolution_count_11 = reader.ReadInt32();
            drop_item_per_11 = reader.ReadInt32();
            drop_item_box_11 = reader.ReadInt32();
            drop_item_id_12 = reader.ReadInt32();
            drop_item_value_12 = reader.ReadInt32();
            drop_item_evolution_count_12 = reader.ReadInt32();
            drop_item_per_12 = reader.ReadInt32();
            drop_item_box_12 = reader.ReadInt32();
            drop_item_id_13 = reader.ReadInt32();
            drop_item_value_13 = reader.ReadInt32();
            drop_item_evolution_count_13 = reader.ReadInt32();
            drop_item_per_13 = reader.ReadInt32();
            drop_item_box_13 = reader.ReadInt32();
            drop_item_id_14 = reader.ReadInt32();
            drop_item_value_14 = reader.ReadInt32();
            drop_item_evolution_count_14 = reader.ReadInt32();
            drop_item_per_14 = reader.ReadInt32();
            drop_item_box_14 = reader.ReadInt32();
            drop_item_id_15 = reader.ReadInt32();
            drop_item_value_15 = reader.ReadInt32();
            drop_item_evolution_count_15 = reader.ReadInt32();
            drop_item_per_15 = reader.ReadInt32();
            drop_item_box_15 = reader.ReadInt32();
            essen_hero_potrait_base_1 = reader.ReadString();
            essen_hero_icon_1 = reader.ReadString();
            essen_hero_potrait_base_2 = reader.ReadString();
            essen_hero_icon_2 = reader.ReadString();
            essen_hero_potrait_base_3 = reader.ReadString();
            essen_hero_icon_3 = reader.ReadString();
            essen_hero_potrait_base_4 = reader.ReadString();
            essen_hero_icon_4 = reader.ReadString();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            npc_team_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageReverseGroupRow
    {
        public int id { get; set; } // 0x10
        public int season_id { get; set; } // 0x14
        public int group_id { get; set; } // 0x18
        public string reverse_area_name { get; set; } // 0x20
        public string map_resource_path { get; set; } // 0x28
        public string map_resource { get; set; } // 0x30
        public int open_value { get; set; } // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            season_id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            reverse_area_name = reader.ReadString();
            map_resource_path = reader.ReadString();
            map_resource = reader.ReadString();
            open_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageReverseGroupRewardRow
    {
        public int id { get; set; } // 0x10
        public int season_id { get; set; } // 0x14
        public int server_reward_index { get; set; } // 0x18
        public string array_group_clear_check { get; set; } // 0x20
        public List<int> list_array_group_clear_check = new List<int>(); // 0x28
        public int reward_id { get; set; } // 0x30
        public int reward_value { get; set; } // 0x34
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            season_id = reader.ReadInt32();
            server_reward_index = reader.ReadInt32();
            //array_group_clear_check = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_group_clear_check.Add(reader.ReadInt32());
                v0--;
            }
            reward_id = reader.ReadInt32();
            reward_value = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageReverseMissionRow
    {
        public int id { get; set; } // 0x10
        public int stage_id { get; set; } // 0x14
        public int seaon_id { get; set; } // 0x18
        public string mission_type { get; set; } // 0x20
        public int mission_type_value { get; set; } // 0x28
        public int mission_target_value { get; set; } // 0x2C
        public int localize_display_type { get; set; } // 0x30
        public string mission_name { get; set; } // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            stage_id = reader.ReadInt32();
            seaon_id = reader.ReadInt32();
            mission_type = reader.ReadString();
            mission_type_value = reader.ReadInt32();
            mission_target_value = reader.ReadInt32();
            localize_display_type = reader.ReadInt32();
            mission_name = reader.ReadString();
            return true;
        }
    }
    public class DBStageReverseSeasonRewardRow
    {
        public int season_id { get; set; } // 0x10
        public string reverse_season_name { get; set; } // 0x18
        public int star_reward_count_1 { get; set; } // 0x20
        public int star_reward_id_1 { get; set; } // 0x24
        public int star_reward_value_1 { get; set; } // 0x28
        public int star_reward_count_2 { get; set; } // 0x2C
        public int star_reward_id_2 { get; set; } // 0x30
        public int star_reward_value_2 { get; set; } // 0x34
        public int star_reward_count_3 { get; set; } // 0x38
        public int star_reward_id_3 { get; set; } // 0x3C
        public int star_reward_value_3 { get; set; } // 0x40
        public int star_reward_count_4 { get; set; } // 0x44
        public int star_reward_id_4 { get; set; } // 0x48
        public int star_reward_value_4 { get; set; } // 0x4C
        public int star_reward_count_5 { get; set; } // 0x50
        public int star_reward_id_5 { get; set; } // 0x54
        public int star_reward_value_5 { get; set; } // 0x58
        public int star_reward_count_6 { get; set; } // 0x5C
        public int star_reward_id_6 { get; set; } // 0x60
        public int star_reward_value_6 { get; set; } // 0x64
        public List<int> list_star_reward_count = new List<int>(); // 0x68
        public List<int> list_star_reward_id = new List<int>(); // 0x70
        public List<int> list_star_reward_value = new List<int>(); // 0x78
        public bool ReadToStream(BinaryReader reader)
        {
            season_id = reader.ReadInt32();
            reverse_season_name = reader.ReadString();
            star_reward_count_1 = reader.ReadInt32();
            star_reward_id_1 = reader.ReadInt32();
            star_reward_value_1 = reader.ReadInt32();
            star_reward_count_2 = reader.ReadInt32();
            star_reward_id_2 = reader.ReadInt32();
            star_reward_value_2 = reader.ReadInt32();
            star_reward_count_3 = reader.ReadInt32();
            star_reward_id_3 = reader.ReadInt32();
            star_reward_value_3 = reader.ReadInt32();
            star_reward_count_4 = reader.ReadInt32();
            star_reward_id_4 = reader.ReadInt32();
            star_reward_value_4 = reader.ReadInt32();
            star_reward_count_5 = reader.ReadInt32();
            star_reward_id_5 = reader.ReadInt32();
            star_reward_value_5 = reader.ReadInt32();
            star_reward_count_6 = reader.ReadInt32();
            star_reward_id_6 = reader.ReadInt32();
            star_reward_value_6 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageRunRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public int region { get; set; } // 0x20
        public int area { get; set; } // 0x24
        public string stage_string { get; set; } // 0x28
        public string control_type { get; set; } // 0x30
        public int run_index { get; set; } // 0x38
        public int need_base_fellow_id { get; set; } // 0x3C
        public int need_base_fellow_level { get; set; } // 0x40
        public int need_stamina_item_id { get; set; } // 0x44
        public int need_stamina_count { get; set; } // 0x48
        public int first_reward_id { get; set; } // 0x4C
        public int first_reward_value { get; set; } // 0x50
        public int reward_id_1 { get; set; } // 0x54
        public int reward_value_1 { get; set; } // 0x58
        public int reward_max_value { get; set; } // 0x5C
        public string hawk_run_bg { get; set; } // 0x60
        public string hawk_run_balance { get; set; } // 0x68
        public int bgm_sound_id { get; set; } // 0x70
        public int speed_sound_id { get; set; } // 0x74
        public float magnet_effect_time { get; set; } // 0x78
        public int broken_tower_coin { get; set; } // 0x7C
        public float speedup_time { get; set; } // 0x80
        public float velocity_default { get; set; } // 0x84
        public float velocity_speedup { get; set; } // 0x88
        public int init_hp { get; set; } // 0x8C
        public int coin_box_value { get; set; } // 0x90
        public int reward_hp_coin { get; set; } // 0x94
        public List<int> list_reward_id = new List<int>(); // 0x98
        public List<int> list_reward_value = new List<int>(); // 0xA0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            region = reader.ReadInt32();
            area = reader.ReadInt32();
            stage_string = reader.ReadString();
            control_type = reader.ReadString();
            run_index = reader.ReadInt32();
            need_base_fellow_id = reader.ReadInt32();
            need_base_fellow_level = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_value_1 = reader.ReadInt32();
            reward_max_value = reader.ReadInt32();
            hawk_run_bg = reader.ReadString();
            hawk_run_balance = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            speed_sound_id = reader.ReadInt32();
            magnet_effect_time = reader.ReadSingle();
            broken_tower_coin = reader.ReadInt32();
            speedup_time = reader.ReadSingle();
            velocity_default = reader.ReadSingle();
            velocity_speedup = reader.ReadSingle();
            init_hp = reader.ReadInt32();
            coin_box_value = reader.ReadInt32();
            reward_hp_coin = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageSingleSiegeRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string stage_string { get; set; } // 0x20
        public string control_type { get; set; } // 0x28
        public int region { get; set; } // 0x30
        public int group_id { get; set; } // 0x34
        public int destroy_index { get; set; } // 0x38
        public int area_switching { get; set; } // 0x3C
        public int need_quest_id { get; set; } // 0x40
        public int difficulty { get; set; } // 0x44
        public int difficulty_lock { get; set; } // 0x48
        public string difficulty_string { get; set; } // 0x50
        public string info_image { get; set; } // 0x58
        public string info_guide { get; set; } // 0x60
        public int start_cut { get; set; } // 0x68
        public int end_cut { get; set; } // 0x6C
        public int bgm_sound_id_1 { get; set; } // 0x70
        public int ambient_sound_id_1 { get; set; } // 0x74
        public int bgm_sound_id_2 { get; set; } // 0x78
        public int ambient_sound_id_2 { get; set; } // 0x7C
        public int bgm_sound_id_3 { get; set; } // 0x80
        public int ambient_sound_id_3 { get; set; } // 0x84
        public int bgm_sound_id_4 { get; set; } // 0x88
        public int ambient_sound_id_4 { get; set; } // 0x8C
        public int bgm_sound_id_5 { get; set; } // 0x90
        public int ambient_sound_id_5 { get; set; } // 0x94
        public int story_id_1 { get; set; } // 0x98
        public int story_id_2 { get; set; } // 0x9C
        public int story_id_3 { get; set; } // 0xA0
        public int need_stamina_item_id { get; set; } // 0xA4
        public int need_stamina_count { get; set; } // 0xA8
        public int switching_basepoint_id { get; set; } // 0xAC
        public int destroy_boss_id { get; set; } // 0xB0
        public string area_icon { get; set; } // 0xB8
        public string room_file_name { get; set; } // 0xC0
        public string room_spawn_prop_filename { get; set; } // 0xC8
        public string bg_resource_path { get; set; } // 0xD0
        public string stage_bg_resource { get; set; } // 0xD8
        public int room_bgm_sound_id { get; set; } // 0xE0
        public int user_exp { get; set; } // 0xE4
        public int hero_exp { get; set; } // 0xE8
        public int gold_value { get; set; } // 0xEC
        public int group_item_rate_add { get; set; } // 0xF0
        public int drop_item_boss_min_count { get; set; } // 0xF4
        public int drop_item_boss_max_count { get; set; } // 0xF8
        public int monster_material_per { get; set; } // 0xFC
        public int drop_item_id_1 { get; set; } // 0x100
        public int drop_item_value_1 { get; set; } // 0x104
        public int drop_item_evolution_count_1 { get; set; } // 0x108
        public int drop_item_per_1 { get; set; } // 0x10C
        public int drop_item_box_1 { get; set; } // 0x110
        public int drop_item_id_2 { get; set; } // 0x114
        public int drop_item_value_2 { get; set; } // 0x118
        public int drop_item_evolution_count_2 { get; set; } // 0x11C
        public int drop_item_per_2 { get; set; } // 0x120
        public int drop_item_box_2 { get; set; } // 0x124
        public int drop_item_id_3 { get; set; } // 0x128
        public int drop_item_value_3 { get; set; } // 0x12C
        public int drop_item_evolution_count_3 { get; set; } // 0x130
        public int drop_item_per_3 { get; set; } // 0x134
        public int drop_item_box_3 { get; set; } // 0x138
        public int drop_item_id_4 { get; set; } // 0x13C
        public int drop_item_value_4 { get; set; } // 0x140
        public int drop_item_evolution_count_4 { get; set; } // 0x144
        public int drop_item_per_4 { get; set; } // 0x148
        public int drop_item_box_4 { get; set; } // 0x14C
        public int drop_item_id_5 { get; set; } // 0x150
        public int drop_item_value_5 { get; set; } // 0x154
        public int drop_item_evolution_count_5 { get; set; } // 0x158
        public int drop_item_per_5 { get; set; } // 0x15C
        public int drop_item_box_5 { get; set; } // 0x160
        public int drop_item_id_6 { get; set; } // 0x164
        public int drop_item_value_6 { get; set; } // 0x168
        public int drop_item_evolution_count_6 { get; set; } // 0x16C
        public int drop_item_per_6 { get; set; } // 0x170
        public int drop_item_box_6 { get; set; } // 0x174
        public int drop_item_id_7 { get; set; } // 0x178
        public int drop_item_value_7 { get; set; } // 0x17C
        public int drop_item_evolution_count_7 { get; set; } // 0x180
        public int drop_item_per_7 { get; set; } // 0x184
        public int drop_item_box_7 { get; set; } // 0x188
        public int drop_item_id_8 { get; set; } // 0x18C
        public int drop_item_value_8 { get; set; } // 0x190
        public int drop_item_evolution_count_8 { get; set; } // 0x194
        public int drop_item_per_8 { get; set; } // 0x198
        public int drop_item_box_8 { get; set; } // 0x19C
        public int drop_item_id_9 { get; set; } // 0x1A0
        public int drop_item_value_9 { get; set; } // 0x1A4
        public int drop_item_evolution_count_9 { get; set; } // 0x1A8
        public int drop_item_per_9 { get; set; } // 0x1AC
        public int drop_item_box_9 { get; set; } // 0x1B0
        public int drop_item_id_10 { get; set; } // 0x1B4
        public int drop_item_value_10 { get; set; } // 0x1B8
        public int drop_item_evolution_count_10 { get; set; } // 0x1BC
        public int drop_item_per_10 { get; set; } // 0x1C0
        public int drop_item_box_10 { get; set; } // 0x1C4
        public int drop_item_id_11 { get; set; } // 0x1C8
        public int drop_item_value_11 { get; set; } // 0x1CC
        public int drop_item_evolution_count_11 { get; set; } // 0x1D0
        public int drop_item_per_11 { get; set; } // 0x1D4
        public int drop_item_box_11 { get; set; } // 0x1D8
        public int drop_item_id_12 { get; set; } // 0x1DC
        public int drop_item_value_12 { get; set; } // 0x1E0
        public int drop_item_evolution_count_12 { get; set; } // 0x1E4
        public int drop_item_per_12 { get; set; } // 0x1E8
        public int drop_item_box_12 { get; set; } // 0x1EC
        public int drop_item_id_13 { get; set; } // 0x1F0
        public int drop_item_value_13 { get; set; } // 0x1F4
        public int drop_item_evolution_count_13 { get; set; } // 0x1F8
        public int drop_item_per_13 { get; set; } // 0x1FC
        public int drop_item_box_13 { get; set; } // 0x200
        public int drop_item_id_14 { get; set; } // 0x204
        public int drop_item_value_14 { get; set; } // 0x208
        public int drop_item_evolution_count_14 { get; set; } // 0x20C
        public int drop_item_per_14 { get; set; } // 0x210
        public int drop_item_box_14 { get; set; } // 0x214
        public int drop_item_id_15 { get; set; } // 0x218
        public int drop_item_value_15 { get; set; } // 0x21C
        public int drop_item_evolution_count_15 { get; set; } // 0x220
        public int drop_item_per_15 { get; set; } // 0x224
        public int drop_item_box_15 { get; set; } // 0x228
        public int drop_item_id_16 { get; set; } // 0x22C
        public int drop_item_value_16 { get; set; } // 0x230
        public int drop_item_evolution_count_16 { get; set; } // 0x234
        public int drop_item_per_16 { get; set; } // 0x238
        public int drop_item_box_16 { get; set; } // 0x23C
        public int drop_item_id_17 { get; set; } // 0x240
        public int drop_item_value_17 { get; set; } // 0x244
        public int drop_item_evolution_count_17 { get; set; } // 0x248
        public int drop_item_per_17 { get; set; } // 0x24C
        public int drop_item_box_17 { get; set; } // 0x250
        public int drop_item_id_18 { get; set; } // 0x254
        public int drop_item_value_18 { get; set; } // 0x258
        public int drop_item_evolution_count_18 { get; set; } // 0x25C
        public int drop_item_per_18 { get; set; } // 0x260
        public int drop_item_box_18 { get; set; } // 0x264
        public int chief_drop_item_id_1 { get; set; } // 0x268
        public int chief_drop_item_value_1 { get; set; } // 0x26C
        public int chief_drop_item_evolution_count_1 { get; set; } // 0x270
        public int chief_drop_item_per_1 { get; set; } // 0x274
        public int chief_drop_item_box_1 { get; set; } // 0x278
        public int chief_drop_item_id_2 { get; set; } // 0x27C
        public int chief_drop_item_value_2 { get; set; } // 0x280
        public int chief_drop_item_evolution_count_2 { get; set; } // 0x284
        public int chief_drop_item_per_2 { get; set; } // 0x288
        public int chief_drop_item_box_2 { get; set; } // 0x28C
        public int chief_drop_item_id_3 { get; set; } // 0x290
        public int chief_drop_item_value_3 { get; set; } // 0x294
        public int chief_drop_item_evolution_count_3 { get; set; } // 0x298
        public int chief_drop_item_per_3 { get; set; } // 0x29C
        public int chief_drop_item_box_3 { get; set; } // 0x2A0
        public int chief_drop_item_id_4 { get; set; } // 0x2A4
        public int chief_drop_item_value_4 { get; set; } // 0x2A8
        public int chief_drop_item_evolution_count_4 { get; set; } // 0x2AC
        public int chief_drop_item_per_4 { get; set; } // 0x2B0
        public int chief_drop_item_box_4 { get; set; } // 0x2B4
        public int chief_drop_item_id_5 { get; set; } // 0x2B8
        public int chief_drop_item_value_5 { get; set; } // 0x2BC
        public int chief_drop_item_evolution_count_5 { get; set; } // 0x2C0
        public int chief_drop_item_per_5 { get; set; } // 0x2C4
        public int chief_drop_item_box_5 { get; set; } // 0x2C8
        public int chief_drop_item_id_6 { get; set; } // 0x2CC
        public int chief_drop_item_value_6 { get; set; } // 0x2D0
        public int chief_drop_item_evolution_count_6 { get; set; } // 0x2D4
        public int chief_drop_item_per_6 { get; set; } // 0x2D8
        public int chief_drop_item_box_6 { get; set; } // 0x2DC
        public string stage_placement { get; set; } // 0x2E0
        public string situation_behavior_tree_name { get; set; } // 0x2E8
        public int boss_atk_inc_per_1 { get; set; } // 0x2F0
        public int boss_def_inc_per_1 { get; set; } // 0x2F4
        public int boss_hp_inc_per_1 { get; set; } // 0x2F8
        public int boss_id_1 { get; set; } // 0x2FC
        public int boss_level_1 { get; set; } // 0x300
        public int boss_skill_level_1 { get; set; } // 0x304
        public int monster_ai_id_1 { get; set; } // 0x308
        public string array_skill_a_draw_per_list1 { get; set; } // 0x310
        public List<int> list_array_skill_a_draw_per_list1 = new List<int>(); // 0x318
        public string array_skill_b_draw_per_list1 { get; set; } // 0x320
        public List<int> list_array_skill_b_draw_per_list1 = new List<int>(); // 0x328
        public string array_passive1 { get; set; } // 0x330
        public List<int> list_array_passive1 = new List<int>(); // 0x338
        public int boss_atk_inc_per_2 { get; set; } // 0x340
        public int boss_def_inc_per_2 { get; set; } // 0x344
        public int boss_hp_inc_per_2 { get; set; } // 0x348
        public int boss_id_2 { get; set; } // 0x34C
        public int boss_level_2 { get; set; } // 0x350
        public int monster_ai_id_2 { get; set; } // 0x354
        public int boss_skill_level_2 { get; set; } // 0x358
        public string array_skill_a_draw_per_list2 { get; set; } // 0x360
        public List<int> list_array_skill_a_draw_per_list2 = new List<int>(); // 0x368
        public string array_skill_b_draw_per_list2 { get; set; } // 0x370
        public List<int> list_array_skill_b_draw_per_list2 = new List<int>(); // 0x378
        public string array_passive2 { get; set; } // 0x380
        public List<int> list_array_passive2 = new List<int>(); // 0x388
        public int boss_atk_inc_per_3 { get; set; } // 0x390
        public int boss_def_inc_per_3 { get; set; } // 0x394
        public int boss_hp_inc_per_3 { get; set; } // 0x398
        public int boss_id_3 { get; set; } // 0x39C
        public int boss_level_3 { get; set; } // 0x3A0
        public int monster_ai_id_3 { get; set; } // 0x3A4
        public int boss_skill_level_3 { get; set; } // 0x3A8
        public string array_skill_a_draw_per_list3 { get; set; } // 0x3B0
        public List<int> list_array_skill_a_draw_per_list3 = new List<int>(); // 0x3B8
        public string array_skill_b_draw_per_list3 { get; set; } // 0x3C0
        public List<int> list_array_skill_b_draw_per_list3 = new List<int>(); // 0x3C8
        public string array_passive3 { get; set; } // 0x3D0
        public List<int> list_array_passive3 = new List<int>(); // 0x3D8
        public int play_boss_spawn { get; set; } // 0x3E0
        public string boss_entry_type { get; set; } // 0x3E8
        public int team_power { get; set; } // 0x3F0
        public string map_filename { get; set; } // 0x3F8
        public string spawn_prop_filename { get; set; } // 0x400
        public string change_map_filename { get; set; } // 0x408
        public int bgm_sound_id { get; set; } // 0x410
        public int boss_sound_id { get; set; } // 0x414
        public string EssenCondition_1 { get; set; } // 0x418
        public int EssenConditionValue_1 { get; set; } // 0x420
        public string EssenCondition_2 { get; set; } // 0x428
        public int EssenConditionValue_2 { get; set; } // 0x430
        public string EssenCondition_3 { get; set; } // 0x438
        public int EssenConditionValue_3 { get; set; } // 0x440
        public string EssenCondition_4 { get; set; } // 0x448
        public int EssenConditionValue_4 { get; set; } // 0x450
        public string BanCondition_1 { get; set; } // 0x458
        public int BanConditionValue_1 { get; set; } // 0x460
        public string BanCondition_2 { get; set; } // 0x468
        public int BanConditionValue_2 { get; set; } // 0x470
        public string BanCondition_3 { get; set; } // 0x478
        public int BanConditionValue_3 { get; set; } // 0x480
        public string BanCondition_4 { get; set; } // 0x488
        public int BanConditionValue_4 { get; set; } // 0x490
        public string BanCondition_5 { get; set; } // 0x498
        public int BanConditionValue_5 { get; set; } // 0x4A0
        public string BanCondition_6 { get; set; } // 0x4A8
        public int BanConditionValue_6 { get; set; } // 0x4B0
        public int npc_team_id { get; set; } // 0x4B4
        public List<int> list_bgm_sound_id = new List<int>(); // 0x4B8
        public List<int> list_ambient_sound_id = new List<int>(); // 0x4C0
        public List<int> list_story_id = new List<int>(); // 0x4C8
        public List<int> list_drop_item_id = new List<int>(); // 0x4D0
        public List<int> list_drop_item_value = new List<int>(); // 0x4D8
        public List<int> list_drop_item_evolution_count = new List<int>(); // 0x4E0
        public List<int> list_drop_item_per = new List<int>(); // 0x4E8
        public List<int> list_drop_item_box = new List<int>(); // 0x4F0
        public List<int> list_chief_drop_item_id = new List<int>(); // 0x4F8
        public List<int> list_chief_drop_item_value = new List<int>(); // 0x500
        public List<int> list_chief_drop_item_evolution_count = new List<int>(); // 0x508
        public List<int> list_chief_drop_item_per = new List<int>(); // 0x510
        public List<int> list_chief_drop_item_box = new List<int>(); // 0x518
        public List<int> list_boss_atk_inc_per = new List<int>(); // 0x520
        public List<int> list_boss_def_inc_per = new List<int>(); // 0x528
        public List<int> list_boss_hp_inc_per = new List<int>(); // 0x530
        public List<int> list_boss_id = new List<int>(); // 0x538
        public List<int> list_boss_level = new List<int>(); // 0x540
        public List<int> list_boss_skill_level = new List<int>(); // 0x548
        public List<int> list_monster_ai_id = new List<int>(); // 0x550
        public List<string> list_EssenCondition = new List<string>(); // 0x558
        public List<int> list_EssenConditionValue = new List<int>(); // 0x560
        public List<string> list_BanCondition = new List<string>(); // 0x568
        public List<int> list_BanConditionValue = new List<int>(); // 0x570
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            stage_string = reader.ReadString();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            group_id = reader.ReadInt32();
            destroy_index = reader.ReadInt32();
            area_switching = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            difficulty = reader.ReadInt32();
            difficulty_lock = reader.ReadInt32();
            difficulty_string = reader.ReadString();
            info_image = reader.ReadString();
            info_guide = reader.ReadString();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            bgm_sound_id_1 = reader.ReadInt32();
            ambient_sound_id_1 = reader.ReadInt32();
            bgm_sound_id_2 = reader.ReadInt32();
            ambient_sound_id_2 = reader.ReadInt32();
            bgm_sound_id_3 = reader.ReadInt32();
            ambient_sound_id_3 = reader.ReadInt32();
            bgm_sound_id_4 = reader.ReadInt32();
            ambient_sound_id_4 = reader.ReadInt32();
            bgm_sound_id_5 = reader.ReadInt32();
            ambient_sound_id_5 = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            switching_basepoint_id = reader.ReadInt32();
            destroy_boss_id = reader.ReadInt32();
            area_icon = reader.ReadString();
            room_file_name = reader.ReadString();
            room_spawn_prop_filename = reader.ReadString();
            bg_resource_path = reader.ReadString();
            stage_bg_resource = reader.ReadString();
            room_bgm_sound_id = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            group_item_rate_add = reader.ReadInt32();
            drop_item_boss_min_count = reader.ReadInt32();
            drop_item_boss_max_count = reader.ReadInt32();
            monster_material_per = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_item_value_1 = reader.ReadInt32();
            drop_item_evolution_count_1 = reader.ReadInt32();
            drop_item_per_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_item_value_2 = reader.ReadInt32();
            drop_item_evolution_count_2 = reader.ReadInt32();
            drop_item_per_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_item_value_3 = reader.ReadInt32();
            drop_item_evolution_count_3 = reader.ReadInt32();
            drop_item_per_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            drop_item_id_4 = reader.ReadInt32();
            drop_item_value_4 = reader.ReadInt32();
            drop_item_evolution_count_4 = reader.ReadInt32();
            drop_item_per_4 = reader.ReadInt32();
            drop_item_box_4 = reader.ReadInt32();
            drop_item_id_5 = reader.ReadInt32();
            drop_item_value_5 = reader.ReadInt32();
            drop_item_evolution_count_5 = reader.ReadInt32();
            drop_item_per_5 = reader.ReadInt32();
            drop_item_box_5 = reader.ReadInt32();
            drop_item_id_6 = reader.ReadInt32();
            drop_item_value_6 = reader.ReadInt32();
            drop_item_evolution_count_6 = reader.ReadInt32();
            drop_item_per_6 = reader.ReadInt32();
            drop_item_box_6 = reader.ReadInt32();
            drop_item_id_7 = reader.ReadInt32();
            drop_item_value_7 = reader.ReadInt32();
            drop_item_evolution_count_7 = reader.ReadInt32();
            drop_item_per_7 = reader.ReadInt32();
            drop_item_box_7 = reader.ReadInt32();
            drop_item_id_8 = reader.ReadInt32();
            drop_item_value_8 = reader.ReadInt32();
            drop_item_evolution_count_8 = reader.ReadInt32();
            drop_item_per_8 = reader.ReadInt32();
            drop_item_box_8 = reader.ReadInt32();
            drop_item_id_9 = reader.ReadInt32();
            drop_item_value_9 = reader.ReadInt32();
            drop_item_evolution_count_9 = reader.ReadInt32();
            drop_item_per_9 = reader.ReadInt32();
            drop_item_box_9 = reader.ReadInt32();
            drop_item_id_10 = reader.ReadInt32();
            drop_item_value_10 = reader.ReadInt32();
            drop_item_evolution_count_10 = reader.ReadInt32();
            drop_item_per_10 = reader.ReadInt32();
            drop_item_box_10 = reader.ReadInt32();
            drop_item_id_11 = reader.ReadInt32();
            drop_item_value_11 = reader.ReadInt32();
            drop_item_evolution_count_11 = reader.ReadInt32();
            drop_item_per_11 = reader.ReadInt32();
            drop_item_box_11 = reader.ReadInt32();
            drop_item_id_12 = reader.ReadInt32();
            drop_item_value_12 = reader.ReadInt32();
            drop_item_evolution_count_12 = reader.ReadInt32();
            drop_item_per_12 = reader.ReadInt32();
            drop_item_box_12 = reader.ReadInt32();
            drop_item_id_13 = reader.ReadInt32();
            drop_item_value_13 = reader.ReadInt32();
            drop_item_evolution_count_13 = reader.ReadInt32();
            drop_item_per_13 = reader.ReadInt32();
            drop_item_box_13 = reader.ReadInt32();
            drop_item_id_14 = reader.ReadInt32();
            drop_item_value_14 = reader.ReadInt32();
            drop_item_evolution_count_14 = reader.ReadInt32();
            drop_item_per_14 = reader.ReadInt32();
            drop_item_box_14 = reader.ReadInt32();
            drop_item_id_15 = reader.ReadInt32();
            drop_item_value_15 = reader.ReadInt32();
            drop_item_evolution_count_15 = reader.ReadInt32();
            drop_item_per_15 = reader.ReadInt32();
            drop_item_box_15 = reader.ReadInt32();
            drop_item_id_16 = reader.ReadInt32();
            drop_item_value_16 = reader.ReadInt32();
            drop_item_evolution_count_16 = reader.ReadInt32();
            drop_item_per_16 = reader.ReadInt32();
            drop_item_box_16 = reader.ReadInt32();
            drop_item_id_17 = reader.ReadInt32();
            drop_item_value_17 = reader.ReadInt32();
            drop_item_evolution_count_17 = reader.ReadInt32();
            drop_item_per_17 = reader.ReadInt32();
            drop_item_box_17 = reader.ReadInt32();
            drop_item_id_18 = reader.ReadInt32();
            drop_item_value_18 = reader.ReadInt32();
            drop_item_evolution_count_18 = reader.ReadInt32();
            drop_item_per_18 = reader.ReadInt32();
            drop_item_box_18 = reader.ReadInt32();
            chief_drop_item_id_1 = reader.ReadInt32();
            chief_drop_item_value_1 = reader.ReadInt32();
            chief_drop_item_evolution_count_1 = reader.ReadInt32();
            chief_drop_item_per_1 = reader.ReadInt32();
            chief_drop_item_box_1 = reader.ReadInt32();
            chief_drop_item_id_2 = reader.ReadInt32();
            chief_drop_item_value_2 = reader.ReadInt32();
            chief_drop_item_evolution_count_2 = reader.ReadInt32();
            chief_drop_item_per_2 = reader.ReadInt32();
            chief_drop_item_box_2 = reader.ReadInt32();
            chief_drop_item_id_3 = reader.ReadInt32();
            chief_drop_item_value_3 = reader.ReadInt32();
            chief_drop_item_evolution_count_3 = reader.ReadInt32();
            chief_drop_item_per_3 = reader.ReadInt32();
            chief_drop_item_box_3 = reader.ReadInt32();
            chief_drop_item_id_4 = reader.ReadInt32();
            chief_drop_item_value_4 = reader.ReadInt32();
            chief_drop_item_evolution_count_4 = reader.ReadInt32();
            chief_drop_item_per_4 = reader.ReadInt32();
            chief_drop_item_box_4 = reader.ReadInt32();
            chief_drop_item_id_5 = reader.ReadInt32();
            chief_drop_item_value_5 = reader.ReadInt32();
            chief_drop_item_evolution_count_5 = reader.ReadInt32();
            chief_drop_item_per_5 = reader.ReadInt32();
            chief_drop_item_box_5 = reader.ReadInt32();
            chief_drop_item_id_6 = reader.ReadInt32();
            chief_drop_item_value_6 = reader.ReadInt32();
            chief_drop_item_evolution_count_6 = reader.ReadInt32();
            chief_drop_item_per_6 = reader.ReadInt32();
            chief_drop_item_box_6 = reader.ReadInt32();
            stage_placement = reader.ReadString();
            situation_behavior_tree_name = reader.ReadString();
            boss_atk_inc_per_1 = reader.ReadInt32();
            boss_def_inc_per_1 = reader.ReadInt32();
            boss_hp_inc_per_1 = reader.ReadInt32();
            boss_id_1 = reader.ReadInt32();
            boss_level_1 = reader.ReadInt32();
            boss_skill_level_1 = reader.ReadInt32();
            monster_ai_id_1 = reader.ReadInt32();
            //array_skill_a_draw_per_list1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_skill_a_draw_per_list1.Add(reader.ReadInt32());
                v0--;
            }
            //array_skill_b_draw_per_list1 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_skill_b_draw_per_list1.Add(reader.ReadInt32());
                v1--;
            }
            //array_passive1 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v2--;
            }
            boss_atk_inc_per_2 = reader.ReadInt32();
            boss_def_inc_per_2 = reader.ReadInt32();
            boss_hp_inc_per_2 = reader.ReadInt32();
            boss_id_2 = reader.ReadInt32();
            boss_level_2 = reader.ReadInt32();
            monster_ai_id_2 = reader.ReadInt32();
            boss_skill_level_2 = reader.ReadInt32();
            //array_skill_a_draw_per_list2 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_skill_a_draw_per_list2.Add(reader.ReadInt32());
                v3--;
            }
            //array_skill_b_draw_per_list2 = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_skill_b_draw_per_list2.Add(reader.ReadInt32());
                v4--;
            }
            //array_passive2 = reader.ReadString();
            var v5 = reader.ReadInt32();
            while ((v5 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v5--;
            }
            boss_atk_inc_per_3 = reader.ReadInt32();
            boss_def_inc_per_3 = reader.ReadInt32();
            boss_hp_inc_per_3 = reader.ReadInt32();
            boss_id_3 = reader.ReadInt32();
            boss_level_3 = reader.ReadInt32();
            monster_ai_id_3 = reader.ReadInt32();
            boss_skill_level_3 = reader.ReadInt32();
            //array_skill_a_draw_per_list3 = reader.ReadString();
            var v6 = reader.ReadInt32();
            while ((v6 - 1) >= 0)
            {
                list_array_skill_a_draw_per_list3.Add(reader.ReadInt32());
                v6--;
            }
            //array_skill_b_draw_per_list3 = reader.ReadString();
            var v7 = reader.ReadInt32();
            while ((v7 - 1) >= 0)
            {
                list_array_skill_b_draw_per_list3.Add(reader.ReadInt32());
                v7--;
            }
            //array_passive3 = reader.ReadString();
            var v8 = reader.ReadInt32();
            while ((v8 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v8--;
            }
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            team_power = reader.ReadInt32();
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            npc_team_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageSingleSiegeDescRow
    {
        public int id { get; set; } // 0x10
        public string destroy_strong_tribe_desc { get; set; } // 0x18
        public string destroy_weak_tribe_desc { get; set; } // 0x20
        public string destroy_strong_skill_desc { get; set; } // 0x28
        public string destroy_pattern_desc { get; set; } // 0x30
        public string destroy_skill_desc { get; set; } // 0x38
        public string destroy_passive_desc { get; set; } // 0x40
        public string destroy_idle_path { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            destroy_strong_tribe_desc = reader.ReadString();
            destroy_weak_tribe_desc = reader.ReadString();
            destroy_strong_skill_desc = reader.ReadString();
            destroy_pattern_desc = reader.ReadString();
            destroy_skill_desc = reader.ReadString();
            destroy_passive_desc = reader.ReadString();
            destroy_idle_path = reader.ReadString();
            return true;
        }
    }
    public class DBStageSubdueBossRow
    {
        public int id { get; set; } // 0x10
        public int group_id { get; set; } // 0x14
        public string stage_type { get; set; } // 0x18
        public string control_type { get; set; } // 0x20
        public int region { get; set; } // 0x28
        public int subdue_boss_index { get; set; } // 0x2C
        public int area { get; set; } // 0x30
        public int need_main_stage_id { get; set; } // 0x34
        public int difficulty { get; set; } // 0x38
        public string difficulty_string { get; set; } // 0x40
        public string info_image { get; set; } // 0x48
        public string info_guide { get; set; } // 0x50
        public string info_guide2 { get; set; } // 0x58
        public string info_guide3 { get; set; } // 0x60
        public string room_file_name { get; set; } // 0x68
        public string room_spawn_prop_filename { get; set; } // 0x70
        public string bg_resource_path { get; set; } // 0x78
        public string stage_bg_resource { get; set; } // 0x80
        public int room_bgm_sound_id { get; set; } // 0x88
        public int before_loading_id { get; set; } // 0x8C
        public int after_loading_id { get; set; } // 0x90
        public int start_cut { get; set; } // 0x94
        public int end_cut { get; set; } // 0x98
        public int story_id_1 { get; set; } // 0x9C
        public int story_id_2 { get; set; } // 0xA0
        public int story_id_3 { get; set; } // 0xA4
        public int team_power { get; set; } // 0xA8
        public int need_open_item_id { get; set; } // 0xAC
        public int need_open_count { get; set; } // 0xB0
        public int user_exp { get; set; } // 0xB4
        public int hero_exp { get; set; } // 0xB8
        public int gold_value { get; set; } // 0xBC
        public int first_reward_id { get; set; } // 0xC0
        public int first_reward_value { get; set; } // 0xC4
        public int first_evolution_count { get; set; } // 0xC8
        public int host_reward_group { get; set; } // 0xCC
        public int rank_reward_group_1 { get; set; } // 0xD0
        public int rank_reward_group_2 { get; set; } // 0xD4
        public int rank_reward_group_3 { get; set; } // 0xD8
        public int rank_reward_group_4 { get; set; } // 0xDC
        public int lost_reward_group { get; set; } // 0xE0
        public int dmg_reward_count_1 { get; set; } // 0xE4
        public int dmg_reward_group_1 { get; set; } // 0xE8
        public int dmg_reward_count_2 { get; set; } // 0xEC
        public int dmg_reward_group_2 { get; set; } // 0xF0
        public int dmg_reward_count_3 { get; set; } // 0xF4
        public int dmg_reward_group_3 { get; set; } // 0xF8
        public int dmg_reward_count_4 { get; set; } // 0xFC
        public int dmg_reward_group_4 { get; set; } // 0x100
        public int dmg_reward_count_5 { get; set; } // 0x104
        public int dmg_reward_group_5 { get; set; } // 0x108
        public int dmg_reward_count_6 { get; set; } // 0x10C
        public int dmg_reward_group_6 { get; set; } // 0x110
        public int dmg_reward_count_7 { get; set; } // 0x114
        public int dmg_reward_group_7 { get; set; } // 0x118
        public int dmg_reward_count_8 { get; set; } // 0x11C
        public int dmg_reward_group_8 { get; set; } // 0x120
        public int dmg_reward_count_9 { get; set; } // 0x124
        public int dmg_reward_group_9 { get; set; } // 0x128
        public string stage_placement { get; set; } // 0x130
        public int subdue_limited_battle_time { get; set; } // 0x138
        public string situation_behavior_tree_name { get; set; } // 0x140
        public int tag1_id { get; set; } // 0x148
        public int tag1_monster_ai_id { get; set; } // 0x14C
        public int tag1_boss_atk_inc_per { get; set; } // 0x150
        public int tag1_boss_def_inc_per { get; set; } // 0x154
        public int tag1_boss_hp_inc_per { get; set; } // 0x158
        public int tag1_boss_id { get; set; } // 0x15C
        public int tag1_boss_level { get; set; } // 0x160
        public string tag1_array_passive { get; set; } // 0x168
        public List<int> list_tag1_array_passive = new List<int>(); // 0x170
        public int tag2_id { get; set; } // 0x178
        public int tag2_monster_ai_id { get; set; } // 0x17C
        public int tag2_boss_atk_inc_per { get; set; } // 0x180
        public int tag2_boss_def_inc_per { get; set; } // 0x184
        public int tag2_boss_hp_inc_per { get; set; } // 0x188
        public int tag2_boss_id { get; set; } // 0x18C
        public int tag2_boss_level { get; set; } // 0x190
        public string tag2_array_passive { get; set; } // 0x198
        public List<int> list_tag2_array_passive = new List<int>(); // 0x1A0
        public int tag3_id { get; set; } // 0x1A8
        public int tag3_monster_ai_id { get; set; } // 0x1AC
        public int tag3_boss_atk_inc_per { get; set; } // 0x1B0
        public int tag3_boss_def_inc_per { get; set; } // 0x1B4
        public int tag3_boss_hp_inc_per { get; set; } // 0x1B8
        public int tag3_boss_id { get; set; } // 0x1BC
        public int tag3_boss_level { get; set; } // 0x1C0
        public string tag3_array_passive { get; set; } // 0x1C8
        public List<int> list_tag3_array_passive = new List<int>(); // 0x1D0
        public int play_boss_spawn { get; set; } // 0x1D8
        public string boss_entry_type { get; set; } // 0x1E0
        public string array_ally_passive_id { get; set; } // 0x1E8
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x1F0
        public string map_filename { get; set; } // 0x1F8
        public string spawn_prop_filename { get; set; } // 0x200
        public string change_map_filename { get; set; } // 0x208
        public int bgm_sound_id { get; set; } // 0x210
        public int boss_sound_id { get; set; } // 0x214
        public string EssenCondition_1 { get; set; } // 0x218
        public int EssenConditionValue_1 { get; set; } // 0x220
        public string EssenCondition_2 { get; set; } // 0x228
        public int EssenConditionValue_2 { get; set; } // 0x230
        public string EssenCondition_3 { get; set; } // 0x238
        public int EssenConditionValue_3 { get; set; } // 0x240
        public string EssenCondition_4 { get; set; } // 0x248
        public int EssenConditionValue_4 { get; set; } // 0x250
        public string BanCondition_1 { get; set; } // 0x258
        public int BanConditionValue_1 { get; set; } // 0x260
        public string BanCondition_2 { get; set; } // 0x268
        public int BanConditionValue_2 { get; set; } // 0x270
        public string BanCondition_3 { get; set; } // 0x278
        public int BanConditionValue_3 { get; set; } // 0x280
        public string BanCondition_4 { get; set; } // 0x288
        public int BanConditionValue_4 { get; set; } // 0x290
        public string BanCondition_5 { get; set; } // 0x298
        public int BanConditionValue_5 { get; set; } // 0x2A0
        public string BanCondition_6 { get; set; } // 0x2A8
        public int BanConditionValue_6 { get; set; } // 0x2B0
        public List<int> list_story_id = new List<int>(); // 0x2B8
        public List<int> list_rank_reward_group = new List<int>(); // 0x2C0
        public List<int> list_dmg_reward_count = new List<int>(); // 0x2C8
        public List<int> list_dmg_reward_group = new List<int>(); // 0x2D0
        public List<string> list_EssenCondition = new List<string>(); // 0x2D8
        public List<int> list_EssenConditionValue = new List<int>(); // 0x2E0
        public List<string> list_BanCondition = new List<string>(); // 0x2E8
        public List<int> list_BanConditionValue = new List<int>(); // 0x2F0
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            stage_type = reader.ReadString();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            subdue_boss_index = reader.ReadInt32();
            area = reader.ReadInt32();
            need_main_stage_id = reader.ReadInt32();
            difficulty = reader.ReadInt32();
            difficulty_string = reader.ReadString();
            info_image = reader.ReadString();
            info_guide = reader.ReadString();
            info_guide2 = reader.ReadString();
            info_guide3 = reader.ReadString();
            room_file_name = reader.ReadString();
            room_spawn_prop_filename = reader.ReadString();
            bg_resource_path = reader.ReadString();
            stage_bg_resource = reader.ReadString();
            room_bgm_sound_id = reader.ReadInt32();
            before_loading_id = reader.ReadInt32();
            after_loading_id = reader.ReadInt32();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            team_power = reader.ReadInt32();
            need_open_item_id = reader.ReadInt32();
            need_open_count = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            first_evolution_count = reader.ReadInt32();
            host_reward_group = reader.ReadInt32();
            rank_reward_group_1 = reader.ReadInt32();
            rank_reward_group_2 = reader.ReadInt32();
            rank_reward_group_3 = reader.ReadInt32();
            rank_reward_group_4 = reader.ReadInt32();
            lost_reward_group = reader.ReadInt32();
            dmg_reward_count_1 = reader.ReadInt32();
            dmg_reward_group_1 = reader.ReadInt32();
            dmg_reward_count_2 = reader.ReadInt32();
            dmg_reward_group_2 = reader.ReadInt32();
            dmg_reward_count_3 = reader.ReadInt32();
            dmg_reward_group_3 = reader.ReadInt32();
            dmg_reward_count_4 = reader.ReadInt32();
            dmg_reward_group_4 = reader.ReadInt32();
            dmg_reward_count_5 = reader.ReadInt32();
            dmg_reward_group_5 = reader.ReadInt32();
            dmg_reward_count_6 = reader.ReadInt32();
            dmg_reward_group_6 = reader.ReadInt32();
            dmg_reward_count_7 = reader.ReadInt32();
            dmg_reward_group_7 = reader.ReadInt32();
            dmg_reward_count_8 = reader.ReadInt32();
            dmg_reward_group_8 = reader.ReadInt32();
            dmg_reward_count_9 = reader.ReadInt32();
            dmg_reward_group_9 = reader.ReadInt32();
            stage_placement = reader.ReadString();
            subdue_limited_battle_time = reader.ReadInt32();
            situation_behavior_tree_name = reader.ReadString();
            tag1_id = reader.ReadInt32();
            tag1_monster_ai_id = reader.ReadInt32();
            tag1_boss_atk_inc_per = reader.ReadInt32();
            tag1_boss_def_inc_per = reader.ReadInt32();
            tag1_boss_hp_inc_per = reader.ReadInt32();
            tag1_boss_id = reader.ReadInt32();
            tag1_boss_level = reader.ReadInt32();
            //tag1_array_passive = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_tag1_array_passive.Add(reader.ReadInt32());
                v0--;
            }
            tag2_id = reader.ReadInt32();
            tag2_monster_ai_id = reader.ReadInt32();
            tag2_boss_atk_inc_per = reader.ReadInt32();
            tag2_boss_def_inc_per = reader.ReadInt32();
            tag2_boss_hp_inc_per = reader.ReadInt32();
            tag2_boss_id = reader.ReadInt32();
            tag2_boss_level = reader.ReadInt32();
            //tag2_array_passive = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_tag2_array_passive.Add(reader.ReadInt32());
                v1--;
            }
            tag3_id = reader.ReadInt32();
            tag3_monster_ai_id = reader.ReadInt32();
            tag3_boss_atk_inc_per = reader.ReadInt32();
            tag3_boss_def_inc_per = reader.ReadInt32();
            tag3_boss_hp_inc_per = reader.ReadInt32();
            tag3_boss_id = reader.ReadInt32();
            tag3_boss_level = reader.ReadInt32();
            //tag3_array_passive = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_tag3_array_passive.Add(reader.ReadInt32());
                v2--;
            }
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v3--;
            }
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageSubdueBossGroupRow
    {
        public int group_id { get; set; } // 0x10
        public string active_start { get; set; } // 0x18
        public string active_end { get; set; } // 0x20
        public int play_count_reset_time { get; set; } // 0x28
        public int play_count { get; set; } // 0x2C
        public string group_string { get; set; } // 0x30
        public string stage_string { get; set; } // 0x38
        public string group_bg_resource { get; set; } // 0x40
        public int banner_priority { get; set; } // 0x48
        public string large_popup { get; set; } // 0x50
        public string event_banner { get; set; } // 0x58
        public string banner_info { get; set; } // 0x60
        public int subdue_group_cutin { get; set; } // 0x68
        public int subdue_main_lobby_button { get; set; } // 0x6C
        public string lobby_subdue_icon_name { get; set; } // 0x70
        public List<int> list_array_exchange_event_group = new List<int>(); // 0x78
        public bool ReadToStream(BinaryReader reader)
        {
            group_id = reader.ReadInt32();
            active_start = reader.ReadString();
            active_end = reader.ReadString();
            play_count_reset_time = reader.ReadInt32();
            play_count = reader.ReadInt32();
            group_string = reader.ReadString();
            stage_string = reader.ReadString();
            group_bg_resource = reader.ReadString();
            banner_priority = reader.ReadInt32();
            large_popup = reader.ReadString();
            event_banner = reader.ReadString();
            banner_info = reader.ReadString();
            subdue_group_cutin = reader.ReadInt32();
            subdue_main_lobby_button = reader.ReadInt32();
            lobby_subdue_icon_name = reader.ReadString();
            //array_exchange_event_group = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_exchange_event_group.Add(reader.ReadInt32());
                v0--;
            }
            return true;
        }
    }
    public class DBStageSubdueBossRewardRow
    {
        public int index { get; set; } // 0x10
        public string reward_type { get; set; } // 0x18
        public int reward_subdue_boss_group_id { get; set; } // 0x20
        public int reward_item_id_1 { get; set; } // 0x24
        public int reward_item_count_1 { get; set; } // 0x28
        public int drop_item_box_1 { get; set; } // 0x2C
        public int reward_item_evolution_count_1 { get; set; } // 0x30
        public int reward_item_id_2 { get; set; } // 0x34
        public int reward_item_count_2 { get; set; } // 0x38
        public int drop_item_box_2 { get; set; } // 0x3C
        public int reward_item_evolution_count_2 { get; set; } // 0x40
        public int reward_item_id_3 { get; set; } // 0x44
        public int reward_item_count_3 { get; set; } // 0x48
        public int drop_item_box_3 { get; set; } // 0x4C
        public int reward_item_evolution_count_3 { get; set; } // 0x50
        public List<int> list_reward_item_id = new List<int>(); // 0x58
        public List<int> list_reward_item_count = new List<int>(); // 0x60
        public List<int> list_drop_item_box = new List<int>(); // 0x68
        public List<int> list_reward_item_evolution_count = new List<int>(); // 0x70
        public bool ReadToStream(BinaryReader reader)
        {
            index = reader.ReadInt32();
            reward_type = reader.ReadString();
            reward_subdue_boss_group_id = reader.ReadInt32();
            reward_item_id_1 = reader.ReadInt32();
            reward_item_count_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            reward_item_evolution_count_1 = reader.ReadInt32();
            reward_item_id_2 = reader.ReadInt32();
            reward_item_count_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            reward_item_evolution_count_2 = reader.ReadInt32();
            reward_item_id_3 = reader.ReadInt32();
            reward_item_count_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            reward_item_evolution_count_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageSubdueTagRow
    {
        public int id { get; set; } // 0x10
        public string tag_icon_file_name { get; set; } // 0x18
        public string array_tag_gauge_colorcode { get; set; } // 0x20
        public List<int> list_array_tag_gauge_colorcode = new List<int>(); // 0x28
        public string tag_change_type_1 { get; set; } // 0x30
        public int tag_change_value_1 { get; set; } // 0x38
        public string tag_change_boss_1 { get; set; } // 0x40
        public string tag_change_ani_1 { get; set; } // 0x48
        public string tag_change_type_2 { get; set; } // 0x50
        public int tag_change_value_2 { get; set; } // 0x58
        public string tag_change_boss_2 { get; set; } // 0x60
        public string tag_change_ani_2 { get; set; } // 0x68
        public List<string> list_tag_change_type = new List<string>(); // 0x70
        public List<int> list_tag_change_value = new List<int>(); // 0x78
        public List<string> list_tag_change_boss = new List<string>(); // 0x80
        public List<string> list_tag_change_ani = new List<string>(); // 0x88
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            tag_icon_file_name = reader.ReadString();
            //array_tag_gauge_colorcode = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_tag_gauge_colorcode.Add(reader.ReadInt32());
                v0--;
            }
            tag_change_type_1 = reader.ReadString();
            tag_change_value_1 = reader.ReadInt32();
            tag_change_boss_1 = reader.ReadString();
            tag_change_ani_1 = reader.ReadString();
            tag_change_type_2 = reader.ReadString();
            tag_change_value_2 = reader.ReadInt32();
            tag_change_boss_2 = reader.ReadString();
            tag_change_ani_2 = reader.ReadString();
            return true;
        }
    }
    public class DBStageTrainingRow
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string stage_string { get; set; } // 0x20
        public string control_type { get; set; } // 0x28
        public int region { get; set; } // 0x30
        public int stage_end_character_area { get; set; } // 0x34
        public int amber_npc_id { get; set; } // 0x38
        public string amber_icon { get; set; } // 0x40
        public string amber_type { get; set; } // 0x48
        public int training_battle_type { get; set; } // 0x50
        public int index { get; set; } // 0x54
        public int need_quest_id { get; set; } // 0x58
        public int need_main_stage_id { get; set; } // 0x5C
        public string array_contents_check { get; set; } // 0x60
        public List<string> list_array_contents_check = new List<string>(); // 0x68
        public int difficulty { get; set; } // 0x70
        public string difficulty_string { get; set; } // 0x78
        public int start_cut { get; set; } // 0x80
        public int end_cut { get; set; } // 0x84
        public int story_id_1 { get; set; } // 0x88
        public int story_id_2 { get; set; } // 0x8C
        public int story_id_3 { get; set; } // 0x90
        public int need_stamina_item_id { get; set; } // 0x94
        public int need_stamina_count { get; set; } // 0x98
        public int user_exp { get; set; } // 0x9C
        public int hero_exp { get; set; } // 0xA0
        public int gold_value { get; set; } // 0xA4
        public int fix_reward_id { get; set; } // 0xA8
        public int fix_reward_count { get; set; } // 0xAC
        public int fix_reward_box { get; set; } // 0xB0
        public int drop_item_normal_min_count { get; set; } // 0xB4
        public int drop_item_normal_max_count { get; set; } // 0xB8
        public int drop_item_boss_min_count { get; set; } // 0xBC
        public int drop_item_boss_max_count { get; set; } // 0xC0
        public int monster_material_per { get; set; } // 0xC4
        public int drop_item_id_1 { get; set; } // 0xC8
        public int drop_item_value_1 { get; set; } // 0xCC
        public int drop_item_evolution_count_1 { get; set; } // 0xD0
        public int drop_item_per_1 { get; set; } // 0xD4
        public int drop_item_box_1 { get; set; } // 0xD8
        public int drop_item_id_2 { get; set; } // 0xDC
        public int drop_item_value_2 { get; set; } // 0xE0
        public int drop_item_evolution_count_2 { get; set; } // 0xE4
        public int drop_item_per_2 { get; set; } // 0xE8
        public int drop_item_box_2 { get; set; } // 0xEC
        public int drop_item_id_3 { get; set; } // 0xF0
        public int drop_item_value_3 { get; set; } // 0xF4
        public int drop_item_evolution_count_3 { get; set; } // 0xF8
        public int drop_item_per_3 { get; set; } // 0xFC
        public int drop_item_box_3 { get; set; } // 0x100
        public int drop_item_id_4 { get; set; } // 0x104
        public int drop_item_value_4 { get; set; } // 0x108
        public int drop_item_evolution_count_4 { get; set; } // 0x10C
        public int drop_item_per_4 { get; set; } // 0x110
        public int drop_item_box_4 { get; set; } // 0x114
        public int drop_item_id_5 { get; set; } // 0x118
        public int drop_item_value_5 { get; set; } // 0x11C
        public int drop_item_evolution_count_5 { get; set; } // 0x120
        public int drop_item_per_5 { get; set; } // 0x124
        public int drop_item_box_5 { get; set; } // 0x128
        public int drop_item_id_6 { get; set; } // 0x12C
        public int drop_item_value_6 { get; set; } // 0x130
        public int drop_item_evolution_count_6 { get; set; } // 0x134
        public int drop_item_per_6 { get; set; } // 0x138
        public int drop_item_box_6 { get; set; } // 0x13C
        public int drop_item_id_7 { get; set; } // 0x140
        public int drop_item_value_7 { get; set; } // 0x144
        public int drop_item_evolution_count_7 { get; set; } // 0x148
        public int drop_item_per_7 { get; set; } // 0x14C
        public int drop_item_box_7 { get; set; } // 0x150
        public int drop_item_id_8 { get; set; } // 0x154
        public int drop_item_value_8 { get; set; } // 0x158
        public int drop_item_evolution_count_8 { get; set; } // 0x15C
        public int drop_item_per_8 { get; set; } // 0x160
        public int drop_item_box_8 { get; set; } // 0x164
        public int drop_item_id_9 { get; set; } // 0x168
        public int drop_item_value_9 { get; set; } // 0x16C
        public int drop_item_evolution_count_9 { get; set; } // 0x170
        public int drop_item_per_9 { get; set; } // 0x174
        public int drop_item_box_9 { get; set; } // 0x178
        public int drop_item_id_10 { get; set; } // 0x17C
        public int drop_item_value_10 { get; set; } // 0x180
        public int drop_item_evolution_count_10 { get; set; } // 0x184
        public int drop_item_per_10 { get; set; } // 0x188
        public int drop_item_box_10 { get; set; } // 0x18C
        public int drop_item_id_11 { get; set; } // 0x190
        public int drop_item_value_11 { get; set; } // 0x194
        public int drop_item_evolution_count_11 { get; set; } // 0x198
        public int drop_item_per_11 { get; set; } // 0x19C
        public int drop_item_box_11 { get; set; } // 0x1A0
        public int drop_item_id_12 { get; set; } // 0x1A4
        public int drop_item_value_12 { get; set; } // 0x1A8
        public int drop_item_evolution_count_12 { get; set; } // 0x1AC
        public int drop_item_per_12 { get; set; } // 0x1B0
        public int drop_item_box_12 { get; set; } // 0x1B4
        public int monster_count { get; set; } // 0x1B8
        public int monster_level { get; set; } // 0x1BC
        public int monster_atk_inc_per { get; set; } // 0x1C0
        public int monster_def_inc_per { get; set; } // 0x1C4
        public int monster_hp_inc_per { get; set; } // 0x1C8
        public int monster_id_1 { get; set; } // 0x1CC
        public int monster_id_2 { get; set; } // 0x1D0
        public int monster_id_3 { get; set; } // 0x1D4
        public int monster_id_4 { get; set; } // 0x1D8
        public int monster_id_5 { get; set; } // 0x1DC
        public int monster_id_6 { get; set; } // 0x1E0
        public int monster_id_7 { get; set; } // 0x1E4
        public int monster_id_8 { get; set; } // 0x1E8
        public int monster_material_box_1 { get; set; } // 0x1EC
        public int is_turn_pivot { get; set; } // 0x1F0
        public string stage_placement { get; set; } // 0x1F8
        public int stage_hero_entry_all { get; set; } // 0x200
        public int monster_ai_id { get; set; } // 0x204
        public int boss_atk_inc_per { get; set; } // 0x208
        public int boss_def_inc_per { get; set; } // 0x20C
        public int boss_hp_inc_per { get; set; } // 0x210
        public int boss_id_1 { get; set; } // 0x214
        public int boss_material_box_1 { get; set; } // 0x218
        public int boss_level_1 { get; set; } // 0x21C
        public string array_passive1 { get; set; } // 0x220
        public List<int> list_array_passive1 = new List<int>(); // 0x228
        public int boss_id_2 { get; set; } // 0x230
        public int boss_material_box_2 { get; set; } // 0x234
        public int boss_level_2 { get; set; } // 0x238
        public string array_passive2 { get; set; } // 0x240
        public List<int> list_array_passive2 = new List<int>(); // 0x248
        public int boss_id_3 { get; set; } // 0x250
        public int boss_material_box_3 { get; set; } // 0x254
        public int boss_level_3 { get; set; } // 0x258
        public string array_passive3 { get; set; } // 0x260
        public List<int> list_array_passive3 = new List<int>(); // 0x268
        public int boss_id_4 { get; set; } // 0x270
        public int boss_material_box_4 { get; set; } // 0x274
        public int boss_level_4 { get; set; } // 0x278
        public string array_passive4 { get; set; } // 0x280
        public List<int> list_array_passive4 = new List<int>(); // 0x288
        public int play_boss_spawn { get; set; } // 0x290
        public string boss_entry_type { get; set; } // 0x298
        public string array_ally_passive_id { get; set; } // 0x2A0
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x2A8
        public int team_power { get; set; } // 0x2B0
        public string map_filename { get; set; } // 0x2B8
        public string spawn_prop_filename { get; set; } // 0x2C0
        public string change_map_filename { get; set; } // 0x2C8
        public int bgm_sound_id { get; set; } // 0x2D0
        public int boss_sound_id { get; set; } // 0x2D4
        public string EssenCondition_1 { get; set; } // 0x2D8
        public int EssenConditionValue_1 { get; set; } // 0x2E0
        public string EssenCondition_2 { get; set; } // 0x2E8
        public int EssenConditionValue_2 { get; set; } // 0x2F0
        public string EssenCondition_3 { get; set; } // 0x2F8
        public int EssenConditionValue_3 { get; set; } // 0x300
        public string EssenCondition_4 { get; set; } // 0x308
        public int EssenConditionValue_4 { get; set; } // 0x310
        public string BanCondition_1 { get; set; } // 0x318
        public int BanConditionValue_1 { get; set; } // 0x320
        public string BanCondition_2 { get; set; } // 0x328
        public int BanConditionValue_2 { get; set; } // 0x330
        public string BanCondition_3 { get; set; } // 0x338
        public int BanConditionValue_3 { get; set; } // 0x340
        public string BanCondition_4 { get; set; } // 0x348
        public int BanConditionValue_4 { get; set; } // 0x350
        public string BanCondition_5 { get; set; } // 0x358
        public int BanConditionValue_5 { get; set; } // 0x360
        public string BanCondition_6 { get; set; } // 0x368
        public int BanConditionValue_6 { get; set; } // 0x370
        public List<int> list_story_id = new List<int>(); // 0x378
        public List<int> list_drop_item_id = new List<int>(); // 0x380
        public List<int> list_drop_item_value = new List<int>(); // 0x388
        public List<int> list_drop_item_evolution_count = new List<int>(); // 0x390
        public List<int> list_drop_item_per = new List<int>(); // 0x398
        public List<int> list_drop_item_box = new List<int>(); // 0x3A0
        public List<int> list_monster_id = new List<int>(); // 0x3A8
        public List<int> list_monster_material_box = new List<int>(); // 0x3B0
        public List<int> list_boss_id = new List<int>(); // 0x3B8
        public List<int> list_boss_material_box = new List<int>(); // 0x3C0
        public List<int> list_boss_level = new List<int>(); // 0x3C8
        public List<string> list_EssenCondition = new List<string>(); // 0x3D0
        public List<int> list_EssenConditionValue = new List<int>(); // 0x3D8
        public List<string> list_BanCondition = new List<string>(); // 0x3E0
        public List<int> list_BanConditionValue = new List<int>(); // 0x3E8
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            type = reader.ReadString();
            stage_string = reader.ReadString();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            stage_end_character_area = reader.ReadInt32();
            amber_npc_id = reader.ReadInt32();
            amber_icon = reader.ReadString();
            amber_type = reader.ReadString();
            training_battle_type = reader.ReadInt32();
            index = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            need_main_stage_id = reader.ReadInt32();
            //array_contents_check = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_contents_check.Add(reader.ReadString());
                v0--;
            }
            difficulty = reader.ReadInt32();
            difficulty_string = reader.ReadString();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            fix_reward_id = reader.ReadInt32();
            fix_reward_count = reader.ReadInt32();
            fix_reward_box = reader.ReadInt32();
            drop_item_normal_min_count = reader.ReadInt32();
            drop_item_normal_max_count = reader.ReadInt32();
            drop_item_boss_min_count = reader.ReadInt32();
            drop_item_boss_max_count = reader.ReadInt32();
            monster_material_per = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_item_value_1 = reader.ReadInt32();
            drop_item_evolution_count_1 = reader.ReadInt32();
            drop_item_per_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_item_value_2 = reader.ReadInt32();
            drop_item_evolution_count_2 = reader.ReadInt32();
            drop_item_per_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_item_value_3 = reader.ReadInt32();
            drop_item_evolution_count_3 = reader.ReadInt32();
            drop_item_per_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            drop_item_id_4 = reader.ReadInt32();
            drop_item_value_4 = reader.ReadInt32();
            drop_item_evolution_count_4 = reader.ReadInt32();
            drop_item_per_4 = reader.ReadInt32();
            drop_item_box_4 = reader.ReadInt32();
            drop_item_id_5 = reader.ReadInt32();
            drop_item_value_5 = reader.ReadInt32();
            drop_item_evolution_count_5 = reader.ReadInt32();
            drop_item_per_5 = reader.ReadInt32();
            drop_item_box_5 = reader.ReadInt32();
            drop_item_id_6 = reader.ReadInt32();
            drop_item_value_6 = reader.ReadInt32();
            drop_item_evolution_count_6 = reader.ReadInt32();
            drop_item_per_6 = reader.ReadInt32();
            drop_item_box_6 = reader.ReadInt32();
            drop_item_id_7 = reader.ReadInt32();
            drop_item_value_7 = reader.ReadInt32();
            drop_item_evolution_count_7 = reader.ReadInt32();
            drop_item_per_7 = reader.ReadInt32();
            drop_item_box_7 = reader.ReadInt32();
            drop_item_id_8 = reader.ReadInt32();
            drop_item_value_8 = reader.ReadInt32();
            drop_item_evolution_count_8 = reader.ReadInt32();
            drop_item_per_8 = reader.ReadInt32();
            drop_item_box_8 = reader.ReadInt32();
            drop_item_id_9 = reader.ReadInt32();
            drop_item_value_9 = reader.ReadInt32();
            drop_item_evolution_count_9 = reader.ReadInt32();
            drop_item_per_9 = reader.ReadInt32();
            drop_item_box_9 = reader.ReadInt32();
            drop_item_id_10 = reader.ReadInt32();
            drop_item_value_10 = reader.ReadInt32();
            drop_item_evolution_count_10 = reader.ReadInt32();
            drop_item_per_10 = reader.ReadInt32();
            drop_item_box_10 = reader.ReadInt32();
            drop_item_id_11 = reader.ReadInt32();
            drop_item_value_11 = reader.ReadInt32();
            drop_item_evolution_count_11 = reader.ReadInt32();
            drop_item_per_11 = reader.ReadInt32();
            drop_item_box_11 = reader.ReadInt32();
            drop_item_id_12 = reader.ReadInt32();
            drop_item_value_12 = reader.ReadInt32();
            drop_item_evolution_count_12 = reader.ReadInt32();
            drop_item_per_12 = reader.ReadInt32();
            drop_item_box_12 = reader.ReadInt32();
            monster_count = reader.ReadInt32();
            monster_level = reader.ReadInt32();
            monster_atk_inc_per = reader.ReadInt32();
            monster_def_inc_per = reader.ReadInt32();
            monster_hp_inc_per = reader.ReadInt32();
            monster_id_1 = reader.ReadInt32();
            monster_id_2 = reader.ReadInt32();
            monster_id_3 = reader.ReadInt32();
            monster_id_4 = reader.ReadInt32();
            monster_id_5 = reader.ReadInt32();
            monster_id_6 = reader.ReadInt32();
            monster_id_7 = reader.ReadInt32();
            monster_id_8 = reader.ReadInt32();
            monster_material_box_1 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            stage_placement = reader.ReadString();
            stage_hero_entry_all = reader.ReadInt32();
            monster_ai_id = reader.ReadInt32();
            boss_atk_inc_per = reader.ReadInt32();
            boss_def_inc_per = reader.ReadInt32();
            boss_hp_inc_per = reader.ReadInt32();
            boss_id_1 = reader.ReadInt32();
            boss_material_box_1 = reader.ReadInt32();
            boss_level_1 = reader.ReadInt32();
            //array_passive1 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v1--;
            }
            boss_id_2 = reader.ReadInt32();
            boss_material_box_2 = reader.ReadInt32();
            boss_level_2 = reader.ReadInt32();
            //array_passive2 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v2--;
            }
            boss_id_3 = reader.ReadInt32();
            boss_material_box_3 = reader.ReadInt32();
            boss_level_3 = reader.ReadInt32();
            //array_passive3 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v3--;
            }
            boss_id_4 = reader.ReadInt32();
            boss_material_box_4 = reader.ReadInt32();
            boss_level_4 = reader.ReadInt32();
            //array_passive4 = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_passive4.Add(reader.ReadInt32());
                v4--;
            }
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v5 = reader.ReadInt32();
            while ((v5 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v5--;
            }
            team_power = reader.ReadInt32();
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageTrainingPlayCountRow
    {
        public int hero_skin_rating { get; set; } // 0x10
        public int play_count { get; set; } // 0x14
        public bool ReadToStream(BinaryReader reader)
        {
            hero_skin_rating = reader.ReadInt32();
            play_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageTrainingSetupRow
    {
        public int id { get; set; } // 0x10
        public string week_setup { get; set; } // 0x18
        public int materialstage_1 { get; set; } // 0x20
        public int materialstage_2 { get; set; } // 0x24
        public int materialstage_3 { get; set; } // 0x28
        public int materialstage_4 { get; set; } // 0x2C
        public int materialstage_5 { get; set; } // 0x30
        public int open_time_1 { get; set; } // 0x34
        public int close_time_1 { get; set; } // 0x38
        public int open_time_2 { get; set; } // 0x3C
        public int close_time_2 { get; set; } // 0x40
        public int open_time_3 { get; set; } // 0x44
        public int close_time_3 { get; set; } // 0x48
        public List<int> list_materialstage = new List<int>(); // 0x50
        public List<int> list_open_time = new List<int>(); // 0x58
        public List<int> list_close_time = new List<int>(); // 0x60
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            week_setup = reader.ReadString();
            materialstage_1 = reader.ReadInt32();
            materialstage_2 = reader.ReadInt32();
            materialstage_3 = reader.ReadInt32();
            materialstage_4 = reader.ReadInt32();
            materialstage_5 = reader.ReadInt32();
            open_time_1 = reader.ReadInt32();
            close_time_1 = reader.ReadInt32();
            open_time_2 = reader.ReadInt32();
            close_time_2 = reader.ReadInt32();
            open_time_3 = reader.ReadInt32();
            close_time_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageTrainingTaskRow
    {
        public int id { get; set; } // 0x10
        public string task_group { get; set; } // 0x18
        public int task_group_rate { get; set; } // 0x20
        public string task_type { get; set; } // 0x28
        public int task_value_1 { get; set; } // 0x30
        public int task_value_2 { get; set; } // 0x34
        public string task_reward_type { get; set; } // 0x38
        public int task_reward_value_1 { get; set; } // 0x40
        public int task_reward_value_2 { get; set; } // 0x44
        public string task_reward_icon { get; set; } // 0x48
        public string task_name { get; set; } // 0x50
        public string task_desc { get; set; } // 0x58
        public List<int> list_task_value = new List<int>(); // 0x60
        public List<int> list_task_reward_value = new List<int>(); // 0x68
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            task_group = reader.ReadString();
            task_group_rate = reader.ReadInt32();
            task_type = reader.ReadString();
            task_value_1 = reader.ReadInt32();
            task_value_2 = reader.ReadInt32();
            task_reward_type = reader.ReadString();
            task_reward_value_1 = reader.ReadInt32();
            task_reward_value_2 = reader.ReadInt32();
            task_reward_icon = reader.ReadString();
            task_name = reader.ReadString();
            task_desc = reader.ReadString();
            return true;
        }
    }
    public class DBStageTypeRow
    {
        public int id { get; set; } // 0x10
        public string control_type { get; set; } // 0x18
        public int friend_control { get; set; } // 0x20
        public int auto_replay { get; set; } // 0x24
        public int auto_control { get; set; } // 0x28
        public int restart_control { get; set; } // 0x2C
        public int continue_control { get; set; } // 0x30
        public int change_monster_ai { get; set; } // 0x34
        public int continue_number_limited { get; set; } // 0x38
        public int continue_cost_id { get; set; } // 0x3C
        public int continue_cost_count { get; set; } // 0x40
        public int clear_ticket { get; set; } // 0x44
        public int clear_ticket_limit { get; set; } // 0x48
        public int rejoin_control { get; set; } // 0x4C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            control_type = reader.ReadString();
            friend_control = reader.ReadInt32();
            auto_replay = reader.ReadInt32();
            auto_control = reader.ReadInt32();
            restart_control = reader.ReadInt32();
            continue_control = reader.ReadInt32();
            change_monster_ai = reader.ReadInt32();
            continue_number_limited = reader.ReadInt32();
            continue_cost_id = reader.ReadInt32();
            continue_cost_count = reader.ReadInt32();
            clear_ticket = reader.ReadInt32();
            clear_ticket_limit = reader.ReadInt32();
            rejoin_control = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageWeekRow
    {
        public int id { get; set; } // 0x10
        public string stage_type { get; set; } // 0x18
        public string type { get; set; } // 0x20
        public int group { get; set; } // 0x28
        public string type_local { get; set; } // 0x30
        public string stage_string { get; set; } // 0x38
        public string control_type { get; set; } // 0x40
        public int region { get; set; } // 0x48
        public int log_region { get; set; } // 0x4C
        public int limit_index { get; set; } // 0x50
        public int log_index { get; set; } // 0x54
        public int weekly_index { get; set; } // 0x58
        public int area { get; set; } // 0x5C
        public int need_quest_id { get; set; } // 0x60
        public int need_stage_id { get; set; } // 0x64
        public int next_stage_id { get; set; } // 0x68
        public int difficulty { get; set; } // 0x6C
        public string difficulty_string { get; set; } // 0x70
        public int start_cut { get; set; } // 0x78
        public int end_cut { get; set; } // 0x7C
        public int story_id_1 { get; set; } // 0x80
        public int story_id_2 { get; set; } // 0x84
        public int story_id_3 { get; set; } // 0x88
        public int need_stamina_item_id { get; set; } // 0x8C
        public int need_stamina_count { get; set; } // 0x90
        public int play_reward_gauge_point { get; set; } // 0x94
        public int need_key_item_id { get; set; } // 0x98
        public int need_key_count { get; set; } // 0x9C
        public int user_exp { get; set; } // 0xA0
        public int hero_exp { get; set; } // 0xA4
        public int gold_value { get; set; } // 0xA8
        public int first_reward_id { get; set; } // 0xAC
        public int first_reward_value { get; set; } // 0xB0
        public int reward_id_1 { get; set; } // 0xB4
        public int reward_value_1 { get; set; } // 0xB8
        public int reward_value_box_1 { get; set; } // 0xBC
        public int reward_id_2 { get; set; } // 0xC0
        public int reward_value_2 { get; set; } // 0xC4
        public int reward_value_box_2 { get; set; } // 0xC8
        public int reward_id_3 { get; set; } // 0xCC
        public int reward_value_3 { get; set; } // 0xD0
        public int reward_value_box_3 { get; set; } // 0xD4
        public int reward_id_4 { get; set; } // 0xD8
        public int reward_value_4 { get; set; } // 0xDC
        public int reward_value_box_4 { get; set; } // 0xE0
        public int reward_id_5 { get; set; } // 0xE4
        public int reward_value_5 { get; set; } // 0xE8
        public int reward_value_box_5 { get; set; } // 0xEC
        public int reward_id_6 { get; set; } // 0xF0
        public int reward_value_6 { get; set; } // 0xF4
        public int reward_value_box_6 { get; set; } // 0xF8
        public int reward_id_7 { get; set; } // 0xFC
        public int reward_value_7 { get; set; } // 0x100
        public int reward_value_box_7 { get; set; } // 0x104
        public int reward_id_8 { get; set; } // 0x108
        public int reward_value_8 { get; set; } // 0x10C
        public int reward_value_box_8 { get; set; } // 0x110
        public int drop_item_normal_min_count { get; set; } // 0x114
        public int drop_item_normal_max_count { get; set; } // 0x118
        public int drop_item_boss_min_count { get; set; } // 0x11C
        public int drop_item_boss_max_count { get; set; } // 0x120
        public int monster_material_per { get; set; } // 0x124
        public int drop_item_id_1 { get; set; } // 0x128
        public int drop_item_value_1 { get; set; } // 0x12C
        public int drop_item_evolution_count_1 { get; set; } // 0x130
        public int drop_item_per_1 { get; set; } // 0x134
        public int drop_item_box_1 { get; set; } // 0x138
        public int drop_item_id_2 { get; set; } // 0x13C
        public int drop_item_value_2 { get; set; } // 0x140
        public int drop_item_evolution_count_2 { get; set; } // 0x144
        public int drop_item_per_2 { get; set; } // 0x148
        public int drop_item_box_2 { get; set; } // 0x14C
        public int drop_item_id_3 { get; set; } // 0x150
        public int drop_item_value_3 { get; set; } // 0x154
        public int drop_item_evolution_count_3 { get; set; } // 0x158
        public int drop_item_per_3 { get; set; } // 0x15C
        public int drop_item_box_3 { get; set; } // 0x160
        public int drop_item_id_4 { get; set; } // 0x164
        public int drop_item_value_4 { get; set; } // 0x168
        public int drop_item_evolution_count_4 { get; set; } // 0x16C
        public int drop_item_per_4 { get; set; } // 0x170
        public int drop_item_box_4 { get; set; } // 0x174
        public int drop_item_id_5 { get; set; } // 0x178
        public int drop_item_value_5 { get; set; } // 0x17C
        public int drop_item_evolution_count_5 { get; set; } // 0x180
        public int drop_item_per_5 { get; set; } // 0x184
        public int drop_item_box_5 { get; set; } // 0x188
        public int drop_item_id_6 { get; set; } // 0x18C
        public int drop_item_value_6 { get; set; } // 0x190
        public int drop_item_evolution_count_6 { get; set; } // 0x194
        public int drop_item_per_6 { get; set; } // 0x198
        public int drop_item_box_6 { get; set; } // 0x19C
        public int drop_item_id_7 { get; set; } // 0x1A0
        public int drop_item_value_7 { get; set; } // 0x1A4
        public int drop_item_evolution_count_7 { get; set; } // 0x1A8
        public int drop_item_per_7 { get; set; } // 0x1AC
        public int drop_item_box_7 { get; set; } // 0x1B0
        public int drop_item_id_8 { get; set; } // 0x1B4
        public int drop_item_value_8 { get; set; } // 0x1B8
        public int drop_item_evolution_count_8 { get; set; } // 0x1BC
        public int drop_item_per_8 { get; set; } // 0x1C0
        public int drop_item_box_8 { get; set; } // 0x1C4
        public int drop_item_id_9 { get; set; } // 0x1C8
        public int drop_item_value_9 { get; set; } // 0x1CC
        public int drop_item_evolution_count_9 { get; set; } // 0x1D0
        public int drop_item_per_9 { get; set; } // 0x1D4
        public int drop_item_box_9 { get; set; } // 0x1D8
        public int drop_item_id_10 { get; set; } // 0x1DC
        public int drop_item_value_10 { get; set; } // 0x1E0
        public int drop_item_evolution_count_10 { get; set; } // 0x1E4
        public int drop_item_per_10 { get; set; } // 0x1E8
        public int drop_item_box_10 { get; set; } // 0x1EC
        public int drop_item_id_11 { get; set; } // 0x1F0
        public int drop_item_value_11 { get; set; } // 0x1F4
        public int drop_item_evolution_count_11 { get; set; } // 0x1F8
        public int drop_item_per_11 { get; set; } // 0x1FC
        public int drop_item_box_11 { get; set; } // 0x200
        public int drop_item_id_12 { get; set; } // 0x204
        public int drop_item_value_12 { get; set; } // 0x208
        public int drop_item_evolution_count_12 { get; set; } // 0x20C
        public int drop_item_per_12 { get; set; } // 0x210
        public int drop_item_box_12 { get; set; } // 0x214
        public int monster_count { get; set; } // 0x218
        public int monster_level { get; set; } // 0x21C
        public int monster_atk_inc_per { get; set; } // 0x220
        public int monster_def_inc_per { get; set; } // 0x224
        public int monster_hp_inc_per { get; set; } // 0x228
        public int monster_id_1 { get; set; } // 0x22C
        public int monster_id_2 { get; set; } // 0x230
        public int monster_id_3 { get; set; } // 0x234
        public int monster_id_4 { get; set; } // 0x238
        public int monster_id_5 { get; set; } // 0x23C
        public int monster_id_6 { get; set; } // 0x240
        public int monster_id_7 { get; set; } // 0x244
        public int monster_id_8 { get; set; } // 0x248
        public int monster_material_box_1 { get; set; } // 0x24C
        public int is_turn_pivot { get; set; } // 0x250
        public string stage_placement { get; set; } // 0x258
        public int stage_hero_entry_all { get; set; } // 0x260
        public int monster_ai_id { get; set; } // 0x264
        public int boss_atk_inc_per { get; set; } // 0x268
        public int boss_def_inc_per { get; set; } // 0x26C
        public int boss_hp_inc_per { get; set; } // 0x270
        public int boss_id_1 { get; set; } // 0x274
        public int boss_material_box_1 { get; set; } // 0x278
        public int boss_level_1 { get; set; } // 0x27C
        public List<int> list_array_passive1 = new List<int>(); // 0x280
        public int boss_id_2 { get; set; } // 0x288
        public int boss_material_box_2 { get; set; } // 0x28C
        public int boss_level_2 { get; set; } // 0x290
        public List<int> list_array_passive2 = new List<int>(); // 0x298
        public int boss_id_3 { get; set; } // 0x2A0
        public int boss_material_box_3 { get; set; } // 0x2A4
        public int boss_level_3 { get; set; } // 0x2A8
        public List<int> list_array_passive3 = new List<int>(); // 0x2B0
        public int boss_id_4 { get; set; } // 0x2B8
        public int boss_material_box_4 { get; set; } // 0x2BC
        public int boss_level_4 { get; set; } // 0x2C0
        public List<int> list_array_passive4 = new List<int>(); // 0x2C8
        public int play_boss_spawn { get; set; } // 0x2D0
        public string boss_entry_type { get; set; } // 0x2D8
        public List<int> list_array_ally_passive_id = new List<int>(); // 0x2E0
        public int team_power { get; set; } // 0x2E8
        public string map_filename { get; set; } // 0x2F0
        public string spawn_prop_filename { get; set; } // 0x2F8
        public string change_map_filename { get; set; } // 0x300
        public int bgm_sound_id { get; set; } // 0x308
        public int boss_sound_id { get; set; } // 0x30C
        public string EssenCondition_1 { get; set; } // 0x310
        public int EssenConditionValue_1 { get; set; } // 0x318
        public string EssenCondition_2 { get; set; } // 0x320
        public int EssenConditionValue_2 { get; set; } // 0x328
        public string EssenCondition_3 { get; set; } // 0x330
        public int EssenConditionValue_3 { get; set; } // 0x338
        public string EssenCondition_4 { get; set; } // 0x340
        public int EssenConditionValue_4 { get; set; } // 0x348
        public string BanCondition_1 { get; set; } // 0x350
        public int BanConditionValue_1 { get; set; } // 0x358
        public string BanCondition_2 { get; set; } // 0x360
        public int BanConditionValue_2 { get; set; } // 0x368
        public string BanCondition_3 { get; set; } // 0x370
        public int BanConditionValue_3 { get; set; } // 0x378
        public string BanCondition_4 { get; set; } // 0x380
        public int BanConditionValue_4 { get; set; } // 0x388
        public string BanCondition_5 { get; set; } // 0x390
        public int BanConditionValue_5 { get; set; } // 0x398
        public string BanCondition_6 { get; set; } // 0x3A0
        public int BanConditionValue_6 { get; set; } // 0x3A8
        public List<int> list_story_id = new List<int>(); // 0x3B0
        public List<int> list_reward_id = new List<int>(); // 0x3B8
        public List<int> list_reward_value = new List<int>(); // 0x3C0
        public List<int> list_reward_value_box = new List<int>(); // 0x3C8
        public List<int> list_drop_item_id = new List<int>(); // 0x3D0
        public List<int> list_drop_item_value = new List<int>(); // 0x3D8
        public List<int> list_drop_item_evolution_count = new List<int>(); // 0x3E0
        public List<int> list_drop_item_per = new List<int>(); // 0x3E8
        public List<int> list_drop_item_box = new List<int>(); // 0x3F0
        public List<int> list_monster_id = new List<int>(); // 0x3F8
        public List<int> list_monster_material_box = new List<int>(); // 0x400
        public List<int> list_boss_id = new List<int>(); // 0x408
        public List<int> list_boss_material_box = new List<int>(); // 0x410
        public List<int> list_boss_level = new List<int>(); // 0x418
        public List<string> list_EssenCondition = new List<string>(); // 0x420
        public List<int> list_EssenConditionValue = new List<int>(); // 0x428
        public List<string> list_BanCondition = new List<string>(); // 0x430
        public List<int> list_BanConditionValue = new List<int>(); // 0x438
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            stage_type = reader.ReadString();
            type = reader.ReadString();
            group = reader.ReadInt32();
            type_local = reader.ReadString();
            stage_string = reader.ReadString();
            control_type = reader.ReadString();
            region = reader.ReadInt32();
            log_region = reader.ReadInt32();
            limit_index = reader.ReadInt32();
            log_index = reader.ReadInt32();
            weekly_index = reader.ReadInt32();
            area = reader.ReadInt32();
            need_quest_id = reader.ReadInt32();
            need_stage_id = reader.ReadInt32();
            next_stage_id = reader.ReadInt32();
            difficulty = reader.ReadInt32();
            difficulty_string = reader.ReadString();
            start_cut = reader.ReadInt32();
            end_cut = reader.ReadInt32();
            story_id_1 = reader.ReadInt32();
            story_id_2 = reader.ReadInt32();
            story_id_3 = reader.ReadInt32();
            need_stamina_item_id = reader.ReadInt32();
            need_stamina_count = reader.ReadInt32();
            play_reward_gauge_point = reader.ReadInt32();
            need_key_item_id = reader.ReadInt32();
            need_key_count = reader.ReadInt32();
            user_exp = reader.ReadInt32();
            hero_exp = reader.ReadInt32();
            gold_value = reader.ReadInt32();
            first_reward_id = reader.ReadInt32();
            first_reward_value = reader.ReadInt32();
            reward_id_1 = reader.ReadInt32();
            reward_value_1 = reader.ReadInt32();
            reward_value_box_1 = reader.ReadInt32();
            reward_id_2 = reader.ReadInt32();
            reward_value_2 = reader.ReadInt32();
            reward_value_box_2 = reader.ReadInt32();
            reward_id_3 = reader.ReadInt32();
            reward_value_3 = reader.ReadInt32();
            reward_value_box_3 = reader.ReadInt32();
            reward_id_4 = reader.ReadInt32();
            reward_value_4= reader.ReadInt32();
            reward_value_box_4= reader.ReadInt32();
            reward_id_5 = reader.ReadInt32();
            reward_value_5= reader.ReadInt32();
            reward_value_box_5= reader.ReadInt32();
            reward_id_6 = reader.ReadInt32();
            reward_value_6= reader.ReadInt32();
            reward_value_box_6= reader.ReadInt32();
            reward_id_7 = reader.ReadInt32();
            reward_value_7= reader.ReadInt32();
            reward_value_box_7= reader.ReadInt32();
            reward_id_8 = reader.ReadInt32();
            reward_value_8= reader.ReadInt32();
            reward_value_box_8= reader.ReadInt32();
            drop_item_normal_min_count = reader.ReadInt32();
            drop_item_normal_max_count = reader.ReadInt32();
            drop_item_boss_min_count = reader.ReadInt32();
            drop_item_boss_max_count = reader.ReadInt32();
            monster_material_per = reader.ReadInt32();
            drop_item_id_1 = reader.ReadInt32();
            drop_item_value_1 = reader.ReadInt32();
            drop_item_evolution_count_1 = reader.ReadInt32();
            drop_item_per_1 = reader.ReadInt32();
            drop_item_box_1 = reader.ReadInt32();
            drop_item_id_2 = reader.ReadInt32();
            drop_item_value_2 = reader.ReadInt32();
            drop_item_evolution_count_2 = reader.ReadInt32();
            drop_item_per_2 = reader.ReadInt32();
            drop_item_box_2 = reader.ReadInt32();
            drop_item_id_3 = reader.ReadInt32();
            drop_item_value_3 = reader.ReadInt32();
            drop_item_evolution_count_3 = reader.ReadInt32();
            drop_item_per_3 = reader.ReadInt32();
            drop_item_box_3 = reader.ReadInt32();
            drop_item_id_4 = reader.ReadInt32();
            drop_item_value_4 = reader.ReadInt32();
            drop_item_evolution_count_4 = reader.ReadInt32();
            drop_item_per_4 = reader.ReadInt32();
            drop_item_box_4 = reader.ReadInt32();
            drop_item_id_5 = reader.ReadInt32();
            drop_item_value_5 = reader.ReadInt32();
            drop_item_evolution_count_5 = reader.ReadInt32();
            drop_item_per_5 = reader.ReadInt32();
            drop_item_box_5 = reader.ReadInt32();
            drop_item_id_6 = reader.ReadInt32();
            drop_item_value_6 = reader.ReadInt32();
            drop_item_evolution_count_6 = reader.ReadInt32();
            drop_item_per_6 = reader.ReadInt32();
            drop_item_box_6 = reader.ReadInt32();
            drop_item_id_7 = reader.ReadInt32();
            drop_item_value_7 = reader.ReadInt32();
            drop_item_evolution_count_7 = reader.ReadInt32();
            drop_item_per_7 = reader.ReadInt32();
            drop_item_box_7 = reader.ReadInt32();
            drop_item_id_8 = reader.ReadInt32();
            drop_item_value_8 = reader.ReadInt32();
            drop_item_evolution_count_8 = reader.ReadInt32();
            drop_item_per_8 = reader.ReadInt32();
            drop_item_box_8 = reader.ReadInt32();
            drop_item_id_9 = reader.ReadInt32();
            drop_item_value_9 = reader.ReadInt32();
            drop_item_evolution_count_9 = reader.ReadInt32();
            drop_item_per_9 = reader.ReadInt32();
            drop_item_box_9 = reader.ReadInt32();
            drop_item_id_10 = reader.ReadInt32();
            drop_item_value_10 = reader.ReadInt32();
            drop_item_evolution_count_10 = reader.ReadInt32();
            drop_item_per_10 = reader.ReadInt32();
            drop_item_box_10 = reader.ReadInt32();
            drop_item_id_11 = reader.ReadInt32();
            drop_item_value_11 = reader.ReadInt32();
            drop_item_evolution_count_11 = reader.ReadInt32();
            drop_item_per_11 = reader.ReadInt32();
            drop_item_box_11 = reader.ReadInt32();
            drop_item_id_12 = reader.ReadInt32();
            drop_item_value_12 = reader.ReadInt32();
            drop_item_evolution_count_12 = reader.ReadInt32();
            drop_item_per_12 = reader.ReadInt32();
            drop_item_box_12 = reader.ReadInt32();
            monster_count = reader.ReadInt32();
            monster_level = reader.ReadInt32();
            monster_atk_inc_per = reader.ReadInt32();
            monster_def_inc_per = reader.ReadInt32();
            monster_hp_inc_per = reader.ReadInt32();
            monster_id_1 = reader.ReadInt32();
            monster_id_2 = reader.ReadInt32();
            monster_id_3 = reader.ReadInt32();
            monster_id_4 = reader.ReadInt32();
            monster_id_5 = reader.ReadInt32();
            monster_id_6 = reader.ReadInt32();
            monster_id_7 = reader.ReadInt32();
            monster_id_8 = reader.ReadInt32();
            monster_material_box_1 = reader.ReadInt32();
            is_turn_pivot = reader.ReadInt32();
            stage_placement = reader.ReadString();
            stage_hero_entry_all = reader.ReadInt32();
            monster_ai_id = reader.ReadInt32();
            boss_atk_inc_per = reader.ReadInt32();
            boss_def_inc_per = reader.ReadInt32();
            boss_hp_inc_per = reader.ReadInt32();
            boss_id_1 = reader.ReadInt32();
            boss_material_box_1 = reader.ReadInt32();
            boss_level_1 = reader.ReadInt32();
            //array_passive1 = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v0--;
            }
            boss_id_2 = reader.ReadInt32();
            boss_material_box_2 = reader.ReadInt32();
            boss_level_2 = reader.ReadInt32();
            //array_passive2 = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v1--;
            }
            boss_id_3 = reader.ReadInt32();
            boss_material_box_3 = reader.ReadInt32();
            boss_level_3 = reader.ReadInt32();
            //array_passive3 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v2--;
            }
            boss_id_4 = reader.ReadInt32();
            boss_material_box_4 = reader.ReadInt32();
            boss_level_4 = reader.ReadInt32();
            //array_passive4 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_passive4.Add(reader.ReadInt32());
                v3--;
            }
            play_boss_spawn = reader.ReadInt32();
            boss_entry_type = reader.ReadString();
            //array_ally_passive_id = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_ally_passive_id.Add(reader.ReadInt32());
                v4--;
            }
            team_power = reader.ReadInt32();
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = reader.ReadInt32();
            boss_sound_id = reader.ReadInt32();
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = reader.ReadInt32();
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = reader.ReadInt32();
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = reader.ReadInt32();
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = reader.ReadInt32();
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = reader.ReadInt32();
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = reader.ReadInt32();
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = reader.ReadInt32();
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = reader.ReadInt32();
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = reader.ReadInt32();
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageWeekRewardRow
    {
        public int id { get; set; } // 0x10
        public string stage_type { get; set; } // 0x18
        public int group { get; set; } // 0x20
        public int need_exp { get; set; } // 0x24
        public int item_id_1 { get; set; } // 0x28
        public int item_count_1 { get; set; } // 0x2C
        public List<int> list_item_id = new List<int>(); // 0x30
        public List<int> list_item_count = new List<int>(); // 0x38
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            stage_type = reader.ReadString();
            group = reader.ReadInt32();
            need_exp = reader.ReadInt32();
            item_id_1 = reader.ReadInt32();
            item_count_1 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStageWeekSetupRow
    {
        public int id { get; set; } // 0x10
        public string week_setup { get; set; } // 0x18
        public int materialstage_1 { get; set; } // 0x20
        public int materialstage_2 { get; set; } // 0x24
        public int materialstage_3 { get; set; } // 0x28
        public int materialstage_4 { get; set; } // 0x2C
        public int materialstage_5 { get; set; } // 0x30
        public int materialstage_6 { get; set; } // 0x34
        public int materialstage_7 { get; set; } // 0x38
        public int materialstage_8 { get; set; } // 0x3C
        public int materialstage_9 { get; set; } // 0x40
        public int open_time_1 { get; set; } // 0x44
        public int close_time_1 { get; set; } // 0x48
        public int open_time_2 { get; set; } // 0x4C
        public int close_time_2 { get; set; } // 0x50
        public int open_time_3 { get; set; } // 0x54
        public int close_time_3 { get; set; } // 0x58
        public List<int> list_materialstage = new List<int>(); // 0x60
        public List<int> list_open_time = new List<int>(); // 0x68
        public List<int> list_close_time = new List<int>(); // 0x70
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            week_setup = reader.ReadString();
            materialstage_1 = reader.ReadInt32();
            materialstage_2 = reader.ReadInt32();
            materialstage_3 = reader.ReadInt32();
            materialstage_4 = reader.ReadInt32();
            materialstage_5 = reader.ReadInt32();
            materialstage_6 = reader.ReadInt32();
            materialstage_7 = reader.ReadInt32();
            materialstage_8 = reader.ReadInt32();
            materialstage_9 = reader.ReadInt32();
            open_time_1 = reader.ReadInt32();
            close_time_1 = reader.ReadInt32();
            open_time_2 = reader.ReadInt32();
            close_time_2 = reader.ReadInt32();
            open_time_3 = reader.ReadInt32();
            close_time_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBStampChatRow
    {
        public int id { get; set; } // 0x10
        public string stamp_item { get; set; } // 0x18
        public int stamp_group_item_id { get; set; } // 0x20
        public string stamp_type_name { get; set; } // 0x28
        public int stamp_type { get; set; } // 0x30
        public int stamp_group { get; set; } // 0x34
        public string stamp_name { get; set; } // 0x38
        public string Stamp_desc { get; set; } // 0x40
        public string stamp_keyword { get; set; } // 0x48
        public int stamp_category { get; set; } // 0x50
        public int stamp_sound { get; set; } // 0x54
        public string stamp_mind_type { get; set; } // 0x58
        public string get_stamp_desc { get; set; } // 0x60
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            stamp_item = reader.ReadString();
            stamp_group_item_id = reader.ReadInt32();
            stamp_type_name = reader.ReadString();
            stamp_type = reader.ReadInt32();
            stamp_group = reader.ReadInt32();
            stamp_name = reader.ReadString();
            Stamp_desc = reader.ReadString();
            stamp_keyword = reader.ReadString();
            stamp_category = reader.ReadInt32();
            stamp_sound = reader.ReadInt32();
            stamp_mind_type = reader.ReadString();
            get_stamp_desc = reader.ReadString();
            return true;
        }
    }
    public class DBStepupGambleInfoRow
    {
        public int group_id { get; set; } // 0x10
        public string array_stepup_skin_id { get; set; } // 0x18
        public List<int> list_array_stepup_skin_id = new List<int>(); // 0x20
        public int stepup_background { get; set; } // 0x28
        public string stepup_BG_name { get; set; } // 0x30
        public string stepup_m_banner_name { get; set; } // 0x38
        public int stepup_reset { get; set; } // 0x40
        public int mileage_group { get; set; } // 0x44
        public int mileage_reset { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            group_id = reader.ReadInt32();
            //array_stepup_skin_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_stepup_skin_id.Add(reader.ReadInt32());
                v0--;
            }
            stepup_background = reader.ReadInt32();
            stepup_BG_name = reader.ReadString();
            stepup_m_banner_name = reader.ReadString();
            stepup_reset = reader.ReadInt32();
            mileage_group = reader.ReadInt32();
            mileage_reset = reader.ReadInt32();
            return true;
        }
    }
    public class DBStepupMileageRow
    {
        public int id { get; set; } // 0x10
        public int mileage_group { get; set; } // 0x14
        public int reward_order { get; set; } // 0x18
        public int stepup_mileage_value { get; set; } // 0x1C
        public int reward_item_id { get; set; } // 0x20
        public int reward_item_count { get; set; } // 0x24
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            mileage_group = reader.ReadInt32();
            reward_order = reader.ReadInt32();
            stepup_mileage_value = reader.ReadInt32();
            reward_item_id = reader.ReadInt32();
            reward_item_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBStepupSetRow
    {
        public int id { get; set; } // 0x10
        public int group_id { get; set; } // 0x14
        public int step { get; set; } // 0x18
        public int step_gamble_group { get; set; } // 0x1C
        public int step_limit_count { get; set; } // 0x20
        public int step_gamble_count { get; set; } // 0x24
        public int step_gamble_ticket_id { get; set; } // 0x28
        public int step_gamble_ticket_count_display { get; set; } // 0x2C
        public int step_gamble_ticket_count_real { get; set; } // 0x30
        public int step_gamble_money_id { get; set; } // 0x34
        public int step_gamble_money_count_display { get; set; } // 0x38
        public int step_gamble_money_count_real { get; set; } // 0x3C
        public int reward_grade_confirm { get; set; } // 0x40
        public int reward_grade_increase { get; set; } // 0x44
        public int reward_grade_count { get; set; } // 0x48
        public int bonus_reward_id_1 { get; set; } // 0x4C
        public int bonus_reward_count_1 { get; set; } // 0x50
        public int bonus_reward_id_2 { get; set; } // 0x54
        public int bonus_reward_count_2 { get; set; } // 0x58
        public int bonus_reward_id_3 { get; set; } // 0x5C
        public int bonus_reward_count_3 { get; set; } // 0x60
        public int reward_mileage_value { get; set; } // 0x64
        public string stepup_add_event_icon_name { get; set; } // 0x68
        public string stepup_add_event_name { get; set; } // 0x70
        public string step_desc { get; set; } // 0x78
        public List<int> list_bonus_reward_id = new List<int>(); // 0x80
        public List<int> list_bonus_reward_count = new List<int>(); // 0x88
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            group_id = reader.ReadInt32();
            step = reader.ReadInt32();
            step_gamble_group = reader.ReadInt32();
            step_limit_count = reader.ReadInt32();
            step_gamble_count = reader.ReadInt32();
            step_gamble_ticket_id = reader.ReadInt32();
            step_gamble_ticket_count_display = reader.ReadInt32();
            step_gamble_ticket_count_real = reader.ReadInt32();
            step_gamble_money_id = reader.ReadInt32();
            step_gamble_money_count_display = reader.ReadInt32();
            step_gamble_money_count_real = reader.ReadInt32();
            reward_grade_confirm = reader.ReadInt32();
            reward_grade_increase = reader.ReadInt32();
            reward_grade_count = reader.ReadInt32();
            bonus_reward_id_1 = reader.ReadInt32();
            bonus_reward_count_1 = reader.ReadInt32();
            bonus_reward_id_2 = reader.ReadInt32();
            bonus_reward_count_2 = reader.ReadInt32();
            bonus_reward_id_3 = reader.ReadInt32();
            bonus_reward_count_3 = reader.ReadInt32();
            reward_mileage_value = reader.ReadInt32();
            stepup_add_event_icon_name = reader.ReadString();
            stepup_add_event_name = reader.ReadString();
            step_desc = reader.ReadString();
            return true;
        }
    }
    public class DBStoryRetryRow
    {
        public int id { get; set; } // 0x10
        public string matcing_db_name { get; set; } // 0x18
        public int matcing_id_1 { get; set; } // 0x20
        public int check_version { get; set; } // 0x24
        public int retry_on { get; set; } // 0x28
        public List<int> list_matcing_id = new List<int>(); // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            matcing_db_name = reader.ReadString();
            matcing_id_1 = reader.ReadInt32();
            check_version = reader.ReadInt32();
            retry_on = reader.ReadInt32();
            return true;
        }
    }
    public class DBStoryreviewAreaRow
    {
        public int id { get; set; } // 0x10
        public int target_type { get; set; } // 0x14
        public int target_region { get; set; } // 0x18
        public int target_region_ep { get; set; } // 0x1C
        public int target_area_id { get; set; } // 0x20
        public string target_area_icon { get; set; } // 0x28
        public string target_area_name { get; set; } // 0x30
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            target_type = reader.ReadInt32();
            target_region = reader.ReadInt32();
            target_region_ep = reader.ReadInt32();
            target_area_id = reader.ReadInt32();
            target_area_icon = reader.ReadString();
            target_area_name = reader.ReadString();
            return true;
        }
    }
    public class DBStoryreviewListRow
    {
        public int id { get; set; } // 0x10
        public int root_id { get; set; } // 0x14
        public int story_lowslot { get; set; } // 0x18
        public string story_lowslot_name { get; set; } // 0x20
        public int story_connecting { get; set; } // 0x28
        public int formattype { get; set; } // 0x2C
        public string opentype { get; set; } // 0x30
        public int openvalue { get; set; } // 0x38
        public int target_id { get; set; } // 0x3C
        public string replay_summary { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            root_id = reader.ReadInt32();
            story_lowslot = reader.ReadInt32();
            story_lowslot_name = reader.ReadString();
            story_connecting = reader.ReadInt32();
            formattype = reader.ReadInt32();
            opentype = reader.ReadString();
            openvalue = reader.ReadInt32();
            target_id = reader.ReadInt32();
            replay_summary = reader.ReadString();
            return true;
        }
    }
    public class DBStoryreviewRootRow
    {
        public int id { get; set; } // 0x10
        public int show_list { get; set; } // 0x14
        public int story_type { get; set; } // 0x18
        public int story_region { get; set; } // 0x1C
        public int story_region_ep { get; set; } // 0x20
        public int story_group { get; set; } // 0x24
        public string story_chapter_name { get; set; } // 0x28
        public string story_group_name { get; set; } // 0x30
        public string replay_Image { get; set; } // 0x38
        public string replay_list_summary { get; set; } // 0x40
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            show_list = reader.ReadInt32();
            story_type = reader.ReadInt32();
            story_region = reader.ReadInt32();
            story_region_ep = reader.ReadInt32();
            story_group = reader.ReadInt32();
            story_chapter_name = reader.ReadString();
            story_group_name = reader.ReadString();
            replay_Image = reader.ReadString();
            replay_list_summary = reader.ReadString();
            return true;
        }
    }
    public class DBStoryreviewStageRow
    {
        public int id { get; set; } // 0x10
        public int root_id { get; set; } // 0x14
        public string root_name { get; set; } // 0x18
        public string array_main_stage_id { get; set; } // 0x20
        public List<int> list_array_main_stage_id = new List<int>(); // 0x28
        public string array_quest_stage_id { get; set; } // 0x30
        public List<int> list_array_quest_stage_id = new List<int>(); // 0x38
        public string array_limited_stage_id { get; set; } // 0x40
        public List<int> list_array_limited_stage_id = new List<int>(); // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            root_id = reader.ReadInt32();
            root_name = reader.ReadString();
            //array_main_stage_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_main_stage_id.Add(reader.ReadInt32());
                v0--;
            }
            //array_quest_stage_id = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_quest_stage_id.Add(reader.ReadInt32());
                v1--;
            }
            //array_limited_stage_id = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_limited_stage_id.Add(reader.ReadInt32());
                v2--;
            }
            return true;
        }
    }
    public class DBTownChangeRow
    {
        public int id { get; set; } // 0x10
        public int town_id { get; set; } // 0x14
        public string path { get; set; } // 0x18
        public string map_resource { get; set; } // 0x20
        public string open_type { get; set; } // 0x28
        public int open_value { get; set; } // 0x30
        public string town_name { get; set; } // 0x38
        public string town_icon { get; set; } // 0x40
        public string town_minimap_change { get; set; } // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            town_id = reader.ReadInt32();
            path = reader.ReadString();
            map_resource = reader.ReadString();
            open_type = reader.ReadString();
            open_value = reader.ReadInt32();
            town_name = reader.ReadString();
            town_icon = reader.ReadString();
            town_minimap_change = reader.ReadString();
            return true;
        }
    }
    public class DBTutorialRewardRow
    {
        public int id { get; set; } // 0x10
        public string tutorial_name { get; set; } // 0x18
        public int tutorial_group { get; set; } // 0x20
        public int start_prefab_id { get; set; } // 0x24
        public int link_quest { get; set; } // 0x28
        public int select_hero_id { get; set; } // 0x2C
        public int force_start_id { get; set; } // 0x30
        public int tutorial_resource_id_1 { get; set; } // 0x34
        public int tutorial_resource_count_1 { get; set; } // 0x38
        public int tutorial_resource_id_2 { get; set; } // 0x3C
        public int tutorial_resource_count_2 { get; set; } // 0x40
        public int tutorial_resource_id_3 { get; set; } // 0x44
        public int tutorial_resource_count_3 { get; set; } // 0x48
        public int tutorial_reward_id_1 { get; set; } // 0x4C
        public int tutorial_reward_count_1 { get; set; } // 0x50
        public List<int> list_tutorial_resource_id = new List<int>(); // 0x58
        public List<int> list_tutorial_resource_count = new List<int>(); // 0x60
        public List<int> list_tutorial_reward_id = new List<int>(); // 0x68
        public List<int> list_tutorial_reward_count = new List<int>(); // 0x70
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            tutorial_name = reader.ReadString();
            tutorial_group = reader.ReadInt32();
            start_prefab_id = reader.ReadInt32();
            link_quest = reader.ReadInt32();
            select_hero_id = reader.ReadInt32();
            force_start_id = reader.ReadInt32();
            tutorial_resource_id_1 = reader.ReadInt32();
            tutorial_resource_count_1 = reader.ReadInt32();
            tutorial_resource_id_2 = reader.ReadInt32();
            tutorial_resource_count_2 = reader.ReadInt32();
            tutorial_resource_id_3 = reader.ReadInt32();
            tutorial_resource_count_3 = reader.ReadInt32();
            tutorial_reward_id_1 = reader.ReadInt32();
            tutorial_reward_count_1 = reader.ReadInt32();
            return true;
        }
    }
    public class DBVideoRow
    {
        public int id { get; set; } // 0x10
        public string sub_path { get; set; } // 0x18
        public string name { get; set; } // 0x20
        public string screen { get; set; } // 0x28
        public string end_Prefab { get; set; } // 0x30
        public string start_title { get; set; } // 0x38
        public string start_content { get; set; } // 0x40
        public string end_title { get; set; } // 0x48
        public string end_content { get; set; } // 0x50
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            sub_path = reader.ReadString();
            name = reader.ReadString();
            screen = reader.ReadString();
            end_Prefab = reader.ReadString();
            start_title = reader.ReadString();
            start_content = reader.ReadString();
            end_title = reader.ReadString();
            end_content = reader.ReadString();
            return true;
        }
    }
    public class DBVoiceRow
    {
        public int id { get; set; } // 0x10
        public int hero_id { get; set; } // 0x14
        public int fellowship_level { get; set; } // 0x18
        public int sound_id { get; set; } // 0x1C
        public string sound_name { get; set; } // 0x20
        public string sound_description { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            hero_id = reader.ReadInt32();
            fellowship_level = reader.ReadInt32();
            sound_id = reader.ReadInt32();
            sound_name = reader.ReadString();
            sound_description = reader.ReadString();
            return true;
        }
    }
    public class DBWeaponAutoSettingRow
    {
        public int set_auto_id { get; set; } // 0x10
        public string array_set_auto_priority { get; set; } // 0x18
        public List<int> list_array_set_auto_priority = new List<int>(); // 0x20
        public bool ReadToStream(BinaryReader reader)
        {
            set_auto_id = reader.ReadInt32();
            //array_set_auto_priority = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_set_auto_priority.Add(reader.ReadInt32());
                v0--;
            }
            return true;
        }
    }
    public class DBWeaponCarveBaseRow
    {
        public int id { get; set; } // 0x10
        public int weapon_rating { get; set; } // 0x14
        public int weapon_parts { get; set; } // 0x18
        public int carve_item_id_1 { get; set; } // 0x1C
        public int carve_item_count_1 { get; set; } // 0x20
        public int carve_item_id_2 { get; set; } // 0x24
        public int carve_item_count_2 { get; set; } // 0x28
        public int carve_price_id { get; set; } // 0x2C
        public int carve_price_count { get; set; } // 0x30
        public int carve_clear_price_id { get; set; } // 0x34
        public int carve_clear_price_count { get; set; } // 0x38
        public List<int> list_carve_item_id = new List<int>(); // 0x40
        public List<int> list_carve_item_count = new List<int>(); // 0x48
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            weapon_rating = reader.ReadInt32();
            weapon_parts = reader.ReadInt32();
            carve_item_id_1 = reader.ReadInt32();
            carve_item_count_1 = reader.ReadInt32();
            carve_item_id_2 = reader.ReadInt32();
            carve_item_count_2 = reader.ReadInt32();
            carve_price_id = reader.ReadInt32();
            carve_price_count = reader.ReadInt32();
            carve_clear_price_id = reader.ReadInt32();
            carve_clear_price_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBWeaponCostumeResourceRow
    {
        public int id { get; set; } // 0x10
        public string character_base { get; set; } // 0x18
        public string resource_weapon { get; set; } // 0x20
        public int weapon_model_type { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            character_base = reader.ReadString();
            resource_weapon = reader.ReadString();
            weapon_model_type = reader.ReadInt32();
            return true;
        }
    }
    public class DBWeaponEventSetRow
    {
        public int event_set_id { get; set; } // 0x10
        public int display_id { get; set; } // 0x14
        public string event_set_icon { get; set; } // 0x18
        public string event_set_name { get; set; } // 0x20
        public string event_set_desc { get; set; } // 0x28
        public int set_count { get; set; } // 0x30
        public int set_passive_id { get; set; } // 0x34
        public bool ReadToStream(BinaryReader reader)
        {
            event_set_id = reader.ReadInt32();
            display_id = reader.ReadInt32();
            event_set_icon = reader.ReadString();
            event_set_name = reader.ReadString();
            event_set_desc = reader.ReadString();
            set_count = reader.ReadInt32();
            set_passive_id = reader.ReadInt32();
            return true;
        }
    }
    public class DBWeaponEvolutionRow
    {
        public int id { get; set; } // 0x10
        public int weapon_rating { get; set; } // 0x14
        public int evolution_count { get; set; } // 0x18
        public int evolution_material_id { get; set; } // 0x1C
        public int evolution_material_count { get; set; } // 0x20
        public int evolution_price_id { get; set; } // 0x24
        public int evolution_price_count { get; set; } // 0x28
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            weapon_rating = reader.ReadInt32();
            evolution_count = reader.ReadInt32();
            evolution_material_id = reader.ReadInt32();
            evolution_material_count = reader.ReadInt32();
            evolution_price_id = reader.ReadInt32();
            evolution_price_count = reader.ReadInt32();
            return true;
        }
    }
    public class DBWeaponOptionChangeRow
    {
        public int id { get; set; } // 0x10
        public string change_type { get; set; } // 0x18
        public int weapon_rating { get; set; } // 0x20
        public int evolution_count { get; set; } // 0x24
        public int change_material_id { get; set; } // 0x28
        public int change_material_count { get; set; } // 0x2C
        public int change_price_id { get; set; } // 0x30
        public int change_price_count { get; set; } // 0x34
        public int option_change_min_1 { get; set; } // 0x38
        public int option_rate_1 { get; set; } // 0x3C
        public int option_change_min_2 { get; set; } // 0x40
        public int option_rate_2 { get; set; } // 0x44
        public int option_change_min_3 { get; set; } // 0x48
        public int option_rate_3 { get; set; } // 0x4C
        public List<int> list_option_change_min = new List<int>(); // 0x50
        public List<int> list_option_rate = new List<int>(); // 0x58
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            change_type = reader.ReadString();
            weapon_rating = reader.ReadInt32();
            evolution_count = reader.ReadInt32();
            change_material_id = reader.ReadInt32();
            change_material_count = reader.ReadInt32();
            change_price_id = reader.ReadInt32();
            change_price_count = reader.ReadInt32();
            option_change_min_1 = reader.ReadInt32();
            option_rate_1 = reader.ReadInt32();
            option_change_min_2 = reader.ReadInt32();
            option_rate_2 = reader.ReadInt32();
            option_change_min_3 = reader.ReadInt32();
            option_rate_3 = reader.ReadInt32();
            return true;
        }
    }
    public class DBWelcomeAttendanceRow
    {
        public int id { get; set; } // 0x10
        public int day { get; set; } // 0x14
        public int item_id { get; set; } // 0x18
        public int item_count { get; set; } // 0x1C
        public bool ReadToStream(BinaryReader reader)
        {
            id = reader.ReadInt32();
            day = reader.ReadInt32();
            item_id = reader.ReadInt32();
            item_count = reader.ReadInt32();
            return true;
        }
    }
    public abstract class DataTableCryptographer // TypeDefIndex: 13322
    {
        public int CRPTO_BYTE_COUNT; // 0x0
        protected abstract uint XOROperand { get; }
        public byte DecryptByte(byte[] datas)
        {
            return ToXORByteArray(datas)[0];
        }
        public int DecryptInt32(byte[] datas)
        {
            return BitConverter.ToInt32(ToXORByteArray(datas), 0);
        }
        public long DecryptInt64(byte[] datas) { return BitConverter.ToInt64(ToXORByteArray(datas), 0); }
        public float DecryptFloat(byte[] datas) { return BitConverter.ToSingle(ToXORByteArray(datas), 0); }
        public double DecryptDouble(byte[] datas) { return BitConverter.ToDouble(ToXORByteArray(datas), 0); }
        public string DecryptString(char[] datas) { return ""; }
        private int ToXORInt32(int value) { return 1; }
        private long ToXORInt64(long value) { return 1; }
        //private char[] ToXORCharArray(string value) { return new char[](); }
        private string ToXORString(char[] arrayCharValue) { return ""; }
        public byte[] ToXORByteArray(byte[] arrayValue)
        {
            byte[] toCrypt = arrayValue;
            for (int i = 0; i < toCrypt.Length; i++)
            {
                toCrypt[i] = (byte)(toCrypt[i] ^ XOROperand);
            }
            return toCrypt;
        }
        public DataTableCryptographer() { }
    }
    public class DBConfigGameRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public string contents { get; set; } // 0x18
        public string value_string_1 { get; set; } // 0x20
        public string value_string_2 { get; set; } // 0x28
        public int value_int_1 { get; set; } // 0x30
        public int value_int_2 { get; set; } // 0x38
        public float value_float_1 { get; set; } // 0x40
        public float value_float_2 { get; set; } // 0x48
        public List<string> list_value_string = new List<string>(); // 0x50
        public List<int> list_value_int = new List<int>(); // 0x58
        public List<float> list_value_float = new List<float>(); // 0x60
        protected override uint XOROperand { get { return 0x33B; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            contents = reader.ReadString();
            value_string_1 = reader.ReadString();
            value_string_2 = reader.ReadString();
            value_int_1 = DecryptInt32(reader.ReadBytes(4));
            value_int_2 = DecryptInt32(reader.ReadBytes(4));
            value_float_1 = DecryptFloat(reader.ReadBytes(4));
            value_float_2 = DecryptFloat(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBConfigMoneyRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public int money_id { get; set; } // 0x18
        public string money_icon { get; set; } // 0x20
        public string money_name { get; set; } // 0x28
        public string money_desc { get; set; } // 0x30
        public float value_1 { get; set; } // 0x38
        public float value_2 { get; set; } // 0x40
        public List<float> list_value = new List<float>(); // 0x48
        protected override uint XOROperand { get { return 0x2D6; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            money_id = DecryptInt32(reader.ReadBytes(4));
            money_icon = reader.ReadString();
            money_name = reader.ReadString();
            money_desc = reader.ReadString();
            value_1 = DecryptFloat(reader.ReadBytes(4));
            value_2 = DecryptFloat(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBExpRow : DataTableCryptographer
    {
        public int level { get; set; } // 0x10
        public int user_exp { get; set; } // 0x18
        public int guild_exp { get; set; } // 0x20
        public int max_stamina { get; set; } // 0x28
        public int max_friend { get; set; } // 0x30
        public string open_content { get; set; } // 0x38
        public int hero_exp { get; set; } // 0x40
        public int rank_exp_1 { get; set; } // 0x48
        public int rank_exp_2 { get; set; } // 0x50
        public int rank_exp_3 { get; set; } // 0x58
        public int guest_hero_rating_exp_1 { get; set; } // 0x60
        public int guest_hero_rating_exp_2 { get; set; } // 0x68
        public int guest_hero_rating_exp_3 { get; set; } // 0x70
        public int guest_hero_rating_exp_4 { get; set; } // 0x78
        public int recipe_exp { get; set; } // 0x80
        public List<int> list_rank_exp = new List<int>(); // 0x88
        public List<int> list_guest_hero_rating_exp = new List<int>(); // 0x90
        protected override uint XOROperand { get { return 0x234; } }
        public bool ReadToStream(BinaryReader reader)
        {
            level = DecryptInt32(reader.ReadBytes(4));
            user_exp = DecryptInt32(reader.ReadBytes(4));
            guild_exp = DecryptInt32(reader.ReadBytes(4));
            max_stamina = DecryptInt32(reader.ReadBytes(4));
            max_friend = DecryptInt32(reader.ReadBytes(4));
            open_content = reader.ReadString();
            hero_exp = DecryptInt32(reader.ReadBytes(4));
            rank_exp_1 = DecryptInt32(reader.ReadBytes(4));
            rank_exp_2 = DecryptInt32(reader.ReadBytes(4));
            rank_exp_3 = DecryptInt32(reader.ReadBytes(4));
            guest_hero_rating_exp_1 = DecryptInt32(reader.ReadBytes(4));
            guest_hero_rating_exp_2 = DecryptInt32(reader.ReadBytes(4));
            guest_hero_rating_exp_3 = DecryptInt32(reader.ReadBytes(4));
            guest_hero_rating_exp_4 = DecryptInt32(reader.ReadBytes(4));
            recipe_exp = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBFateRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public int main_hero_id { get; set; } // 0x18
        public int fate_hero_id { get; set; } // 0x20
        public int r_lv_passive_id { get; set; } // 0x28
        public int sr_lv_passive_id { get; set; } // 0x30
        public int ssr_lv_passive_id { get; set; } // 0x38
        public int ur_lv_passive_id { get; set; } // 0x40
        public int special_coop_card_id_1 { get; set; } // 0x48
        public int special_coop_card_id_2 { get; set; } // 0x50
        public int special_coop_card_id_3 { get; set; } // 0x58
        public int special_coop_card_id_4 { get; set; } // 0x60
        public int special_coop_card_id_5 { get; set; } // 0x68
        public int special_coop_card_id_6 { get; set; } // 0x70
        public string special_coop_ani_folder { get; set; } // 0x78
        public string special_coop_desc { get; set; } // 0x80
        public string fate_name { get; set; } // 0x88
        public string fate_desc { get; set; } // 0x90
        public List<int> list_special_coop_card_id = new List<int>(); // 0x98
        protected override uint XOROperand { get { return 0x27C; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            main_hero_id = DecryptInt32(reader.ReadBytes(4));
            fate_hero_id = DecryptInt32(reader.ReadBytes(4));
            r_lv_passive_id = DecryptInt32(reader.ReadBytes(4));
            sr_lv_passive_id = DecryptInt32(reader.ReadBytes(4));
            ssr_lv_passive_id = DecryptInt32(reader.ReadBytes(4));
            ur_lv_passive_id = DecryptInt32(reader.ReadBytes(4));
            special_coop_card_id_1 = DecryptInt32(reader.ReadBytes(4));
            special_coop_card_id_2 = DecryptInt32(reader.ReadBytes(4));
            special_coop_card_id_3 = DecryptInt32(reader.ReadBytes(4));
            special_coop_card_id_4 = DecryptInt32(reader.ReadBytes(4));
            special_coop_card_id_5 = DecryptInt32(reader.ReadBytes(4));
            special_coop_card_id_6 = DecryptInt32(reader.ReadBytes(4));
            special_coop_ani_folder = reader.ReadString();
            special_coop_desc = reader.ReadString();
            fate_name = reader.ReadString();
            fate_desc = reader.ReadString();
            return true;
        }
    }
    public class DBHeroBaseRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public int hero_list { get; set; } // 0x18
        public int hero_display { get; set; } // 0x20
        public string open_start_date { get; set; } // 0x28
        public int hero_group { get; set; } // 0x30
        public string array_hero_group_check { get; set; } // 0x38
        public List<int> list_array_hero_group_check = new List<int>(); // 0x40
        public int npc_type { get; set; } // 0x48
        public int kind { get; set; } // 0x50
        public int base_skin { get; set; } // 0x58
        public int weapon_idle_start { get; set; } // 0x60
        public string hero_category { get; set; } // 0x68
        public string main_hero_type { get; set; } // 0x70
        public string collaboration_name { get; set; } // 0x78
        public string hero_gender { get; set; } // 0x80
        public int event_mission_gender { get; set; } // 0x88
        public string hero_age { get; set; } // 0x90
        public string hero_birth { get; set; } // 0x98
        public string hero_height { get; set; } // 0xA0
        public string hero_weight { get; set; } // 0xA8
        public string hero_blood { get; set; } // 0xB0
        public string hero_voice { get; set; } // 0xB8
        public int hero_action_1 { get; set; } // 0xC0
        public int hero_action_2 { get; set; } // 0xC8
        public int hero_action_3 { get; set; } // 0xD0
        public int hero_action_4 { get; set; } // 0xD8
        public int hero_action_5 { get; set; } // 0xE0
        public int hero_action_6 { get; set; } // 0xE8
        public string hero_special { get; set; } // 0xF0
        public string hero_coop_main { get; set; } // 0xF8
        public string hero_coop_sub { get; set; } // 0x100
        public string fame_anim { get; set; } // 0x108
        public List<int> list_hero_action = new List<int>(); // 0x110
        protected override uint XOROperand { get { return 0x292; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            hero_list = DecryptInt32(reader.ReadBytes(4));
            hero_display = DecryptInt32(reader.ReadBytes(4));
            open_start_date = reader.ReadString();
            hero_group = DecryptInt32(reader.ReadBytes(4));
            //array_hero_group_check = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_hero_group_check.Add(reader.ReadInt32());
                v0--;
            }
            npc_type = DecryptInt32(reader.ReadBytes(4));
            kind = DecryptInt32(reader.ReadBytes(4));
            base_skin = DecryptInt32(reader.ReadBytes(4));
            weapon_idle_start = DecryptInt32(reader.ReadBytes(4));
            hero_category = reader.ReadString();
            main_hero_type = reader.ReadString();
            collaboration_name = reader.ReadString();
            hero_gender = reader.ReadString();
            event_mission_gender = DecryptInt32(reader.ReadBytes(4));
            hero_age = reader.ReadString();
            hero_birth = reader.ReadString();
            hero_height = reader.ReadString();
            hero_weight = reader.ReadString();
            hero_blood = reader.ReadString();
            hero_voice = reader.ReadString();
            hero_action_1 = DecryptInt32(reader.ReadBytes(4));
            hero_action_2 = DecryptInt32(reader.ReadBytes(4));
            hero_action_3 = DecryptInt32(reader.ReadBytes(4));
            hero_action_4 = DecryptInt32(reader.ReadBytes(4));
            hero_action_5 = DecryptInt32(reader.ReadBytes(4));
            hero_action_6 = DecryptInt32(reader.ReadBytes(4));
            hero_special = reader.ReadString();
            hero_coop_main = reader.ReadString();
            hero_coop_sub = reader.ReadString();
            fame_anim = reader.ReadString();
            return true;
        }
    }
    public class DBMonsterBaseRow : DataTableCryptographer
    {
        public int id { get; set; }// 0x10
        public byte kind { get; set; }// 0x18
        public byte attribute { get; set; }// 0x19
        public byte monster_class { get; set; }// 0x1A
        public byte hp_visible_type { get; set; }// 0x1B
        public string nick { get; set; }// 0x20
        public string name { get; set; }// 0x28
        public float atk { get; set; }// 0x30
        public float fixed_atk_per { get; set; }// 0x38
        public float crit_per { get; set; }// 0x40
        public float crit_atk_per { get; set; }// 0x48
        public float def { get; set; }// 0x50
        public float fixed_def_per { get; set; }// 0x58
        public float crit_res_per { get; set; }// 0x60
        public float crit_def_per { get; set; }// 0x68
        public float hp { get; set; }// 0x70
        public float hp_regen_per { get; set; }// 0x78
        public float hp_recovery_per { get; set; }// 0x80
        public float hp_steal_per { get; set; }// 0x88
        public float atk_add { get; set; }// 0x90
        public float def_add { get; set; }// 0x98
        public float hp_add { get; set; }// 0xA0
        public byte create_special_score { get; set; }// 0xA8
        public List<int> list_array_passive_skill_id = new List<int>();// 0xB0
        public int monster_drop_id { get; set; }// 0xB8
        public int monster_group_id { get; set; }// 0xC0
        protected override uint XOROperand { get { return 0x2C1; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            kind = reader.ReadByte();
            attribute = reader.ReadByte();
            monster_class = reader.ReadByte();
            hp_visible_type = reader.ReadByte();
            nick = reader.ReadString();
            name = reader.ReadString();
            atk = DecryptFloat(reader.ReadBytes(4));
            fixed_atk_per = DecryptFloat(reader.ReadBytes(4));
            crit_per = DecryptFloat(reader.ReadBytes(4));
            crit_atk_per = DecryptFloat(reader.ReadBytes(4));
            def = DecryptFloat(reader.ReadBytes(4));
            fixed_def_per = DecryptFloat(reader.ReadBytes(4));
            crit_res_per = DecryptFloat(reader.ReadBytes(4));
            crit_def_per = DecryptFloat(reader.ReadBytes(4));
            hp = DecryptFloat(reader.ReadBytes(4));
            hp_regen_per = DecryptFloat(reader.ReadBytes(4));
            hp_recovery_per = DecryptFloat(reader.ReadBytes(4));
            hp_steal_per = DecryptFloat(reader.ReadBytes(4));
            atk_add = DecryptFloat(reader.ReadBytes(4));
            def_add = DecryptFloat(reader.ReadBytes(4));
            hp_add = DecryptFloat(reader.ReadBytes(4));
            create_special_score = reader.ReadByte();
            //array_passive_skill_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_passive_skill_id.Add(reader.ReadInt32());
                v0--;
            }
            monster_drop_id = DecryptInt32(reader.ReadBytes(4));
            monster_group_id = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBMonsterResourceRow : DataTableCryptographer
    {
        public int id { get; set; }// 0x10
        public byte check_size { get; set; }// 0x18
        public string helm_mixer_name { get; set; }// 0x20
        public float attack_range { get; set; }// 0x28
        public string character_base { get; set; }// 0x30
        public string resource_head { get; set; }// 0x38
        public string resource_body { get; set; }// 0x40
        public byte weapon_model_type { get; set; }// 0x48
        public string resource_weapon { get; set; }// 0x50
        public List<int> list_array_weapon_attach_dummy = new List<int>();// 0x58
        public List<int> list_array_weapon_combi_attach_dummy = new List<int>();// 0x60
        public string ani_directory_name { get; set; }// 0x68
        public float move_speed { get; set; }// 0x70
        public float model_scale { get; set; }// 0x78
        public float sfx_scale { get; set; }// 0x80
        public int enable_special_sfx { get; set; }// 0x88
        public string potrait_base { get; set; }// 0x90
        protected override uint XOROperand { get { return 0x250; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            check_size = reader.ReadByte();
            helm_mixer_name = reader.ReadString();
            attack_range = DecryptFloat(reader.ReadBytes(4));
            character_base = reader.ReadString();
            resource_head = reader.ReadString();
            resource_body = reader.ReadString();
            weapon_model_type = reader.ReadByte();
            resource_weapon = reader.ReadString();
            //array_weapon_attach_dummy = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_weapon_attach_dummy.Add(reader.ReadInt32());
                v0--;
            }
            //array_weapon_combi_attach_dummy = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_weapon_combi_attach_dummy.Add(reader.ReadInt32());
                v1--;
            }
            ani_directory_name = reader.ReadString();
            move_speed = DecryptFloat(reader.ReadBytes(4));
            model_scale = DecryptFloat(reader.ReadBytes(4));
            sfx_scale = DecryptFloat(reader.ReadBytes(4));
            enable_special_sfx = DecryptInt32(reader.ReadBytes(4));
            potrait_base = reader.ReadString();
            return true;
        }
    }
    public class DBMonsterSkillRow : DataTableCryptographer
    {
        public int id { get; set; }// 0x10
        public int skill_a_1_id { get; set; }// 0x18
        public int skill_a_2_id { get; set; }// 0x20
        public int skill_a_3_id { get; set; }// 0x28
        public byte skill_a_draw_per { get; set; }// 0x30
        public byte skill_a_2_logic_cam { get; set; }// 0x31
        public byte skill_a_3_logic_cam { get; set; }// 0x32
        public int skill_b_1_id { get; set; }// 0x38
        public int skill_b_2_id { get; set; }// 0x40
        public int skill_b_3_id { get; set; }// 0x48
        public byte skill_b_draw_per { get; set; }// 0x50
        public byte skill_b_2_logic_cam { get; set; }// 0x51
        public byte skill_b_3_logic_cam { get; set; }// 0x52
        public int skill_exclusive_a_id { get; set; }// 0x58
        public int skill_exclusive_b_id { get; set; }// 0x60
        public int counter_attack_1_id { get; set; }// 0x68
        public int counter_attack_2_id { get; set; }// 0x70
        public int counter_attack_3_id { get; set; }// 0x78
        public int special_id { get; set; }// 0x80
        protected override uint XOROperand { get { return 0x366; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            skill_a_1_id = DecryptInt32(reader.ReadBytes(4));
            skill_a_2_id = DecryptInt32(reader.ReadBytes(4));
            skill_a_3_id = DecryptInt32(reader.ReadBytes(4));
            skill_a_draw_per = reader.ReadByte();
            skill_a_2_logic_cam = reader.ReadByte();
            skill_a_3_logic_cam = reader.ReadByte();
            skill_b_1_id = DecryptInt32(reader.ReadBytes(4));
            skill_b_2_id = DecryptInt32(reader.ReadBytes(4));
            skill_b_3_id = DecryptInt32(reader.ReadBytes(4));
            skill_b_draw_per = reader.ReadByte();
            skill_b_2_logic_cam = reader.ReadByte();
            skill_b_3_logic_cam = reader.ReadByte();
            skill_exclusive_a_id = DecryptInt32(reader.ReadBytes(4));
            skill_exclusive_b_id = DecryptInt32(reader.ReadBytes(4));
            counter_attack_1_id = DecryptInt32(reader.ReadBytes(4));
            counter_attack_2_id = DecryptInt32(reader.ReadBytes(4));
            counter_attack_3_id = DecryptInt32(reader.ReadBytes(4));
            special_id = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBStageDestroyRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public string stage_string { get; set; } // 0x20
        public string control_type { get; set; } // 0x28
        public int region { get; set; } // 0x30
        public int group_id { get; set; } // 0x38
        public int destroy_index { get; set; } // 0x40
        public int area_switching { get; set; } // 0x48
        public int need_quest_id { get; set; } // 0x50
        public int need_main_stage_id { get; set; } // 0x58
        public List<string> list_array_contents_check = new List<string>(); // 0x60
        public int difficulty { get; set; } // 0x68
        public int difficulty_lock { get; set; } // 0x70
        public string difficulty_string { get; set; } // 0x78
        public string info_image { get; set; } // 0x80
        public string info_guide { get; set; } // 0x88
        public int start_cut { get; set; } // 0x90
        public int end_cut { get; set; } // 0x98
        public int bgm_sound_id_1 { get; set; } // 0xA0
        public int ambient_sound_id_1 { get; set; } // 0xA8
        public int bgm_sound_id_2 { get; set; } // 0xB0
        public int ambient_sound_id_2 { get; set; } // 0xB8
        public int bgm_sound_id_3 { get; set; } // 0xC0
        public int ambient_sound_id_3 { get; set; } // 0xC8
        public int bgm_sound_id_4 { get; set; } // 0xD0
        public int ambient_sound_id_4 { get; set; } // 0xD8
        public int bgm_sound_id_5 { get; set; } // 0xE0
        public int ambient_sound_id_5 { get; set; } // 0xE8
        public int story_id_1 { get; set; } // 0xF0
        public int story_id_2 { get; set; } // 0xF8
        public int story_id_3 { get; set; } // 0x100
        public int need_stamina_item_id { get; set; } // 0x108
        public int need_stamina_count { get; set; } // 0x110
        public int switching_basepoint_id { get; set; } // 0x118
        public int destroy_fellow_exp { get; set; } // 0x120
        public int destroy_buff_id { get; set; } // 0x128
        public int destroy_boss_id { get; set; } // 0x130
        public string area_icon { get; set; } // 0x138
        public string room_file_name { get; set; } // 0x140
        public string room_spawn_prop_filename { get; set; } // 0x148
        public string bg_resource_path { get; set; } // 0x150
        public string stage_bg_resource { get; set; } // 0x158
        public int room_bgm_sound_id { get; set; } // 0x160
        public int user_exp { get; set; } // 0x168
        public int hero_exp { get; set; } // 0x170
        public int gold_value { get; set; } // 0x178
        public int group_item_rate_add { get; set; } // 0x180
        public int drop_item_boss_min_count { get; set; } // 0x188
        public int drop_item_boss_max_count { get; set; } // 0x190
        public int monster_material_per { get; set; } // 0x198
        public int drop_item_id_1 { get; set; } // 0x1A0
        public int drop_item_value_1 { get; set; } // 0x1A8
        public int drop_item_evolution_count_1 { get; set; } // 0x1B0
        public int drop_item_per_1 { get; set; } // 0x1B8
        public int drop_item_box_1 { get; set; } // 0x1C0
        public int drop_item_id_2 { get; set; } // 0x1C8
        public int drop_item_value_2 { get; set; } // 0x1D0
        public int drop_item_evolution_count_2 { get; set; } // 0x1D8
        public int drop_item_per_2 { get; set; } // 0x1E0
        public int drop_item_box_2 { get; set; } // 0x1E8
        public int drop_item_id_3 { get; set; } // 0x1F0
        public int drop_item_value_3 { get; set; } // 0x1F8
        public int drop_item_evolution_count_3 { get; set; } // 0x200
        public int drop_item_per_3 { get; set; } // 0x208
        public int drop_item_box_3 { get; set; } // 0x210
        public int drop_item_id_4 { get; set; } // 0x218
        public int drop_item_value_4 { get; set; } // 0x220
        public int drop_item_evolution_count_4 { get; set; } // 0x228
        public int drop_item_per_4 { get; set; } // 0x230
        public int drop_item_box_4 { get; set; } // 0x238
        public int drop_item_id_5 { get; set; } // 0x240
        public int drop_item_value_5 { get; set; } // 0x248
        public int drop_item_evolution_count_5 { get; set; } // 0x250
        public int drop_item_per_5 { get; set; } // 0x258
        public int drop_item_box_5 { get; set; } // 0x260
        public int drop_item_id_6 { get; set; } // 0x268
        public int drop_item_value_6 { get; set; } // 0x270
        public int drop_item_evolution_count_6 { get; set; } // 0x278
        public int drop_item_per_6 { get; set; } // 0x280
        public int drop_item_box_6 { get; set; } // 0x288
        public int drop_item_id_7 { get; set; } // 0x290
        public int drop_item_value_7 { get; set; } // 0x298
        public int drop_item_evolution_count_7 { get; set; } // 0x2A0
        public int drop_item_per_7 { get; set; } // 0x2A8
        public int drop_item_box_7 { get; set; } // 0x2B0
        public int drop_item_id_8 { get; set; } // 0x2B8
        public int drop_item_value_8 { get; set; } // 0x2C0
        public int drop_item_evolution_count_8 { get; set; } // 0x2C8
        public int drop_item_per_8 { get; set; } // 0x2D0
        public int drop_item_box_8 { get; set; } // 0x2D8
        public int drop_item_id_9 { get; set; } // 0x2E0
        public int drop_item_value_9 { get; set; } // 0x2E8
        public int drop_item_evolution_count_9 { get; set; } // 0x2F0
        public int drop_item_per_9 { get; set; } // 0x2F8
        public int drop_item_box_9 { get; set; } // 0x300
        public int drop_item_id_10 { get; set; } // 0x308
        public int drop_item_value_10 { get; set; } // 0x310
        public int drop_item_evolution_count_10 { get; set; } // 0x318
        public int drop_item_per_10 { get; set; } // 0x320
        public int drop_item_box_10 { get; set; } // 0x328
        public int drop_item_id_11 { get; set; } // 0x330
        public int drop_item_value_11 { get; set; } // 0x338
        public int drop_item_evolution_count_11 { get; set; } // 0x340
        public int drop_item_per_11 { get; set; } // 0x348
        public int drop_item_box_11 { get; set; } // 0x350
        public int drop_item_id_12 { get; set; } // 0x358
        public int drop_item_value_12 { get; set; } // 0x360
        public int drop_item_evolution_count_12 { get; set; } // 0x368
        public int drop_item_per_12 { get; set; } // 0x370
        public int drop_item_box_12 { get; set; } // 0x378
        public int drop_item_id_13 { get; set; } // 0x380
        public int drop_item_value_13 { get; set; } // 0x388
        public int drop_item_evolution_count_13 { get; set; } // 0x390
        public int drop_item_per_13 { get; set; } // 0x398
        public int drop_item_box_13 { get; set; } // 0x3A0
        public int drop_item_id_14 { get; set; } // 0x3A8
        public int drop_item_value_14 { get; set; } // 0x3B0
        public int drop_item_evolution_count_14 { get; set; } // 0x3B8
        public int drop_item_per_14 { get; set; } // 0x3C0
        public int drop_item_box_14 { get; set; } // 0x3C8
        public int drop_item_id_15 { get; set; } // 0x3D0
        public int drop_item_value_15 { get; set; } // 0x3D8
        public int drop_item_evolution_count_15 { get; set; } // 0x3E0
        public int drop_item_per_15 { get; set; } // 0x3E8
        public int drop_item_box_15 { get; set; } // 0x3F0
        public int drop_item_id_16 { get; set; } // 0x3F8
        public int drop_item_value_16 { get; set; } // 0x400
        public int drop_item_evolution_count_16 { get; set; } // 0x408
        public int drop_item_per_16 { get; set; } // 0x410
        public int drop_item_box_16 { get; set; } // 0x418
        public int drop_item_id_17 { get; set; } // 0x420
        public int drop_item_value_17 { get; set; } // 0x428
        public int drop_item_evolution_count_17 { get; set; } // 0x430
        public int drop_item_per_17 { get; set; } // 0x438
        public int drop_item_box_17 { get; set; } // 0x440
        public int drop_item_id_18 { get; set; } // 0x448
        public int drop_item_value_18 { get; set; } // 0x450
        public int drop_item_evolution_count_18 { get; set; } // 0x458
        public int drop_item_per_18 { get; set; } // 0x460
        public int drop_item_box_18 { get; set; } // 0x468
        public int chief_drop_item_id_1 { get; set; } // 0x470
        public int chief_drop_item_value_1 { get; set; } // 0x478
        public int chief_drop_item_evolution_count_1 { get; set; } // 0x480
        public int chief_drop_item_per_1 { get; set; } // 0x488
        public int chief_drop_item_box_1 { get; set; } // 0x490
        public int chief_drop_item_id_2 { get; set; } // 0x498
        public int chief_drop_item_value_2 { get; set; } // 0x4A0
        public int chief_drop_item_evolution_count_2 { get; set; } // 0x4A8
        public int chief_drop_item_per_2 { get; set; } // 0x4B0
        public int chief_drop_item_box_2 { get; set; } // 0x4B8
        public int chief_drop_item_id_3 { get; set; } // 0x4C0
        public int chief_drop_item_value_3 { get; set; } // 0x4C8
        public int chief_drop_item_evolution_count_3 { get; set; } // 0x4D0
        public int chief_drop_item_per_3 { get; set; } // 0x4D8
        public int chief_drop_item_box_3 { get; set; } // 0x4E0
        public int chief_drop_item_id_4 { get; set; } // 0x4E8
        public int chief_drop_item_value_4 { get; set; } // 0x4F0
        public int chief_drop_item_evolution_count_4 { get; set; } // 0x4F8
        public int chief_drop_item_per_4 { get; set; } // 0x500
        public int chief_drop_item_box_4 { get; set; } // 0x508
        public int chief_drop_item_id_5 { get; set; } // 0x510
        public int chief_drop_item_value_5 { get; set; } // 0x518
        public int chief_drop_item_evolution_count_5 { get; set; } // 0x520
        public int chief_drop_item_per_5 { get; set; } // 0x528
        public int chief_drop_item_box_5 { get; set; } // 0x530
        public int chief_drop_item_id_6 { get; set; } // 0x538
        public int chief_drop_item_value_6 { get; set; } // 0x540
        public int chief_drop_item_evolution_count_6 { get; set; } // 0x548
        public int chief_drop_item_per_6 { get; set; } // 0x550
        public int chief_drop_item_box_6 { get; set; } // 0x558
        public int phase_shift_cinema_two_boss { get; set; } // 0x560
        public string stage_placement { get; set; } // 0x568
        public string situation_behavior_tree_name { get; set; } // 0x570
        public List<int> list_array_destroy_tag = new List<int>(); // 0x578
        public int boss_atk_inc_per_1 { get; set; } // 0x580
        public int boss_def_inc_per_1 { get; set; } // 0x588
        public int boss_hp_inc_per_1 { get; set; } // 0x590
        public int boss_id_1 { get; set; } // 0x598
        public int boss_level_1 { get; set; } // 0x5A0
        public int monster_ai_id_1 { get; set; } // 0x5A8
        public int boss_skill_level_1 { get; set; } // 0x5B0
        public List<int> list_array_skill_a_draw_per_list1 = new List<int>(); // 0x5B8
        public List<int> list_array_skill_b_draw_per_list1 = new List<int>(); // 0x5C0
        public List<int> list_array_passive1 = new List<int>(); // 0x5C8
        public int boss_atk_inc_per_2 { get; set; } // 0x5D0
        public int boss_def_inc_per_2 { get; set; } // 0x5D8
        public int boss_hp_inc_per_2 { get; set; } // 0x5E0
        public int boss_id_2 { get; set; } // 0x5E8
        public int boss_level_2 { get; set; } // 0x5F0
        public int monster_ai_id_2 { get; set; } // 0x5F8
        public int boss_skill_level_2 { get; set; } // 0x600
        public List<int> list_array_skill_a_draw_per_list2 = new List<int>(); // 0x608
        public List<int> list_array_skill_b_draw_per_list2 = new List<int>(); // 0x610
        public List<int> list_array_passive2 = new List<int>(); // 0x618
        public int boss_atk_inc_per_3 { get; set; } // 0x620
        public int boss_def_inc_per_3 { get; set; } // 0x628
        public int boss_hp_inc_per_3 { get; set; } // 0x630
        public int boss_id_3 { get; set; } // 0x638
        public int boss_level_3 { get; set; } // 0x640
        public int monster_ai_id_3 { get; set; } // 0x648
        public int boss_skill_level_3 { get; set; } // 0x650
        public List<int> list_array_skill_a_draw_per_list3 = new List<int>(); // 0x658
        public List<int> list_array_skill_b_draw_per_list3 = new List<int>(); // 0x660
        public List<int> list_array_passive3 = new List<int>(); // 0x668
        public int play_boss_spawn { get; set; } // 0x670
        public string boss_entry_type { get; set; } // 0x678
        public int team_power { get; set; } // 0x680
        public string map_filename { get; set; } // 0x688
        public string spawn_prop_filename { get; set; } // 0x690
        public string change_map_filename { get; set; } // 0x698
        public int bgm_sound_id { get; set; } // 0x6A0
        public int boss_sound_id { get; set; } // 0x6A8
        public string EssenCondition_1 { get; set; } // 0x6B0
        public int EssenConditionValue_1 { get; set; } // 0x6B8
        public string EssenCondition_2 { get; set; } // 0x6C0
        public int EssenConditionValue_2 { get; set; } // 0x6C8
        public string EssenCondition_3 { get; set; } // 0x6D0
        public int EssenConditionValue_3 { get; set; } // 0x6D8
        public string EssenCondition_4 { get; set; } // 0x6E0
        public int EssenConditionValue_4 { get; set; } // 0x6E8
        public string BanCondition_1 { get; set; } // 0x6F0
        public int BanConditionValue_1 { get; set; } // 0x6F8
        public string BanCondition_2 { get; set; } // 0x700
        public int BanConditionValue_2 { get; set; } // 0x708
        public string BanCondition_3 { get; set; } // 0x710
        public int BanConditionValue_3 { get; set; } // 0x718
        public string BanCondition_4 { get; set; } // 0x720
        public int BanConditionValue_4 { get; set; } // 0x728
        public string BanCondition_5 { get; set; } // 0x730
        public int BanConditionValue_5 { get; set; } // 0x738
        public string BanCondition_6 { get; set; } // 0x740
        public int BanConditionValue_6 { get; set; } // 0x748
        public int season_id { get; set; } // 0x750
        public List<int> list_bgm_sound_id = new List<int>(); // 0x758
        public List<int> list_ambient_sound_id = new List<int>(); // 0x760
        public List<int> list_story_id = new List<int>(); // 0x768
        public List<int> list_drop_item_id = new List<int>(); // 0x770
        public List<int> list_drop_item_value = new List<int>(); // 0x778
        public List<int> list_drop_item_evolution_count = new List<int>(); // 0x780
        public List<int> list_drop_item_per = new List<int>(); // 0x788
        public List<int> list_drop_item_box = new List<int>(); // 0x790
        public List<int> list_chief_drop_item_id = new List<int>(); // 0x798
        public List<int> list_chief_drop_item_value = new List<int>(); // 0x7A0
        public List<int> list_chief_drop_item_evolution_count = new List<int>(); // 0x7A8
        public List<int> list_chief_drop_item_per = new List<int>(); // 0x7B0
        public List<int> list_chief_drop_item_box = new List<int>(); // 0x7B8
        public List<int> list_boss_atk_inc_per = new List<int>(); // 0x7C0
        public List<int> list_boss_def_inc_per = new List<int>(); // 0x7C8
        public List<int> list_boss_hp_inc_per = new List<int>(); // 0x7D0
        public List<int> list_boss_id = new List<int>(); // 0x7D8
        public List<int> list_boss_level = new List<int>(); // 0x7E0
        public List<int> list_monster_ai_id = new List<int>(); // 0x7E8
        public List<int> list_boss_skill_level = new List<int>(); // 0x7F0
        public List<string> list_EssenCondition = new List<string>(); // 0x7F8
        public List<int> list_EssenConditionValue = new List<int>(); // 0x800
        public List<string> list_BanCondition = new List<string>(); // 0x808
        public List<int> list_BanConditionValue = new List<int>(); // 0x810
        protected override uint XOROperand { get { return 0x460; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            type = reader.ReadString();
            stage_string = reader.ReadString();
            control_type = reader.ReadString();
            region = DecryptInt32(reader.ReadBytes(4));
            group_id = DecryptInt32(reader.ReadBytes(4));
            destroy_index = DecryptInt32(reader.ReadBytes(4));
            area_switching = DecryptInt32(reader.ReadBytes(4));
            need_quest_id = DecryptInt32(reader.ReadBytes(4));
            need_main_stage_id = DecryptInt32(reader.ReadBytes(4));
            //array_contents_check = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_contents_check.Add(reader.ReadString());
                v0--;
            }
            difficulty = DecryptInt32(reader.ReadBytes(4));
            difficulty_lock = DecryptInt32(reader.ReadBytes(4));
            difficulty_string = reader.ReadString();
            info_image = reader.ReadString();
            info_guide = reader.ReadString();
            start_cut = DecryptInt32(reader.ReadBytes(4));
            end_cut = DecryptInt32(reader.ReadBytes(4));
            bgm_sound_id_1 = DecryptInt32(reader.ReadBytes(4));
            ambient_sound_id_1 = DecryptInt32(reader.ReadBytes(4));
            bgm_sound_id_2 = DecryptInt32(reader.ReadBytes(4));
            ambient_sound_id_2 = DecryptInt32(reader.ReadBytes(4));
            bgm_sound_id_3 = DecryptInt32(reader.ReadBytes(4));
            ambient_sound_id_3 = DecryptInt32(reader.ReadBytes(4));
            bgm_sound_id_4 = DecryptInt32(reader.ReadBytes(4));
            ambient_sound_id_4 = DecryptInt32(reader.ReadBytes(4));
            bgm_sound_id_5 = DecryptInt32(reader.ReadBytes(4));
            ambient_sound_id_5 = DecryptInt32(reader.ReadBytes(4));
            story_id_1 = DecryptInt32(reader.ReadBytes(4));
            story_id_2 = DecryptInt32(reader.ReadBytes(4));
            story_id_3 = DecryptInt32(reader.ReadBytes(4));
            need_stamina_item_id = DecryptInt32(reader.ReadBytes(4));
            need_stamina_count = DecryptInt32(reader.ReadBytes(4));
            switching_basepoint_id = DecryptInt32(reader.ReadBytes(4));
            destroy_fellow_exp = DecryptInt32(reader.ReadBytes(4));
            destroy_buff_id = DecryptInt32(reader.ReadBytes(4));
            destroy_boss_id = DecryptInt32(reader.ReadBytes(4));
            area_icon = reader.ReadString();
            room_file_name = reader.ReadString();
            room_spawn_prop_filename = reader.ReadString();
            bg_resource_path = reader.ReadString();
            stage_bg_resource = reader.ReadString();
            room_bgm_sound_id = DecryptInt32(reader.ReadBytes(4));
            user_exp = DecryptInt32(reader.ReadBytes(4));
            hero_exp = DecryptInt32(reader.ReadBytes(4));
            gold_value = DecryptInt32(reader.ReadBytes(4));
            group_item_rate_add = DecryptInt32(reader.ReadBytes(4));
            drop_item_boss_min_count = DecryptInt32(reader.ReadBytes(4));
            drop_item_boss_max_count = DecryptInt32(reader.ReadBytes(4));
            monster_material_per = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_1 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_1 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_1 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_1 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_1 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_2 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_2 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_2 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_2 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_2 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_3 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_3 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_3 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_3 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_3 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_4 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_4 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_4 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_4 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_4 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_5 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_5 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_5 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_5 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_5 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_6 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_6 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_6 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_6 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_6 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_7 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_7 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_7 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_7 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_7 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_8 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_8 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_8 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_8 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_8 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_9 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_9 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_9 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_9 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_9 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_10 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_10 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_10 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_10 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_10 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_11 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_11 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_11 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_11 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_11 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_12 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_12 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_12 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_12 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_12 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_13 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_13 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_13 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_13 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_13 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_14 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_14 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_14 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_14 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_14 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_15 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_15 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_15 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_15 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_15 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_16 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_16 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_16 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_16 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_16 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_17 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_17 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_17 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_17 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_17 = DecryptInt32(reader.ReadBytes(4));
            drop_item_id_18 = DecryptInt32(reader.ReadBytes(4));
            drop_item_value_18 = DecryptInt32(reader.ReadBytes(4));
            drop_item_evolution_count_18 = DecryptInt32(reader.ReadBytes(4));
            drop_item_per_18 = DecryptInt32(reader.ReadBytes(4));
            drop_item_box_18 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_id_1 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_value_1 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_evolution_count_1 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_per_1 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_box_1 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_id_2 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_value_2 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_evolution_count_2 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_per_2 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_box_2 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_id_3 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_value_3 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_evolution_count_3 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_per_3 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_box_3 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_id_4 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_value_4 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_evolution_count_4 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_per_4 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_box_4 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_id_5 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_value_5 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_evolution_count_5 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_per_5 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_box_5 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_id_6 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_value_6 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_evolution_count_6 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_per_6 = DecryptInt32(reader.ReadBytes(4));
            chief_drop_item_box_6 = DecryptInt32(reader.ReadBytes(4));
            phase_shift_cinema_two_boss = DecryptInt32(reader.ReadBytes(4));
            stage_placement = reader.ReadString();
            situation_behavior_tree_name = reader.ReadString();
            //array_destroy_tag = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_destroy_tag.Add(reader.ReadInt32());
                v1--;
            }
            boss_atk_inc_per_1 = DecryptInt32(reader.ReadBytes(4));
            boss_def_inc_per_1 = DecryptInt32(reader.ReadBytes(4));
            boss_hp_inc_per_1 = DecryptInt32(reader.ReadBytes(4));
            boss_id_1 = DecryptInt32(reader.ReadBytes(4));
            boss_level_1 = DecryptInt32(reader.ReadBytes(4));
            monster_ai_id_1 = DecryptInt32(reader.ReadBytes(4));
            boss_skill_level_1 = DecryptInt32(reader.ReadBytes(4));
            //array_skill_a_draw_per_list1 = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_skill_a_draw_per_list1.Add(reader.ReadInt32());
                v2--;
            }
            //array_skill_b_draw_per_list1 = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_skill_b_draw_per_list1.Add(reader.ReadInt32());
                v3--;
            }
            //array_passive1 = reader.ReadString();
            var v4 = reader.ReadInt32();
            while ((v4 - 1) >= 0)
            {
                list_array_passive1.Add(reader.ReadInt32());
                v4--;
            }
            boss_atk_inc_per_2 = DecryptInt32(reader.ReadBytes(4));
            boss_def_inc_per_2 = DecryptInt32(reader.ReadBytes(4));
            boss_hp_inc_per_2 = DecryptInt32(reader.ReadBytes(4));
            boss_id_2 = DecryptInt32(reader.ReadBytes(4));
            boss_level_2 = DecryptInt32(reader.ReadBytes(4));
            monster_ai_id_2 = DecryptInt32(reader.ReadBytes(4));
            boss_skill_level_2 = DecryptInt32(reader.ReadBytes(4));
            //array_skill_a_draw_per_list2 = reader.ReadString();
            var v5 = reader.ReadInt32();
            while ((v5 - 1) >= 0)
            {
                list_array_skill_a_draw_per_list2.Add(reader.ReadInt32());
                v5--;
            }
            ////array_skill_b_draw_per_list2 = reader.ReadString();
            var v6 = reader.ReadInt32();
            while ((v6 - 1) >= 0)
            {
                list_array_skill_b_draw_per_list2.Add(reader.ReadInt32());
                v6--;
            }
            //array_passive2 = reader.ReadString();
            var v7 = reader.ReadInt32();
            while ((v7 - 1) >= 0)
            {
                list_array_passive2.Add(reader.ReadInt32());
                v7--;
            }
            boss_atk_inc_per_3 = DecryptInt32(reader.ReadBytes(4));
            boss_def_inc_per_3 = DecryptInt32(reader.ReadBytes(4));
            boss_hp_inc_per_3 = DecryptInt32(reader.ReadBytes(4));
            boss_id_3 = DecryptInt32(reader.ReadBytes(4));
            boss_level_3 = DecryptInt32(reader.ReadBytes(4));
            monster_ai_id_3 = DecryptInt32(reader.ReadBytes(4));
            boss_skill_level_3 = DecryptInt32(reader.ReadBytes(4));
            //array_skill_a_draw_per_list3 = reader.ReadString();
            var v8 = reader.ReadInt32();
            while ((v8 - 1) >= 0)
            {
                list_array_skill_a_draw_per_list3.Add(reader.ReadInt32());
                v8--;
            }
            //array_skill_b_draw_per_list3 = reader.ReadString();
            var v9 = reader.ReadInt32();
            while ((v9 - 1) >= 0)
            {
                list_array_skill_b_draw_per_list3.Add(reader.ReadInt32());
                v9--;
            }
            //array_passive3 = reader.ReadString();
            var v10 = reader.ReadInt32();
            while ((v10 - 1) >= 0)
            {
                list_array_passive3.Add(reader.ReadInt32());
                v10--;
            }
            play_boss_spawn = DecryptInt32(reader.ReadBytes(4));
            boss_entry_type = reader.ReadString();
            team_power = DecryptInt32(reader.ReadBytes(4));
            map_filename = reader.ReadString();
            spawn_prop_filename = reader.ReadString();
            change_map_filename = reader.ReadString();
            bgm_sound_id = DecryptInt32(reader.ReadBytes(4));
            boss_sound_id = DecryptInt32(reader.ReadBytes(4));
            EssenCondition_1 = reader.ReadString();
            EssenConditionValue_1 = DecryptInt32(reader.ReadBytes(4));
            EssenCondition_2 = reader.ReadString();
            EssenConditionValue_2 = DecryptInt32(reader.ReadBytes(4));
            EssenCondition_3 = reader.ReadString();
            EssenConditionValue_3 = DecryptInt32(reader.ReadBytes(4));
            EssenCondition_4 = reader.ReadString();
            EssenConditionValue_4 = DecryptInt32(reader.ReadBytes(4));
            BanCondition_1 = reader.ReadString();
            BanConditionValue_1 = DecryptInt32(reader.ReadBytes(4));
            BanCondition_2 = reader.ReadString();
            BanConditionValue_2 = DecryptInt32(reader.ReadBytes(4));
            BanCondition_3 = reader.ReadString();
            BanConditionValue_3 = DecryptInt32(reader.ReadBytes(4));
            BanCondition_4 = reader.ReadString();
            BanConditionValue_4 = DecryptInt32(reader.ReadBytes(4));
            BanCondition_5 = reader.ReadString();
            BanConditionValue_5 = DecryptInt32(reader.ReadBytes(4));
            BanCondition_6 = reader.ReadString();
            BanConditionValue_6 = DecryptInt32(reader.ReadBytes(4));
            season_id = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBSkillPassiveRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public string name { get; set; } // 0x18
        public string explain { get; set; } // 0x20
        public string icon { get; set; } // 0x28
        public int first_stack { get; set; } // 0x30
        public int max_stack { get; set; } // 0x38
        public string effect_keyword { get; set; } // 0x40
        public int effect_value { get; set; } // 0x48
        public int effect_value_add { get; set; } // 0x50
        public string sub_value_type { get; set; } // 0x58
        public int sub_value { get; set; } // 0x60
        public string target { get; set; } // 0x68
        public int kind_target { get; set; } // 0x70
        public int attribute_target { get; set; } // 0x78
        public string array_apply_contents { get; set; } // 0x80
        public List<int> list_array_apply_contents = new List<int>(); // 0x88
        public string array_use_buff_keyword { get; set; } // 0x90
        public List<string> list_array_use_buff_keyword = new List<string>(); // 0x98
        public string array_use_option_keyword { get; set; } // 0xA0
        public List<string> list_array_use_option_keyword = new List<string>(); // 0xA8
        public string array_use_buff_id { get; set; } // 0xB0
        public List<int> list_array_use_buff_id = new List<int>(); // 0xB8
        public string active_text { get; set; } // 0xC0
        public int active_sfx_id { get; set; } // 0xC8
        public string exclusive_type { get; set; } // 0xD0
        public int exclusive_ani { get; set; } // 0xD8
        protected override uint XOROperand { get { return 0x24C; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            name = reader.ReadString();
            explain = reader.ReadString();
            icon = reader.ReadString();
            first_stack = DecryptInt32(reader.ReadBytes(4));
            max_stack = DecryptInt32(reader.ReadBytes(4));
            effect_keyword = reader.ReadString();
            effect_value = DecryptInt32(reader.ReadBytes(4));
            effect_value_add = DecryptInt32(reader.ReadBytes(4));
            sub_value_type = reader.ReadString();
            sub_value = DecryptInt32(reader.ReadBytes(4));
            target = reader.ReadString();
            kind_target = DecryptInt32(reader.ReadBytes(4));
            attribute_target = DecryptInt32(reader.ReadBytes(4));
            //array_apply_contents = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_apply_contents.Add(reader.ReadInt32());
                v0--;
            }
            //array_use_buff_keyword = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_use_buff_keyword.Add(reader.ReadString());
                v1--;
            }
            //array_use_option_keyword = reader.ReadString();
            var v2 = reader.ReadInt32();
            while ((v2 - 1) >= 0)
            {
                list_array_use_option_keyword.Add(reader.ReadString());
                v2--;
            }
            //array_use_buff_id = reader.ReadString();
            var v3 = reader.ReadInt32();
            while ((v3 - 1) >= 0)
            {
                list_array_use_buff_id.Add(reader.ReadInt32());
                v3--;
            }
            active_text = reader.ReadString();
            active_sfx_id = DecryptInt32(reader.ReadBytes(4));
            exclusive_type = reader.ReadString();
            exclusive_ani = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBSkillCardResourceRow : DataTableCryptographer
    {
        public int id { get; set; }// 0x10
        public string skill_folder { get; set; }// 0x18
        public string icon { get; set; }// 0x20
        public int hit_sound_id { get; set; }// 0x28
        public int hit_sfx_id { get; set; }// 0x30
        public int last_hit_sfx_id { get; set; }// 0x38
        public string cut_in_special { get; set; }// 0x40
        public List<int> list_array_special_end_sfx_id = new List<int>();// 0x48
        public string special_end_ui_sfx { get; set; }// 0x50
        public byte special_end_ani { get; set; }// 0x58
        public int special_end_sound_id { get; set; }// 0x60
        public List<int> list_array_counter_portrait_sound = new List<int>();// 0x68
        public string counter_portrait_ani { get; set; }// 0x70
        public string counter_portrait_local { get; set; }// 0x78
        protected override uint XOROperand { get { return 0x511; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            skill_folder = reader.ReadString();
            icon = reader.ReadString();
            hit_sound_id = DecryptInt32(reader.ReadBytes(4));
            hit_sfx_id = DecryptInt32(reader.ReadBytes(4));
            last_hit_sfx_id = DecryptInt32(reader.ReadBytes(4));
            cut_in_special = reader.ReadString();
            //array_special_end_sfx_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_special_end_sfx_id.Add(reader.ReadInt32());
                v0--;
            }
            special_end_ui_sfx = reader.ReadString();
            special_end_ani = reader.ReadByte();
            special_end_sound_id = reader.ReadByte();
            //array_counter_portrait_sound = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_counter_portrait_sound.Add(reader.ReadInt32());
                v1--;
            }
            counter_portrait_ani = reader.ReadString();
            counter_portrait_local = reader.ReadString();
            return true;
        }
    }
    public class DBSkillCardOptionRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public int option_per { get; set; } // 0x18
        public string effect_keyword { get; set; } // 0x20
        public string effect_name { get; set; } // 0x28
        public int effect_value { get; set; } // 0x30
        public int effect_value_add { get; set; } // 0x38
        public int target_start_sfx_id { get; set; } // 0x40
        public int use_buff_id { get; set; } // 0x48
        public string array_use_buff_keyword { get; set; } // 0x50
        public List<string> list_array_use_buff_keyword = new List<string>(); // 0x58
        protected override uint XOROperand { get { return 0x4BD; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            option_per = DecryptInt32(reader.ReadBytes(4));
            effect_keyword = reader.ReadString();
            effect_name = reader.ReadString();
            effect_value = DecryptInt32(reader.ReadBytes(4));
            effect_value_add = DecryptInt32(reader.ReadBytes(4));
            target_start_sfx_id = DecryptInt32(reader.ReadBytes(4));
            use_buff_id = DecryptInt32(reader.ReadBytes(4));
            //array_use_buff_keyword = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_use_buff_keyword.Add(reader.ReadString());
                v0--;
            }
            return true;
        }
    }
    public class DBSkillCardBulletRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public int bullet_speed { get; set; } // 0x18
        public string bullet_target_socket { get; set; } // 0x20
        public int fire_sfx_id { get; set; } // 0x28
        protected override uint XOROperand { get { return 0x2D6; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            bullet_speed = DecryptInt32(reader.ReadBytes(4));
            bullet_target_socket = reader.ReadString();
            fire_sfx_id = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBSkillCardBuffRow : DataTableCryptographer
    {
        public int id { get; set; }// 0x10
        public string name { get; set; }// 0x18
        public string explain { get; set; }// 0x20
        public string icon { get; set; }// 0x28
        public string buff_type { get; set; }// 0x30
        public byte buff_target { get; set; }// 0x38
        public float buff_per { get; set; }// 0x40
        public int buff_turn { get; set; }// 0x48
        public int buff_number { get; set; }// 0x50
        public byte overlap_type { get; set; }// 0x58
        public int overlap_limit { get; set; }// 0x60
        public string effect_keyword { get; set; }// 0x68
        public string effect_name { get; set; }// 0x70
        public float effect_value { get; set; }// 0x78
        public float effect_value_add { get; set; }// 0x80
        public List<int> list_effect_give_array_id = new List<int>();// 0x88
        public byte effect_give_attack_type { get; set; }// 0x90
        public string buff_group { get; set; }// 0x98
        public int caster_start_sfx_id { get; set; }// 0xA0
        public List<int> list_array_target_start_sfx_id = new List<int>();// 0xA8
        public int start_sound_id { get; set; }// 0xB0
        public byte buff_loop_cut { get; set; }// 0xB8
        public int target_keep_sfx_id { get; set; }// 0xC0
        public int target_stop_sfx_id { get; set; }// 0xC8
        public int stop_sound_id { get; set; }// 0xD0
        public int target_end_sfx_id { get; set; }// 0xD8
        public int end_sound_id { get; set; }// 0xE0
        public int target_hit_sfx_id { get; set; }// 0xE8
        public int hit_sound_id { get; set; }// 0xF0
        public float sound_delay_sec { get; set; }// 0xF8
        protected override uint XOROperand { get { return 0x47B; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            name = reader.ReadString();
            explain = reader.ReadString();
            icon = reader.ReadString();
            buff_type = reader.ReadString();
            buff_target = reader.ReadByte();
            buff_per = DecryptInt32(reader.ReadBytes(4));
            buff_turn = DecryptInt32(reader.ReadBytes(4));
            buff_number = DecryptInt32(reader.ReadBytes(4));
            overlap_type = reader.ReadByte();
            overlap_limit = DecryptInt32(reader.ReadBytes(4));
            effect_keyword = reader.ReadString();
            effect_name = reader.ReadString();
            effect_value = DecryptInt32(reader.ReadBytes(4));
            effect_value_add = DecryptInt32(reader.ReadBytes(4));
            //effect_give_array_id = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_effect_give_array_id.Add(reader.ReadInt32());
                v0--;
            }
            effect_give_attack_type = reader.ReadByte();
            buff_group = reader.ReadString();
            caster_start_sfx_id = DecryptInt32(reader.ReadBytes(4));
            //array_target_start_sfx_id = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_target_start_sfx_id.Add(reader.ReadInt32());
                v1--;
            }
            start_sound_id = DecryptInt32(reader.ReadBytes(4));
            buff_loop_cut = reader.ReadByte();
            target_keep_sfx_id = DecryptInt32(reader.ReadBytes(4));
            target_stop_sfx_id = DecryptInt32(reader.ReadBytes(4));
            stop_sound_id = DecryptInt32(reader.ReadBytes(4));
            target_end_sfx_id = DecryptInt32(reader.ReadBytes(4));
            end_sound_id = DecryptInt32(reader.ReadBytes(4));
            target_hit_sfx_id = DecryptInt32(reader.ReadBytes(4));
            hit_sound_id = DecryptInt32(reader.ReadBytes(4));
            sound_delay_sec = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBSkillCardBaseRow : DataTableCryptographer
    {
        public int id { get; set; }// 0x10
        public string skill_name { get; set; }// 0x18
        public string skill_explain { get; set; }// 0x20
        public byte range_type { get; set; }// 0x28
        public byte ani_event_type { get; set; }// 0x29
        public byte attack_type { get; set; }// 0x2A
        public byte target { get; set; }// 0x2B
        public int bullet_id { get; set; }// 0x30
        public float atk_per { get; set; }// 0x38
        public float atk_per_add { get; set; }// 0x40
        public List<int> list_array_option_id_list = new List<int>();// 0x48
        public List<int> list_array_buff_id_list = new List<int>();// 0x50
        public byte indicate_skill_card { get; set; }// 0x58
        public byte force_range_type { get; set; }// 0x59
        protected override uint XOROperand { get { return 0x265; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            skill_name = reader.ReadString();
            skill_explain = reader.ReadString();
            range_type = reader.ReadByte();
            ani_event_type = reader.ReadByte();
            attack_type = reader.ReadByte();
            target = reader.ReadByte();
            bullet_id = DecryptInt32(reader.ReadBytes(4));
            atk_per = DecryptInt32(reader.ReadBytes(4));
            atk_per_add = DecryptInt32(reader.ReadBytes(4));
            //array_option_id_list = reader.ReadString();
            var v0 = reader.ReadInt32();
            while ((v0 - 1) >= 0)
            {
                list_array_option_id_list.Add(reader.ReadInt32());
                v0--;
            }
            //array_buff_id_list = reader.ReadString();
            var v1 = reader.ReadInt32();
            while ((v1 - 1) >= 0)
            {
                list_array_buff_id_list.Add(reader.ReadInt32());
                v1--;
            }
            indicate_skill_card = reader.ReadByte();
            force_range_type = reader.ReadByte();
            return true;
        }
    }
    public class DBWeaponGrindRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public int weapon_rating { get; set; } // 0x18
        public int weapon_enchant { get; set; } // 0x20
        public int fellowship_level { get; set; } // 0x28
        public int grind_item_id { get; set; } // 0x30
        public int bonus_rate_1 { get; set; } // 0x38
        public int grind_item_count_1 { get; set; } // 0x40
        public int evolution_item_count_1 { get; set; } // 0x48
        public int bonus_rate_2 { get; set; } // 0x50
        public int grind_item_count_2 { get; set; } // 0x58
        public int evolution_item_count_2 { get; set; } // 0x60
        public int bonus_rate_3 { get; set; } // 0x68
        public int grind_item_count_3 { get; set; } // 0x70
        public float evolution_item_count_3 { get; set; } // 0x78
        public float evolution_item_rate_1 { get; set; } // 0x80
        public float evolution_item_rate_2 { get; set; } // 0x88
        public float evolution_item_rate_3 { get; set; } // 0x90
        public float evolution_item_rate_4 { get; set; } // 0x98
        public float evolution_item_rate_5 { get; set; } // 0xA0
        public float evolution_item_rate_6 { get; set; } // 0xA8
        public List<int> list_bonus_rate = new List<int>(); // 0xB0
        public List<int> list_grind_item_count = new List<int>(); // 0xB8
        public List<int> list_evolution_item_count = new List<int>(); // 0xC0
        public List<float> list_evolution_item_rate = new List<float>(); // 0xC8
        protected override uint XOROperand { get { return 0x258; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            weapon_rating = DecryptInt32(reader.ReadBytes(4));
            weapon_enchant = DecryptInt32(reader.ReadBytes(4));
            fellowship_level = DecryptInt32(reader.ReadBytes(4));
            grind_item_id = DecryptInt32(reader.ReadBytes(4));
            bonus_rate_1 = DecryptInt32(reader.ReadBytes(4));
            grind_item_count_1 = DecryptInt32(reader.ReadBytes(4));
            evolution_item_count_1 = DecryptInt32(reader.ReadBytes(4));
            bonus_rate_2 = DecryptInt32(reader.ReadBytes(4));
            grind_item_count_2 = DecryptInt32(reader.ReadBytes(4));
            evolution_item_count_2 = DecryptInt32(reader.ReadBytes(4));
            bonus_rate_3 = DecryptInt32(reader.ReadBytes(4));
            grind_item_count_3 = DecryptInt32(reader.ReadBytes(4));
            evolution_item_count_3 = DecryptInt32(reader.ReadBytes(4));
            evolution_item_rate_1 = DecryptFloat(reader.ReadBytes(4));
            evolution_item_rate_2 = DecryptFloat(reader.ReadBytes(4));
            evolution_item_rate_3 = DecryptFloat(reader.ReadBytes(4));
            evolution_item_rate_4 = DecryptFloat(reader.ReadBytes(4));
            evolution_item_rate_5 = DecryptFloat(reader.ReadBytes(4));
            evolution_item_rate_6 = DecryptFloat(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBWeaponBaseRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public int Set_id { get; set; } // 0x18
        public int weapon_rating { get; set; } // 0x20
        public int weapon_type { get; set; } // 0x28
        public int weapon_parts { get; set; } // 0x30
        public int status_value_min { get; set; } // 0x38
        public int status_value_max { get; set; } // 0x40
        public int upgrade_status_value { get; set; } // 0x48
        public int random_option_id { get; set; } // 0x50
        public int random_option_count { get; set; } // 0x58
        public int evolution_add_value { get; set; } // 0x60
        protected override uint XOROperand { get { return 0x314; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            Set_id = DecryptInt32(reader.ReadBytes(4));
            weapon_rating = DecryptInt32(reader.ReadBytes(4));
            weapon_type = DecryptInt32(reader.ReadBytes(4));
            weapon_parts = DecryptInt32(reader.ReadBytes(4));
            status_value_min = DecryptInt32(reader.ReadBytes(4));
            status_value_max = DecryptInt32(reader.ReadBytes(4));
            upgrade_status_value = DecryptInt32(reader.ReadBytes(4));
            random_option_id = DecryptInt32(reader.ReadBytes(4));
            random_option_count = DecryptInt32(reader.ReadBytes(4));
            evolution_add_value = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBWeaponOptionRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public int random_option_group { get; set; } // 0x18
        public string random_option_name { get; set; } // 0x20
        public int option_effect_id { get; set; } // 0x28
        public float option_effect_min { get; set; } // 0x30
        public float option_effect_max { get; set; } // 0x38
        public int option_upgrade_value { get; set; } // 0x40
        public string option_name { get; set; } // 0x48
        protected override uint XOROperand { get { return 0x3B8; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            random_option_group = DecryptInt32(reader.ReadBytes(4));
            random_option_name = reader.ReadString();
            option_effect_id = DecryptInt32(reader.ReadBytes(4));
            option_effect_min = DecryptFloat(reader.ReadBytes(4));
            option_effect_max = DecryptFloat(reader.ReadBytes(4));
            option_upgrade_value = DecryptInt32(reader.ReadBytes(4));
            option_name = reader.ReadString();
            return true;
        }
    }
    public class DBWeaponUpgradeRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public int upgrade_level { get; set; } // 0x18
        public int weapon_rating { get; set; } // 0x20
        public int upgrade_per { get; set; } // 0x28
        public int upgrade_material_id { get; set; } // 0x30
        public int upgrade_material_count { get; set; } // 0x38
        public int upgrade_price_id { get; set; } // 0x40
        public int upgrade_price_count { get; set; } // 0x48
        public int upgrade_fail_gauge { get; set; } // 0x50
        protected override uint XOROperand { get { return 0x46B; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            upgrade_level = DecryptInt32(reader.ReadBytes(4));
            weapon_rating = DecryptInt32(reader.ReadBytes(4));
            upgrade_per = DecryptInt32(reader.ReadBytes(4));
            upgrade_material_id = DecryptInt32(reader.ReadBytes(4));
            upgrade_material_count = DecryptInt32(reader.ReadBytes(4));
            upgrade_price_id = DecryptInt32(reader.ReadBytes(4));
            upgrade_price_count = DecryptInt32(reader.ReadBytes(4));
            upgrade_fail_gauge = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBWeaponSetRow : DataTableCryptographer
    {
        public int set_id { get; set; } // 0x10
        public int tab_on { get; set; } // 0x18
        public int display_id { get; set; } // 0x20
        public int set_priority { get; set; } // 0x28
        public string set_icon { get; set; } // 0x30
        public string set_name { get; set; } // 0x38
        public string set_desc { get; set; } // 0x40
        public int set_count { get; set; } // 0x48
        public int set_passive_id { get; set; } // 0x50
        protected override uint XOROperand { get { return 0x34A; } }
        public bool ReadToStream(BinaryReader reader)
        {
            set_id = DecryptInt32(reader.ReadBytes(4));
            tab_on = DecryptInt32(reader.ReadBytes(4));
            display_id = DecryptInt32(reader.ReadBytes(4));
            set_priority = DecryptInt32(reader.ReadBytes(4));
            set_icon = reader.ReadString();
            set_name = reader.ReadString();
            set_desc = reader.ReadString();
            set_count = DecryptInt32(reader.ReadBytes(4));
            set_passive_id = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBWeaponMagicRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public int random_option_type { get; set; } // 0x18
        public int random_option_group { get; set; } // 0x20
        public string random_option_name { get; set; } // 0x28
        public string random_option_desc { get; set; } // 0x30
        public int option_effect_id { get; set; } // 0x38
        public int option_effect_min { get; set; } // 0x40
        public int option_effect_max { get; set; } // 0x48
        protected override uint XOROperand { get { return 0x4A0; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            random_option_type = DecryptInt32(reader.ReadBytes(4));
            random_option_group = DecryptInt32(reader.ReadBytes(4));
            random_option_name = reader.ReadString();
            random_option_desc = reader.ReadString();
            option_effect_id = DecryptInt32(reader.ReadBytes(4));
            option_effect_min = DecryptInt32(reader.ReadBytes(4));
            option_effect_max = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBUpgradeRatingRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public int rating_id { get; set; } // 0x18
        public string rating_name { get; set; } // 0x20
        public int rating_hero_rate { get; set; } // 0x28
        public float rating_hero_value { get; set; } // 0x30
        public int rating_skin_rate { get; set; } // 0x38
        public float rating_skin_value { get; set; } // 0x40
        protected override uint XOROperand { get { return 0x494; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            rating_id = DecryptInt32(reader.ReadBytes(4));
            rating_name = reader.ReadString();
            rating_hero_rate = DecryptInt32(reader.ReadBytes(4));
            rating_hero_value = DecryptFloat(reader.ReadBytes(4));
            rating_skin_rate = DecryptInt32(reader.ReadBytes(4));
            rating_skin_value = DecryptFloat(reader.ReadBytes(4));
            return true;
        }
    }
    public class DBRatingRow : DataTableCryptographer
    {
        public int id { get; set; } // 0x10
        public string type { get; set; } // 0x18
        public int rating { get; set; } // 0x20
        public int rating_max_level { get; set; } // 0x28
        public int capacity_max_level { get; set; } // 0x30
        public int get_exp { get; set; } // 0x38
        public int levelup_exp_per { get; set; } // 0x40
        public int bonus_material_value { get; set; } // 0x48
        public int levelup_price_id { get; set; } // 0x50
        public int levelup_price_count { get; set; } // 0x58
        public float levelup_bonus_per_1 { get; set; } // 0x60
        public int levelup_bonus_value_1 { get; set; } // 0x68
        public float levelup_bonus_per_2 { get; set; } // 0x70
        public int levelup_bonus_value_2 { get; set; } // 0x78
        public float levelup_bonus_per_3 { get; set; } // 0x80
        public int levelup_bonus_value_3 { get; set; } // 0x88
        public int capacity_price_id { get; set; } // 0x90
        public int capacity_price_count { get; set; } // 0x98
        public float capacity_bonus_per_1 { get; set; } // 0xA0
        public int capacity_bonus_value_1 { get; set; } // 0xA8
        public float capacity_bonus_per_2 { get; set; } // 0xB0
        public int capacity_bonus_value_2 { get; set; } // 0xB8
        public float capacity_bonus_per_3 { get; set; } // 0xC0
        public int capacity_bonus_value_3 { get; set; } // 0xC8
        public int skilllevelup_price_id { get; set; } // 0xD0
        public int skilllevelup_price_count { get; set; } // 0xD8
        public int skilllevelup_item_id { get; set; } // 0xE0
        public int skilllevelup_item_count { get; set; } // 0xE8
        public float skilllevelup_bonus_per_1 { get; set; } // 0xF0
        public int skilllevelup_bonus_value_1 { get; set; } // 0xF8
        public float skilllevelup_bonus_per_2 { get; set; } // 0x100
        public int skilllevelup_bonus_value_2 { get; set; } // 0x108
        public float skilllevelup_bonus_per_3 { get; set; } // 0x110
        public int skilllevelup_bonus_value_3 { get; set; } // 0x118
        public int grind_id { get; set; } // 0x120
        public int grind_count { get; set; } // 0x128
        public float grind_bonus_per_1 { get; set; } // 0x130
        public int grind_bonus_value_1 { get; set; } // 0x138
        public float grind_bonus_per_2 { get; set; } // 0x140
        public int grind_bonus_value_2 { get; set; } // 0x148
        public float grind_bonus_per_3 { get; set; } // 0x150
        public int grind_bonus_value_3 { get; set; } // 0x158
        public List<float> list_levelup_bonus_per = new List<float>(); // 0x160
        public List<int> list_levelup_bonus_value = new List<int>(); // 0x168
        public List<float> list_capacity_bonus_per = new List<float>(); // 0x170
        public List<int> list_capacity_bonus_value = new List<int>(); // 0x178
        public List<float> list_skilllevelup_bonus_per = new List<float>(); // 0x180
        public List<int> list_skilllevelup_bonus_value = new List<int>(); // 0x188
        public List<float> list_grind_bonus_per = new List<float>(); // 0x190
        public List<int> list_grind_bonus_value = new List<int>(); // 0x198
        protected override uint XOROperand { get { return 0x493; } }
        public bool ReadToStream(BinaryReader reader)
        {
            id = DecryptInt32(reader.ReadBytes(4));
            type = reader.ReadString();
            rating = DecryptInt32(reader.ReadBytes(4));
            rating_max_level = DecryptInt32(reader.ReadBytes(4));
            capacity_max_level = DecryptInt32(reader.ReadBytes(4));
            get_exp = DecryptInt32(reader.ReadBytes(4));
            levelup_exp_per = DecryptInt32(reader.ReadBytes(4));
            bonus_material_value = DecryptInt32(reader.ReadBytes(4));
            levelup_price_id = DecryptInt32(reader.ReadBytes(4));
            levelup_price_count = DecryptInt32(reader.ReadBytes(4));
            levelup_bonus_per_1 = DecryptFloat(reader.ReadBytes(4));
            levelup_bonus_value_1 = DecryptInt32(reader.ReadBytes(4));
            levelup_bonus_per_2 = DecryptFloat(reader.ReadBytes(4));
            levelup_bonus_value_2 = DecryptInt32(reader.ReadBytes(4));
            levelup_bonus_per_3 = DecryptFloat(reader.ReadBytes(4));
            levelup_bonus_value_3 = DecryptInt32(reader.ReadBytes(4));
            capacity_price_id = DecryptInt32(reader.ReadBytes(4));
            capacity_price_count = DecryptInt32(reader.ReadBytes(4));
            capacity_bonus_per_1 = DecryptFloat(reader.ReadBytes(4));
            capacity_bonus_value_1 = DecryptInt32(reader.ReadBytes(4));
            capacity_bonus_per_2 = DecryptFloat(reader.ReadBytes(4));
            capacity_bonus_value_2 = DecryptInt32(reader.ReadBytes(4));
            capacity_bonus_per_3 = DecryptFloat(reader.ReadBytes(4));
            capacity_bonus_value_3 = DecryptInt32(reader.ReadBytes(4));
            skilllevelup_price_id = DecryptInt32(reader.ReadBytes(4));
            skilllevelup_price_count = DecryptInt32(reader.ReadBytes(4));
            skilllevelup_item_id = DecryptInt32(reader.ReadBytes(4));
            skilllevelup_item_count = DecryptInt32(reader.ReadBytes(4));
            skilllevelup_bonus_per_1 = DecryptFloat(reader.ReadBytes(4));
            skilllevelup_bonus_value_1 = DecryptInt32(reader.ReadBytes(4));
            skilllevelup_bonus_per_2 = DecryptFloat(reader.ReadBytes(4));
            skilllevelup_bonus_value_2 = DecryptInt32(reader.ReadBytes(4));
            skilllevelup_bonus_per_3 = DecryptFloat(reader.ReadBytes(4));
            skilllevelup_bonus_value_3 = DecryptInt32(reader.ReadBytes(4));
            grind_id = DecryptInt32(reader.ReadBytes(4));
            grind_count = DecryptInt32(reader.ReadBytes(4));
            grind_bonus_per_1 = DecryptFloat(reader.ReadBytes(4));
            grind_bonus_value_1 = DecryptInt32(reader.ReadBytes(4));
            grind_bonus_per_2 = DecryptFloat(reader.ReadBytes(4));
            grind_bonus_value_2 = DecryptInt32(reader.ReadBytes(4));
            grind_bonus_per_3 = DecryptFloat(reader.ReadBytes(4));
            grind_bonus_value_3 = DecryptInt32(reader.ReadBytes(4));
            return true;
        }
    }
    class Program
    {
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            Console.WriteLine(hex.ToString());
            return hex.ToString();
        }
        public static byte[] DeriveKeyInitVector(string password, byte[] salt, byte[] encryptedData)
        {
            byte[] iv = new byte[0x10];
            byte[] key;
            Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(password, salt);
            var k = keyGenerator.GetBytes(8);
            key = keyGenerator.GetBytes(0x20);
            Array.Copy(k, 0, iv, 0, 8);
            Array.Copy(salt, 8, iv, 8, 8);
            ByteArrayToString(key);
            ByteArrayToString(iv);
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            using (ICryptoTransform decryptor = rijndaelCipher.CreateDecryptor(key, iv))
            {
                using (MemoryStream memoryStream = new MemoryStream(encryptedData))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        byte[] plainText = new byte[encryptedData.Length];
                        int decryptedCount = cryptoStream.Read(plainText, 0, plainText.Length);
                        byte[] head = new byte[encryptedData.Length - 0x20];
                        var unity = new byte[] { 0x55, 0x6E, 0x69, 0x74, 0x79, 0x46, 0x53, 0x00, 0x00, 0x00, 0x00, 0x06, 0x35, 0x2E, 0x78, 0x2E };
                        Array.Copy(unity, head, unity.Length);
                        Array.Copy(plainText, 0x2f, head, 0xf, plainText.Length - 0x2f);
                        return head;
                    }
                }
            }
        }
        static void work(string fn, Type typeInstance)
        {
            try
            {
            BinaryReader reader = new BinaryReader(File.Open(fn, FileMode.Open));
            int max = reader.ReadInt32();
            var csv = new List<String>();
            for (int i = 0; i < max; i++)
            {
                MethodInfo methodInfo = typeInstance.GetMethod("ReadToStream");
                ParameterInfo[] parameterInfo = methodInfo.GetParameters();
                object classInstance = Activator.CreateInstance(typeInstance, null);
                var result = methodInfo.Invoke(classInstance, new object[] { reader });
                csv.Add(classInstance.ToJson());
            }
            JToken parsedJson = JToken.Parse("[" + string.Join(",", csv.ToArray()) + "]");
            var beautified = parsedJson.ToString(Formatting.Indented);
            File.WriteAllText(fn.Replace(".bytes", ".json"), beautified);
           }
            catch { Console.WriteLine("{0} crashed", fn);
            }
        }
        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                var t = File.ReadAllBytes(args[0]);
                Console.WriteLine(t.Length);
                byte[] salt = new byte[0x20];
                Array.Copy(t, 0, salt, 0, 0x20);
                ByteArrayToString(salt);
                var dec = DeriveKeyInitVector("z_RZT_2SshrdEkhtKSR8LyV7BJ7ghtFN", salt, t);
                File.WriteAllBytes(String.Format("{0}_dec", args), dec);
                return;
            }
            work("DB_ani_localize.bytes", typeof(DBAniLocalizeRow));
            work("DB_ani_retry.bytes", typeof(DBAniRetryRow));
            work("DB_ar_characters.bytes", typeof(DBArCharactersRow));
            work("DB_ar_devices.bytes", typeof(DBArDevicesRow));
            work("DB_ar_systems.bytes", typeof(DBArSystemsRow));
            work("DB_area.bytes", typeof(DBAreaRow));
            work("DB_attendance_package.bytes", typeof(DBAttendancePackageRow));
            work("DB_basepoint_collision_npc.bytes", typeof(DBBasepointCollisionNpcRow));
            work("DB_basepoint_drop.bytes", typeof(DBBasepointDropRow));
            work("DB_basepoint_fellow_reward.bytes", typeof(DBBasepointFellowRewardRow));
            work("DB_basepoint_interactive_ani.bytes", typeof(DBBasepointInteractiveAniRow));
            work("DB_basepoint_npc.bytes", typeof(DBBasepointNpcRow));
            work("DB_basepoint_npc_move.bytes", typeof(DBBasepointNpcMoveRow));
            work("DB_basepoint_npc_talk.bytes", typeof(DBBasepointNpcTalkRow));
            work("DB_basepoint_random_shop.bytes", typeof(DBBasepointRandomShopRow));
            work("DB_basepoint_shop.bytes", typeof(DBBasepointShopRow));
            work("DB_birthday.bytes", typeof(DBBirthdayRow));
            work("DB_blind_content.bytes", typeof(DBBlindContentRow));
            work("DB_box_item_info.bytes", typeof(DBBoxItemInfoRow));
            work("DB_chapter.bytes", typeof(DBChapterRow));
            work("DB_chapter_change.bytes", typeof(DBChapterChangeRow));
            work("DB_chapter_group.bytes", typeof(DBChapterGroupRow));
            work("DB_character_localize_info.bytes", typeof(DBCharacterLocalizeInfoRow));
            work("DB_check_hero_resource.bytes", typeof(DBCheckHeroResourceRow));
            work("DB_check_monster_resource.bytes", typeof(DBCheckMonsterResourceRow));
            work("DB_check_npc_resource.bytes", typeof(DBCheckNpcResourceRow));
            work("DB_check_story.bytes", typeof(DBCheckStoryRow));
            work("DB_coin_shop_event.bytes", typeof(DBCoinShopEventRow));
            work("DB_coin_shop_limited.bytes", typeof(DBCoinShopLimitedRow));
            work("DB_coin_shop_once.bytes", typeof(DBCoinShopOnceRow));
            work("DB_coin_shop_ordinary.bytes", typeof(DBCoinShopOrdinaryRow));
            work("DB_coin_shop_setting.bytes", typeof(DBCoinShopSettingRow));
            work("DB_config_game.bytes", typeof(DBConfigGameRow));
            //work("DB_config_money.bytes", typeof(DBConfigMoneyRow));
            work("DB_contents_passive.bytes", typeof(DBContentsPassiveRow));
            work("DB_content_ad.bytes", typeof(DBContentAdRow));
            work("DB_content_ad_roulette.bytes", typeof(DBContentAdRouletteRow));
            work("DB_content_control.bytes", typeof(DBContentControlRow));
            //work("DB_content_cost.bytes", typeof(DBContentCostRow));
            work("DB_content_link.bytes", typeof(DBContentLinkRow));
            work("DB_control_another.bytes", typeof(DBControlAnotherRow));
            work("DB_cooking_list.bytes", typeof(DBCookingListRow));
            work("DB_cooking_material.bytes", typeof(DBCookingMaterialRow));
            work("DB_cooking_recipe.bytes", typeof(DBCookingRecipeRow));
            work("DB_costume_base.bytes", typeof(DBCostumeBaseRow));
            work("DB_costume_change_sfx.bytes", typeof(DBCostumeChangeSfxRow));
            work("DB_costume_shop.bytes", typeof(DBCostumeShopRow));
            work("DB_costume_shop_group.bytes", typeof(DBCostumeShopGroupRow));
            work("DB_costume_shop_package.bytes", typeof(DBCostumeShopPackageRow));
            work("DB_costume_shop_setting.bytes", typeof(DBCostumeShopSettingRow));
            work("DB_costume_stat.bytes", typeof(DBCostumeStatRow));
            work("DB_daily_attendance.bytes", typeof(DBDailyAttendanceRow));
            work("DB_direct_selector.bytes", typeof(DBDirectSelectorRow));
            work("DB_event.bytes", typeof(DBEventRow));
            work("DB_event_additional_payment.bytes", typeof(DBEventAdditionalPaymentRow));
            work("DB_event_altar_reward.bytes", typeof(DBEventAltarRewardRow));
            work("DB_event_attendance.bytes", typeof(DBEventAttendanceRow));
            work("DB_event_bingo_exchange.bytes", typeof(DBEventBingoExchangeRow));// FUCK
            work("DB_event_bingo_gacha.bytes", typeof(DBEventBingoGachaRow));
            work("DB_event_bingo_random.bytes", typeof(DBEventBingoRandomRow));
            work("DB_event_label_info.bytes", typeof(DBEventLabelInfoRow));
            work("DB_event_lobby.bytes", typeof(DBEventLobbyRow));
            work("DB_event_mission_score.bytes", typeof(DBEventMissionScoreSetRow));
            work("DB_forum_control.bytes", typeof(DBForumControlRow));
            work("DB_gamble_bonus_reward.bytes", typeof(DBGambleBonusRewardRow));
            work("DB_global_channel_setting.bytes", typeof(DBGlobalChannelSettingRow));
            work("DB_guild_war_buff.bytes", typeof(DBGuildWarBuffRow));
            work("DB_guild_war_config.bytes", typeof(DBGuildWarConfigRow));
            work("DB_patrol.bytes", typeof(DBPatrolRow));
            work("DB_pvp_smash_reward.bytes", typeof(DBPvpSmashRewardRow));
            work("DB_pvp_smash_shop_grade.bytes", typeof(DBPvpSmashShopGradeRow));
            work("DB_pvp_smash_shop_reward.bytes", typeof(DBPvpSmashShopRewardRow));
            work("DB_pvp_smash_shop.bytes", typeof(DBPvpSmashShopRow));
            work("DB_special_price_schedule.bytes", typeof(DBSpecialPriceScheduleRow));
            work("DB_stage_boss_season.bytes", typeof(DBStageBossSeasonRow));
            work("DB_event_bingo.bytes", typeof(DBEventBingoRow));
            work("DB_event_bingo_reward.bytes", typeof(DBEventBingoRewardRow));
            work("DB_event_boss_mission.bytes", typeof(DBEventBossMissionRow));
            work("DB_event_boss_setting.bytes", typeof(DBEventBossSettingRow));
            work("DB_event_buff.bytes", typeof(DBEventBuffRow));
            work("DB_event_challenge_destroy.bytes", typeof(DBEventChallengeDestroyRow));
            work("DB_event_challenge_destroyscore.bytes", typeof(DBEventChallengeDestroyscoreRow));
            work("DB_event_donation.bytes", typeof(DBEventDonationRow));
            work("DB_event_exchange.bytes", typeof(DBEventExchangeRow));
            work("DB_event_exchange_box.bytes", typeof(DBEventExchangeBoxRow));
            work("DB_event_exchange_box_setting.bytes", typeof(DBEventExchangeBoxSettingRow));
            work("DB_event_fortune_attendance.bytes", typeof(DBEventFortuneAttendanceRow));
            work("DB_event_furniture.bytes", typeof(DBEventFurnitureRow));
            work("DB_event_ladder_reward.bytes", typeof(DBEventLadderRewardRow));
            work("DB_event_lobby_gift.bytes", typeof(DBEventLobbyGiftRow));
            work("DB_event_mission.bytes", typeof(DBEventMissionRow));
            work("DB_event_mission_achievepoint.bytes", typeof(DBEventMissionAchievepointRow));
            work("DB_event_mission_reward.bytes", typeof(DBEventMissionRewardRow));
            work("DB_event_mission_score.bytes", typeof(DBEventMissionScoreRow));
            work("DB_event_monthly_setting.bytes", typeof(DBEventMonthlySettingRow));
            work("DB_event_monthly_story.bytes", typeof(DBEventMonthlyStoryRow));
            work("DB_event_payback.bytes", typeof(DBEventPaybackRow));
            work("DB_event_playcount.bytes", typeof(DBEventPlaycountRow));
            work("DB_event_rhitta_reward.bytes", typeof(DBEventRhittaRewardRow));
            work("DB_event_setup.bytes", typeof(DBEventSetupRow));
            work("DB_event_time_mission.bytes", typeof(DBEventTimeMissionRow));
            work("DB_evolution_break_base.bytes", typeof(DBEvolutionBreakBaseRow));
            work("DB_evolution_break_max.bytes", typeof(DBEvolutionBreakMaxRow));
            work("DB_exp.bytes", typeof(DBExpRow));
            work("DB_facial_ani_name.bytes", typeof(DBFacialAniNameRow));
            work("DB_fade_inout.bytes", typeof(DBFadeInoutRow));
            work("DB_fate.bytes", typeof(DBFateRow));
            work("DB_fate_monster.bytes", typeof(DBFateMonsterRow));
            work("DB_final_boss_season.bytes", typeof(DBFinalBossSeasonRow));
            work("DB_final_boss_setting.bytes", typeof(DBFinalBossSettingRow));
            work("DB_final_boss_shop.bytes", typeof(DBFinalBossShopRow));
            work("DB_first_buy_bonus.bytes", typeof(DBFirstBuyBonusRow));
            work("DB_food_buff.bytes", typeof(DBFoodBuffRow));
            work("DB_free_package_reward.bytes", typeof(DBFreePackageRewardRow));
            work("DB_friend_visit_hero.bytes", typeof(DBFriendVisitHeroRow));
            work("DB_frozen_content.bytes", typeof(DBFrozenContentRow));
            work("DB_gamble_choice.bytes", typeof(DBGambleChoiceRow));
            work("DB_gamble_display.bytes", typeof(DBGambleDisplayRow));
            work("DB_gamble_group.bytes", typeof(DBGambleGroupRow));
            //work("DB_gamble_head_default.bytes", typeof(DBGambleHeadDefaultRow));
            work("DB_gamble_rating_per.bytes", typeof(DBGambleRatingPerRow));
            work("DB_gamble_rotation_set.bytes", typeof(DBGambleRotationSetRow));
            work("DB_gamble_sign.bytes", typeof(DBGambleSignRow));
            work("DB_gamble_sound.bytes", typeof(DBGambleSoundRow));
            work("DB_game_center_achievement.bytes", typeof(DBGameCenterAchievementRow));
            work("DB_game_center_leaderboard.bytes", typeof(DBGameCenterLeaderboardRow));
            //work("DB_gb_language.bytes", typeof(DBGbLanguageRow));
            //work("DB_gem_base.bytes", typeof(DBGemBaseRow));
            work("DB_guest_gift.bytes", typeof(DBGuestGiftRow));
            work("DB_guest_interactive_talk.bytes", typeof(DBGuestInteractiveTalkRow));
            work("DB_guild_attendance.bytes", typeof(DBGuildAttendanceRow));
            work("DB_guild_base.bytes", typeof(DBGuildBaseRow));
            work("DB_guild_boss_battlescore_info.bytes", typeof(DBGuildBossBattlescoreInfoRow));
            work("DB_guild_boss_guild_reward.bytes", typeof(DBGuildBossGuildRewardRow));
            work("DB_guild_boss_mission.bytes", typeof(DBGuildBossMissionRow));
            work("DB_guild_boss_personal_reward.bytes", typeof(DBGuildBossPersonalRewardRow));
            work("DB_guild_boss_season.bytes", typeof(DBGuildBossSeasonRow));
            //work("DB_guild_buff_base.bytes", typeof(DBGuildBuffBaseRow));
            //work("DB_guild_buff_resource.bytes", typeof(DBGuildBuffResourceRow));
            work("DB_guild_donation.bytes", typeof(DBGuildDonationRow));
            work("DB_guild_mission.bytes", typeof(DBGuildMissionRow));
            work("DB_guild_mission_use.bytes", typeof(DBGuildMissionUseRow));
            work("DB_guild_rank_reward.bytes", typeof(DBGuildRankRewardRow));
            work("DB_guild_shop.bytes", typeof(DBGuildShopRow));
            work("DB_guild_skill.bytes", typeof(DBGuildSkillRow));
            work("DB_guild_war_area.bytes", typeof(DBGuildWarAreaRow));
            work("DB_guild_war_rank_reward.bytes", typeof(DBGuildWarRankRewardRow));
            work("DB_guild_war_region.bytes", typeof(DBGuildWarRegionRow));
            work("DB_hawk_slot.bytes", typeof(DBHawkSlotRow));
            work("DB_head_costume_resource.bytes", typeof(DBHeadCostumeResourceRow));
            work("DB_hero_base.bytes", typeof(DBHeroBaseRow));
            work("DB_hero_capacity_ment.bytes", typeof(DBHeroCapacityMentRow));
            work("DB_hero_contents_passive.bytes", typeof(DBHeroContentsPassiveRow));
            work("DB_hero_detail.bytes", typeof(DBHeroDetailRow));
            work("DB_hero_group_name.bytes", typeof(DBHeroGroupNameRow));
            work("DB_hero_lovepoint_reward.bytes", typeof(DBHeroLovepointRewardRow));
            work("DB_hero_lovepoint_share.bytes", typeof(DBHeroLovepointShareRow));
            work("DB_interactive.bytes", typeof(DBInteractiveRow));
            work("DB_interactive_item.bytes", typeof(DBInteractiveItemRow));
            work("DB_interactive_link.bytes", typeof(DBInteractiveLinkRow));
            work("DB_interactive_talk.bytes", typeof(DBInteractiveTalkRow));
            work("DB_interactive_vr.bytes", typeof(DBInteractiveVrRow));
            work("DB_item_gotcha_display.bytes", typeof(DBItemGotchaDisplayRow));
            work("DB_item_gotcha_group.bytes", typeof(DBItemGotchaGroupRow));
            work("DB_item_gotcha_rating_per.bytes", typeof(DBItemGotchaRatingPerRow));
            work("DB_item_gotcha_sign.bytes", typeof(DBItemGotchaSignRow));
            work("DB_item_info.bytes", typeof(DBItemInfoRow));
            work("DB_journal.bytes", typeof(DBJournalRow));
            work("DB_jukebox_list.bytes", typeof(DBJukeboxListRow));
            work("DB_king_amber.bytes", typeof(DBKingAmberRow));
            work("DB_levelup_package.bytes", typeof(DBLevelupPackageRow));
            work("DB_loading_default.bytes", typeof(DBLoadingDefaultRow));
            work("DB_loading_scene.bytes", typeof(DBLoadingSceneRow));
            work("DB_loading_setting.bytes", typeof(DBLoadingSettingRow));
            work("DB_loading_tip.bytes", typeof(DBLoadingTipRow));
            work("DB_lobby_housing_buff.bytes", typeof(DBLobbyHousingBuffRow));
            work("DB_lobby_housing_furniture_base.bytes", typeof(DBLobbyHousingFurnitureBaseRow));
            work("DB_lobby_housing_shop.bytes", typeof(DBLobbyHousingShopRow));
            work("DB_lobby_npc_reward.bytes", typeof(DBLobbyNpcRewardRow));
            work("DB_lose_guide.bytes", typeof(DBLoseGuideRow));
            work("DB_mailbox.bytes", typeof(DBMailboxRow));
            work("DB_material_change.bytes", typeof(DBMaterialChangeRow));
            work("DB_mission.bytes", typeof(DBMissionRow));
            work("DB_mission_achievepoint.bytes", typeof(DBMissionAchievepointRow));
            work("DB_mission_play_title.bytes", typeof(DBMissionPlayTitleRow));
            work("DB_mission_play_title_group.bytes", typeof(DBMissionPlayTitleGroupRow));
            work("DB_monster_ai.bytes", typeof(DBMonsterAiRow));
            work("DB_monster_base.bytes", typeof(DBMonsterBaseRow));
            work("DB_monster_resource.bytes", typeof(DBMonsterResourceRow));
            work("DB_monster_skill.bytes", typeof(DBMonsterSkillRow));
            work("DB_musical_base.bytes", typeof(DBMusicalBaseRow));
            work("DB_netmarble_reward.bytes", typeof(DBNetmarbleRewardRow));
            work("DB_normal_package.bytes", typeof(DBNormalPackageRow));
            work("DB_notice.bytes", typeof(DBNoticeRow));
            //work("DB_notice_type.bytes", typeof(DBNoticeTypeRow));
            work("DB_npc_info.bytes", typeof(DBNpcInfoRow));
            work("DB_npc_prop.bytes", typeof(DBNpcPropRow));
            work("DB_package_weapon_growth.bytes", typeof(DBPackageWeaponGrowthRow));
            work("DB_package_week_setup.bytes", typeof(DBPackageWeekSetupRow));
            work("DB_pass_design_setting.bytes", typeof(DBPassDesignSettingRow));
            work("DB_pass_mission_rank.bytes", typeof(DBPassMissionRankRow));
            work("DB_pass_mission_rank_reward.bytes", typeof(DBPassMissionRankRewardRow));
            work("DB_popup_package.bytes", typeof(DBPopupPackageRow));
            work("DB_preview_account.bytes", typeof(DBPreviewAccountRow));
            //work("DB_pvp_dummy.bytes", typeof(DBPvpDummyRow));
            work("DB_pvp_mode_base.bytes", typeof(DBPvpModeBaseRow));
            work("DB_pvp_npc_base.bytes", typeof(DBPvpNpcBaseRow));
            work("DB_pvp_npc_name.bytes", typeof(DBPvpNpcNameRow));
            work("DB_pvp_point.bytes", typeof(DBPvpPointRow));
            work("DB_pvp_reward.bytes", typeof(DBPvpRewardRow));
            work("DB_pvp_season_base.bytes", typeof(DBPvpSeasonBaseRow));
            work("DB_pvp_season_reward_group.bytes", typeof(DBPvpSeasonRewardGroupRow));
            work("DB_pvp_shop.bytes", typeof(DBPvpShopRow));
            work("DB_pvp_show.bytes", typeof(DBPvpShowRow));
            work("DB_pvp_top_100_banner.bytes", typeof(DBPvpTop100BannerRow));
            work("DB_pvp_top_rank.bytes", typeof(DBPvpTopRankRow));
            work("DB_pvp_tournament_reward.bytes", typeof(DBPvpTournamentRewardRow));
            work("DB_pvp_week_setting.bytes", typeof(DBPvpWeekSettingRow));
            work("DB_pvp_winning_point.bytes", typeof(DBPvpWinningPointRow));
            work("DB_quest.bytes", typeof(DBQuestRow));
            work("DB_quest_character.bytes", typeof(DBQuestCharacterRow));
            work("DB_quest_character_costume.bytes", typeof(DBQuestCharacterCostumeRow));
            work("DB_quest_drop.bytes", typeof(DBQuestDropRow));
            work("DB_quest_event_utility.bytes", typeof(DBQuestEventUtilityRow));
            work("DB_quest_sound.bytes", typeof(DBQuestSoundRow));
            work("DB_quest_talk.bytes", typeof(DBQuestTalkRow));
            work("DB_random_shop_rating_per.bytes", typeof(DBRandomShopRatingPerRow));
            work("DB_rating.bytes", typeof(DBRatingRow));
            work("DB_recommend_team.bytes", typeof(DBRecommendTeamRow));
            work("DB_region.bytes", typeof(DBRegionRow));
            work("DB_region_change.bytes", typeof(DBRegionChangeRow));
            work("DB_registration_mission.bytes", typeof(DBRegistrationMissionRow));
            work("DB_rest_bonus.bytes", typeof(DBRestBonusRow));
            work("DB_selected_exchange_info.bytes", typeof(DBSelectedExchangeInfoRow));
            work("DB_sequence.bytes", typeof(DBSequenceRow));
            work("DB_set_costume.bytes", typeof(DBSetCostumeRow));
            work("DB_sfx.bytes", typeof(DBSfxRow));
            work("DB_shop_consume.bytes", typeof(DBShopConsumeRow));
            work("DB_shop_menu.bytes", typeof(DBShopMenuRow));
            work("DB_shop_money.bytes", typeof(DBShopMoneyRow));
            work("DB_shop_package.bytes", typeof(DBShopPackageRow));
            work("DB_situation_package.bytes", typeof(DBSituationPackageRow));
            work("DB_skill_card_base.bytes", typeof(DBSkillCardBaseRow));
            work("DB_skill_card_buff.bytes", typeof(DBSkillCardBuffRow));
            work("DB_skill_card_bullet.bytes", typeof(DBSkillCardBulletRow));
            work("DB_skill_card_option.bytes", typeof(DBSkillCardOptionRow));
            //work("DB_skill_card_resource.bytes", typeof(DBSkillCardResourceRow));
            work("DB_skill_passive.bytes", typeof(DBSkillPassiveRow));
            work("DB_skill_retry.bytes", typeof(DBSkillRetryRow));
            work("DB_skin_ani.bytes", typeof(DBSkinAniRow));
            work("DB_skin_awaken.bytes", typeof(DBSkinAwakenRow));
            work("DB_skin_awaken_resource.bytes", typeof(DBSkinAwakenResourceRow));
            work("DB_skin_awaken_stat.bytes", typeof(DBSkinAwakenStatRow));
            work("DB_skin_base.bytes", typeof(DBSkinBaseRow));
            work("DB_skin_costume_resource.bytes", typeof(DBSkinCostumeResourceRow));
            work("DB_skin_evolution.bytes", typeof(DBSkinEvolutionRow));
            work("DB_skin_exclusive_passive.bytes", typeof(DBSkinExclusivePassiveRow));
            work("DB_skin_research.bytes", typeof(DBSkinResearchRow));
            work("DB_skin_skill.bytes", typeof(DBSkinSkillRow));
            work("DB_skin_skill_levelup.bytes", typeof(DBSkinSkillLevelupRow));
            work("DB_sns_reward.bytes", typeof(DBSnsRewardRow));
            work("DB_sound.bytes", typeof(DBSoundRow));
            work("DB_stage.bytes", typeof(DBStageRow));
            work("DB_stage_boss.bytes", typeof(DBStageBossRow));
            work("DB_stage_boss_destroy.bytes", typeof(DBStageBossDestroyRow));
            work("DB_stage_challenge_boss.bytes", typeof(DBStageChallengeBossRow));
            work("DB_stage_challenge_boss_desc.bytes", typeof(DBStageChallengeBossDescRow));
            work("DB_stage_challenge_boss_event.bytes", typeof(DBStageChallengeBossEventRow));
            work("DB_stage_challenge_boss_group.bytes", typeof(DBStageChallengeBossGroupRow));
            work("DB_stage_destroy.bytes", typeof(DBStageDestroyRow));
            work("DB_stage_destroy_common.bytes", typeof(DBStageDestroyCommonRow));
            work("DB_stage_destroy_desc.bytes", typeof(DBStageDestroyDescRow));
            work("DB_stage_event_monthly.bytes", typeof(DBStageEventMonthlyRow));
            work("DB_stage_extra.bytes", typeof(DBStageExtraRow));
            work("DB_stage_final_boss.bytes", typeof(DBStageFinalBossRow));
            work("DB_stage_final_boss_battlescore.bytes", typeof(DBStageFinalBossBattlescoreRow));
            work("DB_stage_final_boss_event.bytes", typeof(DBStageFinalBossEventRow));
            work("DB_stage_final_boss_group.bytes", typeof(DBStageFinalBossGroupRow));
            work("DB_stage_final_boss_mission.bytes", typeof(DBStageFinalBossMissionRow));
            work("DB_stage_final_boss_rank_reward.bytes", typeof(DBStageFinalBossRankRewardRow));
            work("DB_stage_final_boss_score_group.bytes", typeof(DBStageFinalBossScoreGroupRow));
            work("DB_stage_free.bytes", typeof(DBStageFreeRow));
            work("DB_stage_global_drop.bytes", typeof(DBStageGlobalDropRow));
            work("DB_stage_global_type.bytes", typeof(DBStageGlobalTypeRow));
            work("DB_stage_guild_war.bytes", typeof(DBStageGuildWarRow));
            work("DB_stage_limited.bytes", typeof(DBStageLimitedRow));
            work("DB_stage_memorial.bytes", typeof(DBStageMemorialRow));
            work("DB_stage_npc_base.bytes", typeof(DBStageNpcBaseRow));
            work("DB_stage_npc_setting.bytes", typeof(DBStageNpcSettingRow));
            work("DB_stage_play_count.bytes", typeof(DBStagePlayCountRow));
            work("DB_stage_quest.bytes", typeof(DBStageQuestRow));
            work("DB_stage_reverse.bytes", typeof(DBStageReverseRow));
            work("DB_stage_reverse_group.bytes", typeof(DBStageReverseGroupRow));
            work("DB_stage_reverse_group_reward.bytes", typeof(DBStageReverseGroupRewardRow));
            work("DB_stage_reverse_mission.bytes", typeof(DBStageReverseMissionRow));
            work("DB_stage_reverse_season_reward.bytes", typeof(DBStageReverseSeasonRewardRow));
            work("DB_stage_run.bytes", typeof(DBStageRunRow));
            work("DB_stage_single_siege.bytes", typeof(DBStageSingleSiegeRow));
            work("DB_stage_single_siege_desc.bytes", typeof(DBStageSingleSiegeDescRow));
            work("DB_stage_subdue_boss.bytes", typeof(DBStageSubdueBossRow));
            work("DB_stage_subdue_boss_group.bytes", typeof(DBStageSubdueBossGroupRow));
            work("DB_stage_subdue_boss_reward.bytes", typeof(DBStageSubdueBossRewardRow));
            work("DB_stage_subdue_tag.bytes", typeof(DBStageSubdueTagRow));
            work("DB_stage_training.bytes", typeof(DBStageTrainingRow));
            work("DB_stage_training_play_count.bytes", typeof(DBStageTrainingPlayCountRow));
            //work("DB_stage_training_setup.bytes", typeof(DBStageTrainingSetupRow));
            work("DB_stage_training_task.bytes", typeof(DBStageTrainingTaskRow));
            work("DB_stage_type.bytes", typeof(DBStageTypeRow));
            work("DB_stage_week.bytes", typeof(DBStageWeekRow));
            work("DB_stage_week_reward.bytes", typeof(DBStageWeekRewardRow));
            work("DB_stage_week_setup.bytes", typeof(DBStageWeekSetupRow));
            work("DB_stamp_chat.bytes", typeof(DBStampChatRow));
            work("DB_stepup_gamble_info.bytes", typeof(DBStepupGambleInfoRow));
            work("DB_stepup_mileage.bytes", typeof(DBStepupMileageRow));
            work("DB_stepup_set.bytes", typeof(DBStepupSetRow));
            work("DB_storyreview_area.bytes", typeof(DBStoryreviewAreaRow));
            work("DB_storyreview_list.bytes", typeof(DBStoryreviewListRow));
            work("DB_storyreview_root.bytes", typeof(DBStoryreviewRootRow));
            work("DB_storyreview_stage.bytes", typeof(DBStoryreviewStageRow));
            work("DB_story_retry.bytes", typeof(DBStoryRetryRow));
            work("DB_town_change.bytes", typeof(DBTownChangeRow));
            work("DB_tutorial_reward.bytes", typeof(DBTutorialRewardRow));
            work("DB_upgrade_rating.bytes", typeof(DBUpgradeRatingRow));
            work("DB_video.bytes", typeof(DBVideoRow));
            work("DB_voice.bytes", typeof(DBVoiceRow));
            work("DB_weapon_auto_setting.bytes", typeof(DBWeaponAutoSettingRow));
            work("DB_weapon_base.bytes", typeof(DBWeaponBaseRow));
            work("DB_weapon_carve_base.bytes", typeof(DBWeaponCarveBaseRow));
            work("DB_weapon_costume_resource.bytes", typeof(DBWeaponCostumeResourceRow));
            work("DB_weapon_event_set.bytes", typeof(DBWeaponEventSetRow));
            work("DB_weapon_evolution.bytes", typeof(DBWeaponEvolutionRow));
            work("DB_weapon_grind.bytes", typeof(DBWeaponGrindRow));
            work("DB_weapon_magic.bytes", typeof(DBWeaponMagicRow));
            work("DB_weapon_option.bytes", typeof(DBWeaponOptionRow));
            work("DB_weapon_option_change.bytes", typeof(DBWeaponOptionChangeRow));
            work("DB_weapon_set.bytes", typeof(DBWeaponSetRow));
            work("DB_weapon_upgrade.bytes", typeof(DBWeaponUpgradeRow));
            work("DB_welcome_attendance.bytes", typeof(DBWelcomeAttendanceRow));
            //work("LocalizeStringDB_English.bytes", typeof(LocalizationManager));
            //Console.ReadLine();
        }
    }
}