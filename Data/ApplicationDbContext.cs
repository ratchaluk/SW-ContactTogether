using System;
using System.Collections.Generic;
using ContactTogetherApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactTogetherApi.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAccount> TblAccounts { get; set; }

    public virtual DbSet<TblAccount1> TblAccounts1 { get; set; }

    public virtual DbSet<TblAccountDetail> TblAccountDetails { get; set; }

    public virtual DbSet<TblAccountType> TblAccountTypes { get; set; }

    public virtual DbSet<TblActivity> TblActivities { get; set; }

    public virtual DbSet<TblArea> TblAreas { get; set; }

    public virtual DbSet<TblAttachment> TblAttachments { get; set; }

    public virtual DbSet<TblBroadcast> TblBroadcasts { get; set; }

    public virtual DbSet<TblBroadcastGroup> TblBroadcastGroups { get; set; }

    public virtual DbSet<TblCategory> TblCategories { get; set; }

    public virtual DbSet<TblChannel> TblChannels { get; set; }

    public virtual DbSet<TblContact> TblContacts { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblErrorLog> TblErrorLogs { get; set; }

    public virtual DbSet<TblGender> TblGenders { get; set; }

    public virtual DbSet<TblLevel> TblLevels { get; set; }

    public virtual DbSet<TblLoginHistory> TblLoginHistories { get; set; }

    public virtual DbSet<TblOrganization> TblOrganizations { get; set; }

    public virtual DbSet<TblPage> TblPages { get; set; }

    public virtual DbSet<TblReference> TblReferences { get; set; }

    public virtual DbSet<TblRemark> TblRemarks { get; set; }

    public virtual DbSet<TblReopenedLog> TblReopenedLogs { get; set; }

    public virtual DbSet<TblReport> TblReports { get; set; }

    public virtual DbSet<TblReportParameter> TblReportParameters { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblRolePage> TblRolePages { get; set; }

    public virtual DbSet<TblRunning> TblRunnings { get; set; }

    public virtual DbSet<TblService> TblServices { get; set; }

    public virtual DbSet<TblSession> TblSessions { get; set; }

    public virtual DbSet<TblStatus> TblStatuses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Thai_100_CS_AI");

        modelBuilder.Entity<TblAccount>(entity =>
        {
            entity.ToTable("TblAccount");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AreaId).HasMaxLength(50);
            entity.Property(e => e.Birthdate).HasMaxLength(50);
            entity.Property(e => e.Created).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.FirstnameEn).HasMaxLength(200);
            entity.Property(e => e.FirstnameTh).HasMaxLength(200);
            entity.Property(e => e.GenderId).HasMaxLength(50);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.IsScret).HasMaxLength(10);
            entity.Property(e => e.LastnameEn).HasMaxLength(200);
            entity.Property(e => e.LastnameTh).HasMaxLength(200);
            entity.Property(e => e.SalutationEn).HasMaxLength(100);
            entity.Property(e => e.SalutationTh).HasMaxLength(100);
            entity.Property(e => e.Updated).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.Zipcode).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<TblAccount1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblAccounts");

            entity.Property(e => e.Column1Address)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Address");
            entity.Property(e => e.Column1AreaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Area_ID");
            entity.Property(e => e.Column1Birthdate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Birthdate");
            entity.Property(e => e.Column1Created)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Created");
            entity.Property(e => e.Column1CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Created_By");
            entity.Property(e => e.Column1FirstnameEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Firstname_EN");
            entity.Property(e => e.Column1FirstnameTh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Firstname_TH");
            entity.Property(e => e.Column1GenderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Gender_ID");
            entity.Property(e => e.Column1Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 ID");
            entity.Property(e => e.Column1IsEnable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Is_Enable");
            entity.Property(e => e.Column1IsScret)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Is_Scret");
            entity.Property(e => e.Column1LastnameEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Lastname_EN");
            entity.Property(e => e.Column1LastnameTh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Lastname_TH");
            entity.Property(e => e.Column1Remark)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Remark");
            entity.Property(e => e.Column1SalutationEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Salutation_EN");
            entity.Property(e => e.Column1SalutationTh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Salutation_TH");
            entity.Property(e => e.Column1Updated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Updated");
            entity.Property(e => e.Column1UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Updated_By");
            entity.Property(e => e.Column1Zipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column1 Zipcode");
        });

        modelBuilder.Entity<TblAccountDetail>(entity =>
        {
            entity.ToTable("TblAccountDetail");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AccountId).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.DetailType).HasMaxLength(50);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.Account).WithMany(p => p.TblAccountDetails).HasForeignKey(d => d.AccountId);
        });

        modelBuilder.Entity<TblAccountType>(entity =>
        {
            entity.ToTable("TblAccountType");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsDefault).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.NameEn).HasMaxLength(200);
            entity.Property(e => e.NameTh).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblActivity>(entity =>
        {
            entity.HasKey(e => new { e.ServiceId, e.Line });

            entity.ToTable("TblActivity");

            entity.Property(e => e.ServiceId).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasMaxLength(50);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.ContactId).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.GroupId).HasMaxLength(50);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.IsReceived).HasMaxLength(10);
            entity.Property(e => e.OwnerId).HasMaxLength(50);
            entity.Property(e => e.StatusId).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.Category).WithMany(p => p.TblActivities)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TblArea>(entity =>
        {
            entity.ToTable("TblArea");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AreaType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsDefault).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.NameEn).HasMaxLength(200);
            entity.Property(e => e.NameTh).HasMaxLength(200);
            entity.Property(e => e.RefId).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Zipcode).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Ref).WithMany(p => p.InverseRef)
                .HasForeignKey(d => d.RefId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TblAttachment>(entity =>
        {
            entity.ToTable("TblAttachment");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.FileType).HasMaxLength(100);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.ServiceId).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblBroadcast>(entity =>
        {
            entity.ToTable("TblBroadcast");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.BroadcastType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.HaveGroup).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.TitleEn).HasMaxLength(250);
            entity.Property(e => e.TitleTh).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblBroadcastGroup>(entity =>
        {
            entity.ToTable("TblBroadcastGroup");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.BroadcastId).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.Broadcast).WithMany(p => p.TblBroadcastGroups).HasForeignKey(d => d.BroadcastId);
        });

        modelBuilder.Entity<TblCategory>(entity =>
        {
            entity.ToTable("TblCategory");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CategoryType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsDefault).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.NameEn).HasMaxLength(200);
            entity.Property(e => e.NameTh).HasMaxLength(200);
            entity.Property(e => e.RefId).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.Ref).WithMany(p => p.InverseRef)
                .HasForeignKey(d => d.RefId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TblChannel>(entity =>
        {
            entity.ToTable("TblChannel");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsDefault).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.NameEn).HasMaxLength(200);
            entity.Property(e => e.NameTh).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblContact>(entity =>
        {
            entity.ToTable("TblContact");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasMaxLength(50);
            entity.Property(e => e.ChannelId).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.MenuIvr).HasMaxLength(100);

            entity.HasOne(d => d.Channel).WithMany(p => p.TblContacts)
                .HasForeignKey(d => d.ChannelId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.ToTable("TblEmployee");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.DefaultLanguage).HasMaxLength(10);
            entity.Property(e => e.FirstnameEn).HasMaxLength(200);
            entity.Property(e => e.FirstnameTh).HasMaxLength(200);
            entity.Property(e => e.GenderId).HasMaxLength(50);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.LastnameEn).HasMaxLength(200);
            entity.Property(e => e.LastnameTh).HasMaxLength(200);
            entity.Property(e => e.OrganizationId).HasMaxLength(50);
            entity.Property(e => e.Position).HasMaxLength(100);
            entity.Property(e => e.RoleId).HasMaxLength(50);
            entity.Property(e => e.SalutationEn).HasMaxLength(100);
            entity.Property(e => e.SalutationTh).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserPassword).HasMaxLength(255);
        });

        modelBuilder.Entity<TblErrorLog>(entity =>
        {
            entity.ToTable("TblErrorLog");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.ErrorCode).HasMaxLength(50);
            entity.Property(e => e.ErrorOnFunction).HasMaxLength(255);
            entity.Property(e => e.ErrorOnPage).HasMaxLength(255);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<TblGender>(entity =>
        {
            entity.ToTable("TblGender");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsDefault).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.NameEn).HasMaxLength(200);
            entity.Property(e => e.NameTh).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblLevel>(entity =>
        {
            entity.ToTable("TblLevel");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsDefault).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.LevelType).HasMaxLength(50);
            entity.Property(e => e.NameEn).HasMaxLength(200);
            entity.Property(e => e.NameTh).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblLoginHistory>(entity =>
        {
            entity.ToTable("TblLoginHistory");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.EmployeeId).HasMaxLength(50);
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblOrganization>(entity =>
        {
            entity.ToTable("TblOrganization");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsDefault).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.NameEn).HasMaxLength(200);
            entity.Property(e => e.NameTh).HasMaxLength(200);
            entity.Property(e => e.RefId).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.Ref).WithMany(p => p.InverseRef)
                .HasForeignKey(d => d.RefId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TblPage>(entity =>
        {
            entity.ToTable("TblPage");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.ControlId).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.PageAdmin).HasMaxLength(10);
            entity.Property(e => e.PageFileName).HasMaxLength(255);
            entity.Property(e => e.PageNameEn).HasMaxLength(200);
            entity.Property(e => e.PageNameTh).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblReference>(entity =>
        {
            entity.ToTable("TblReference");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsDefault).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.NameEn).HasMaxLength(200);
            entity.Property(e => e.NameTh).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblRemark>(entity =>
        {
            entity.ToTable("TblRemark");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Abbreviation).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblReopenedLog>(entity =>
        {
            entity.HasKey(e => new { e.SrId, e.Line });

            entity.ToTable("TblReopenedLog");

            entity.Property(e => e.SrId).HasMaxLength(50);
            entity.Property(e => e.ClosedBy).HasMaxLength(100);
            entity.Property(e => e.ReopenedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblReport>(entity =>
        {
            entity.HasKey(e => e.ReportId);

            entity.ToTable("TblReport");

            entity.Property(e => e.ReportId).HasMaxLength(50);
            entity.Property(e => e.Displaygrouptree).HasMaxLength(10);
            entity.Property(e => e.Enable).HasMaxLength(10);
            entity.Property(e => e.Recuser).HasMaxLength(100);
            entity.Property(e => e.ReportDatabasename).HasMaxLength(100);
            entity.Property(e => e.ReportFileName).HasMaxLength(255);
            entity.Property(e => e.ReportIntegratedsecurity).HasMaxLength(50);
            entity.Property(e => e.ReportName).HasMaxLength(200);
            entity.Property(e => e.ReportPassword).HasMaxLength(255);
            entity.Property(e => e.ReportServername).HasMaxLength(100);
            entity.Property(e => e.ReportUsername).HasMaxLength(100);
            entity.Property(e => e.Target).HasMaxLength(100);
            entity.Property(e => e.Updateuser).HasMaxLength(100);
        });

        modelBuilder.Entity<TblReportParameter>(entity =>
        {
            entity.ToTable("TblReportParameter");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.DatabaseType).HasMaxLength(50);
            entity.Property(e => e.Enable).HasMaxLength(10);
            entity.Property(e => e.ObjectType).HasMaxLength(50);
            entity.Property(e => e.ParameterDefault).HasMaxLength(255);
            entity.Property(e => e.ParameterName).HasMaxLength(100);
            entity.Property(e => e.ParameterType).HasMaxLength(50);
            entity.Property(e => e.Postback).HasMaxLength(10);
            entity.Property(e => e.Recuser).HasMaxLength(100);
            entity.Property(e => e.ReportId).HasMaxLength(50);
            entity.Property(e => e.Updateuser).HasMaxLength(100);

            entity.HasOne(d => d.Report).WithMany(p => p.TblReportParameters).HasForeignKey(d => d.ReportId);
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.ToTable("TblRole");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsAdmin).HasMaxLength(10);
            entity.Property(e => e.IsDefault).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.LevelSecretId).HasMaxLength(50);
            entity.Property(e => e.NameEn).HasMaxLength(200);
            entity.Property(e => e.NameTh).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblRolePage>(entity =>
        {
            entity.ToTable("TblRolePage");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsAdmin).HasMaxLength(10);
            entity.Property(e => e.IsDelete).HasMaxLength(10);
            entity.Property(e => e.IsDownload).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.IsInsert).HasMaxLength(10);
            entity.Property(e => e.IsOpen).HasMaxLength(10);
            entity.Property(e => e.IsPrint).HasMaxLength(10);
            entity.Property(e => e.IsSearch).HasMaxLength(10);
            entity.Property(e => e.IsUpdate).HasMaxLength(10);
            entity.Property(e => e.PageId).HasMaxLength(50);
            entity.Property(e => e.RoleId).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.Role).WithMany(p => p.TblRolePages).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<TblRunning>(entity =>
        {
            entity.ToTable("TblRunning");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.RunningCode).HasMaxLength(50);
            entity.Property(e => e.RunningFormat).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblService>(entity =>
        {
            entity.ToTable("TblService");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AccountId).HasMaxLength(50);
            entity.Property(e => e.AreaId).HasMaxLength(50);
            entity.Property(e => e.CallBack).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasMaxLength(50);
            entity.Property(e => e.ChannelIncomingId).HasMaxLength(50);
            entity.Property(e => e.ChannelOutgoingId).HasMaxLength(50);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.LevelPriorityId).HasMaxLength(50);
            entity.Property(e => e.LevelSecretId).HasMaxLength(50);
            entity.Property(e => e.LevelSeverityId).HasMaxLength(50);
            entity.Property(e => e.OrganizationId).HasMaxLength(50);
            entity.Property(e => e.OwnerId).HasMaxLength(50);
            entity.Property(e => e.ServiceArea).HasMaxLength(100);
            entity.Property(e => e.ServiceReference).HasMaxLength(100);
            entity.Property(e => e.StatusId).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.Status).WithMany(p => p.TblServices)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TblSession>(entity =>
        {
            entity.ToTable("TblSession");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.EmployeeId).HasMaxLength(50);
            entity.Property(e => e.ServerName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblStatus>(entity =>
        {
            entity.ToTable("TblStatus");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.IsDefault).HasMaxLength(10);
            entity.Property(e => e.IsEnable).HasMaxLength(10);
            entity.Property(e => e.IsType).HasMaxLength(10);
            entity.Property(e => e.NameEn).HasMaxLength(200);
            entity.Property(e => e.NameTh).HasMaxLength(200);
            entity.Property(e => e.RefId).HasMaxLength(50);
            entity.Property(e => e.StatusType).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.Ref).WithMany(p => p.InverseRef)
                .HasForeignKey(d => d.RefId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
