--Create DataBase [DB_NGXSIS2]
Create database DB_NGXSIS

/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 8/16/2019 3:15:54 PM ******/

CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL
) 
/****** Object:  Table [dbo].[x_addrbook]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_addrbook](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL,
	[is_locked] [bit] NOT NULL,
	[email] [varchar](100) NOT NULL,
	[abuid] [varchar](50) NOT NULL,
	[abpwd] [varchar](50) NOT NULL
)
/****** Object:  Table [dbo].[x_address]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_address](
	[id] [bigint]  PRIMARY KEY  IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[address1] [varchar](1000) NULL,
	[postal_code1] [varchar](20) NULL,
	[rt1] [varchar](5) NULL,
	[rw1] [varchar](5) NULL,
	[kelurahan1] [varchar](100) NULL,
	[kecamatan1] [varchar](100) NULL,
	[region1] [varchar](100) NULL,
	[address2] [varchar](1000) NULL,
	[postal_code2] [varchar](20) NULL,
	[rt2] [varchar](5) NULL,
	[rw2] [varchar](5) NULL,
	[kelurahan2] [varchar](100) NULL,
	[kecamatan2] [varchar](100) NULL,
	[region2] [varchar](100) NULL
)
/***UDAH*** Object:  Table [dbo].[x_biodata]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_biodata](
	[id] [bigint]  PRIMARY KEY  IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL,
	[fullname] [varchar](255) NOT NULL,
	[nick_name] [varchar](100) NOT NULL,
	[pob] [varchar](100) NOT NULL,
	[dob] [date] NOT NULL,
	[gender] [bit] NOT NULL,
	[religion_id] [bigint] NOT NULL,
	[high] [int] NULL,
	[weight] [int] NULL,
	[nationality] [varchar](100) NULL,
	[ethnic] [varchar](50) NULL,
	[hobby] [varchar](25) NULL,
	[identity_type_id] [bigint] NOT NULL,
	[identity_no] [varchar](50) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[phone_number1] [varchar](50) NOT NULL,
	[phone_number2] [varchar](50) NULL,
	[parent_phone_number] [varchar](50) NOT NULL,
	[child_sequence] [varchar](5) NULL,
	[how_many_brothers] [varchar](5) NULL,
	[marital_status_id] [bigint] NOT NULL,
	[addrbook_id] [bigint] NULL,
	[token] [varchar](10) NULL,
	[expired_token] [date] NULL,
	[marriage_year] [varchar](50) NULL,
	[company_id] [bigint] NOT NULL,
	[is_process] [bit] NULL,
	[is_complete] [bit] NULL
)

/****** Object:  Table [dbo].[x_biodata_attachment]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_biodata_attachment](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[file_name] [varchar](100) NULL,
	[file_path] [varchar](1000) NULL,
	[notes] [varchar](1000) NULL,
	[is_photo] [bit] NULL
)
/****** Object:  Table [dbo].[x_catatan]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_catatan](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[title] [varchar](100) NULL,
	[note_type_id] [bigint] NULL,
	[notes] [varchar](1000) NULL
)
CREATE TABLE [dbo].[x_company](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL
) 
/****** Object:  Table [dbo].[x_education_level]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_education_level](
	[id] [bigint] PRIMARY KEY  IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL
)
CREATE TABLE [dbo].[x_family_relation](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL,
	[family_tree_type_id] [bigint] NULL
 )
/****** Object:  Table [dbo].[x_family_tree_type]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_family_tree_type](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL
)
/****** Object:  Table [dbo].[x_identity_type]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_identity_type](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL
) 
/****** Object:  Table [dbo].[x_keahlian]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_keahlian](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[skill_name] [varchar](100) NULL,
	[skill_level_id] [bigint] NULL,
	[notes] [varchar](1000) NULL
 )
/****** Object:  Table [dbo].[x_keluarga]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_keluarga](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[family_tree_type_id] [bigint] NULL,
	[family_relation_id] [bigint] NULL,
	[name] [varchar](100) NULL,
	[gender] [bit] NOT NULL,
	[dob] [date] NULL,
	[education_level_id] [bigint] NULL,
	[job] [varchar](100) NULL,
	[notes] [varchar](1000) NULL
)
/****** Object:  Table [dbo].[x_keterangan_tambahan]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_keterangan_tambahan](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[emergency_contact_name] [varchar](100) NULL,
	[emergency_contact_phone] [varchar](50) NULL,
	[expected_salary] [varchar](20) NULL,
	[is_negotiable] [bit] NULL,
	[start_working] [varchar](10) NULL,
	[is_ready_to_outoftown] [bit] NULL,
	[is_apply_other_place] [bit] NULL,
	[apply_place] [varchar](100) NULL,
	[selection_phase] [varchar](100) NULL,
	[is_ever_badly_sick] [bit] NULL,
	[disease_name] [varchar](100) NULL,
	[disease_time] [varchar](100) NULL,
	[is_ever_psychotest] [bit] NULL,
	[psychotest_needs] [varchar](100) NULL,
	[psychotest_time] [varchar](100) NULL,
	[requirementes_required] [varchar](500) NULL,
	[other_notes] [varchar](1000) NULL
)
/****** Object:  Table [dbo].[x_marital_status]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_marital_status](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL
)
/****** Object:  Table [dbo].[x_menu_acces]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_menu_acces](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[menutree_id] [bigint] NOT NULL,
	[role_id] [bigint] NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL
) 
CREATE TABLE [dbo].[x_menutree](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[menu_image_url] [varchar](100) NULL,
	[menu_icon] [varchar](100) NULL,
	[menu_order] [int] NOT NULL,
	[menu_level] [int] NOT NULL,
	[menu_parent] [bigint] NULL,
	[menu_url] [varchar](100) NOT NULL,
	[menu_type] [varchar](10) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL
)
/****** Object:  Table [dbo].[x_note_type]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_note_type](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL
)
CREATE TABLE [dbo].[x_online_test](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NULL,
	[period_code] [varchar](500) NULL,
	[period] [int] NULL,
	[test_date] [date] NULL,
	[expired_test] [date] NULL,
	[user_access] [varchar](10) NULL,
	[status] [varchar](50) NULL
) 
/****** Object:  Table [dbo].[x_online_test_detail]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_online_test_detail](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[create_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[delete_by] [bigint] NULL,
	[delete_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[online_test_id] [bigint] NULL,
	[test_type_id] [bigint] NULL,
	[test_order] [int] NULL
)
/****** Object:  Table [dbo].[x_organisasi]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_organisasi](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[name] [varchar](100) NULL,
	[position] [varchar](100) NULL,
	[entry_year] [varchar](10) NULL,
	[exit_year] [varchar](10) NULL,
	[responsibility] [varchar](100) NULL,
	[notes] [varchar](1000) NULL
)
/****** Object:  Table [dbo].[x_pe_referensi]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_pe_referensi](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[name] [varchar](100) NULL,
	[position] [varchar](100) NULL,
	[address_phone] [varchar](1000) NULL,
	[relation] [varchar](100) NULL
)
/****** Object:  Table [dbo].[x_religion]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_religion](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL
)
/****** Object:  Table [dbo].[x_rencana_jadwal]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_rencana_jadwal](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[create_by] [bigint] NOT NULL,
	[create_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[delete_by] [bigint] NULL,
	[delete_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[schedule_code] [varchar](20) NULL,
	[schedule_date] [date] NULL,
	[time] [varchar](10) NULL,
	[ro] [bigint] NULL,
	[tro] [bigint] NULL,
	[scedule_type_id] [bigint] NULL,
	[location] [varchar](100) NULL,
	[other_ro_tro] [varchar](100) NULL,
	[notes] [varchar](1000) NULL,
	[is_automatic_mail] [bit] NULL,
	[sent_date] [date] NULL,
	[status] [varchar](50) NULL
)
/****** Object:  Table [dbo].[x_rencana_jadwal_detail]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_rencana_jadwal_detail](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[create_by] [bigint] NOT NULL,
	[create_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[delete_by] [bigint] NULL,
	[delete_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[rencana_jadwal_id] [bigint] NOT NULL,
	[biodata_id] [bigint] NOT NULL
)
CREATE TABLE [dbo].[x_riwayat_pekerjaan](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[company_name] [varchar](500) NULL,
	[city] [varchar](50) NULL,
	[country] [varchar](50) NULL,
	[join_year] [varchar](10) NULL,
	[join_month] [varchar](10) NULL,
	[resign_year] [varchar](10) NULL,
	[resign_month] [varchar](10) NULL,
	[last_position] [varchar](100) NULL,
	[income] [varchar](20) NULL,
	[is_it_related] [bit] NULL,
	[about_job] [varchar](1000) NULL,
	[exit_reason] [varchar](500) NULL,
	[notes] [varchar](5000) NULL
)
/****** Object:  Table [dbo].[x_riwayat_pelatihan]    Script Date: 8/16/2019 3:15:55 PM ******/

CREATE TABLE [dbo].[x_riwayat_pelatihan](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[training_name] [varchar](100) NULL,
	[organizer] [varchar](50) NULL,
	[training_year] [varchar](10) NULL,
	[training_month] [varchar](10) NULL,
	[training_duration] [int] NULL,
	[time_period_id] [bigint] NULL,
	[city] [varchar](50) NULL,
	[country] [varchar](50) NULL,
	[notes] [varchar](1000) NULL
)
CREATE TABLE [dbo].[x_riwayat_pendidikan](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[create_by] [bigint] NOT NULL,
	[create_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[delete_by] [bigint] NULL,
	[delete_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[school_name] [varchar](100) NULL,
	[city] [varchar](50) NULL,
	[country] [varchar](50) NULL,
	[education_level_id] [bigint] NULL,
	[entry_year] [varchar](10) NULL,
	[graduation_year] [varchar](10) NULL,
	[major] [varchar](100) NULL,
	[gpa] [float] NULL,
	[notes] [varchar](1000) NULL,
	[order] [int] NULL,
	[judul_ta] [varchar](255) NULL,
	[deskripsi_ta] [varchar](5000) NULL
)
CREATE TABLE [dbo].[x_riwayat_proyek](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL,
	[riwayat_pekerjaan_id] [bigint] NOT NULL,
	[start_year] [varchar](10) NULL,
	[start_month] [varchar](10) NULL,
	[poject_name] [varchar](50) NULL,
	[project_duration] [int] NULL,
	[time_period_id] [bigint] NULL,
	[client] [varchar](100) NULL,
	[project_position] [varchar](100) NULL,
	[description] [varchar](1000) NULL
 )
CREATE TABLE [dbo].[x_role](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL
)
/****** Object:  Table [dbo].[x_schedule_type]    Script Date: 8/16/2019 3:15:56 PM ******/

CREATE TABLE [dbo].[x_schedule_type](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL
)
CREATE TABLE [dbo].[x_sertifikasi](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[certificate_name] [varchar](200) NULL,
	[publisher] [varchar](100) NULL,
	[valid_start_year] [varchar](10) NULL,
	[valid_start_month] [varchar](10) NULL,
	[until_year] [varchar](10) NULL,
	[until_month] [varchar](10) NULL,
	[notes] [varchar](1000) NULL
)
CREATE TABLE [dbo].[x_skill_level](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL
)
CREATE TABLE [dbo].[x_sumber_loker](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[vacancy_source] [varchar](20) NULL,
	[candidate_type] [varchar](10) NULL,
	[event_name] [varchar](100) NULL,
	[career_center_name] [varchar](100) NULL,
	[referrer_name] [varchar](100) NULL,
	[referrer_phone] [varchar](20) NULL,
	[referrer_email] [varchar](100) NULL,
	[other_source] [varchar](100) NULL,
	[last_income] [varchar](20) NULL,
	[apply_date] [date] NULL,
	[is_process] [bigint] NULL
 )

CREATE TABLE [dbo].[x_test_type](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL
)
CREATE TABLE [dbo].[x_time_period](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL
)
CREATE TABLE [dbo].[x_undangan](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[create_by] [bigint] NOT NULL,
	[create_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[delete_by] [bigint] NULL,
	[delete_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[schedule_type_id] [bigint] NULL,
	[invitation_date] [date] NOT NULL,
	[invitation_code] [varchar](20) NULL,
	[time] [varchar](10) NULL,
	[ro] [bigint] NULL,
	[tro] [bigint] NULL,
	[other_ro_tro] [varchar](100) NULL,
	[location] [varchar](100) NULL,
	[status] [varchar](50) NULL
)
CREATE TABLE [dbo].[x_undangan_detail](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[create_by] [bigint] NOT NULL,
	[create_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[delete_by] [bigint] NULL,
	[delete_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[undangan_id] [bigint] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[notes] [varchar](1000) NULL
)
CREATE TABLE [dbo].[x_userrole](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_deleted] [bit] NOT NULL,
	[addrbook_id] [bigint] NOT NULL,
	[role_id] [bigint] NOT NULL
)

CREATE TABLE [dbo].[x_vacancy_source](
	[id] [bigint] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL,
)
