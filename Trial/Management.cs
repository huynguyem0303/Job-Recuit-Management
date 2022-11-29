using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial
{
    public partial class Management : Form
    {
        CandidateProfileService candidateProfileService=new CandidateProfileService();
        JobPostingService jobPostingService=new JobPostingService();
        public Management()
        {
            InitializeComponent();
            var listCandidate = candidateProfileService.GetAll().Select(p => new {
                p.CandidateId,
                p.Fullname,
                p.Birthday,
                p.Posting.JobPostingTitle
            }).ToList();
            dgv.DataSource = listCandidate;
            var listPosting = jobPostingService.GetAll().Select(p => new { Value = p.PostingId, Text = p.JobPostingTitle }).ToList();          
            cbPostingID.DisplayMember = "Text";
            cbPostingID.ValueMember = "Value";
            cbPostingID.DataSource = listPosting;
        }

        private void lbDescription_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btCreate.Enabled = true;
            btUpdate.Enabled = false;
            var candidateID= dgv.Rows[e.RowIndex].Cells[0].Value;
            var obj= candidateProfileService.GetAll().Where(p => p.CandidateId.Equals(candidateID)).FirstOrDefault();
            if (obj != null)
            {
                txtCandidateID.Text = obj.CandidateId;
                txtFullname.Text=obj.Fullname;
                dtpBirthday.Value = obj.Birthday.Value;
                txtProfileUrl.Text=obj.ProfileUrl;
                txtPSD.Text = obj.ProfileShortDescription;
                cbPostingID.SelectedValue=obj.PostingId;

            }
            btCreate.Enabled = false;
            btUpdate.Enabled = true;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var search= candidateProfileService.GetAll().Where(p=>p.Fullname.ToLower().Contains(txtSearch.Text.ToLower()))
                .Select(p => new {
                    p.CandidateId,
                    p.Fullname,
                    p.Birthday,
                    p.Posting.JobPostingTitle
                }).ToList();
            dgv.DataSource = search;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }
            candidateProfileService = new CandidateProfileService();
            CandidateProfile candidateProfile = new CandidateProfile();
            candidateProfile.CandidateId = txtCandidateID.Text;
            if (candidateProfileService.GetAll().Where(p => p.CandidateId.Equals(candidateProfile.CandidateId)).FirstOrDefault() != null)
            {
               MessageBox.Show("Candidate ID has existed,please try again!","hello", MessageBoxButtons.OK);
                return;
            }
            candidateProfile.Fullname = txtFullname.Text;
            candidateProfile.Birthday=dtpBirthday.Value;
            candidateProfile.ProfileUrl=txtProfileUrl.Text;
            candidateProfile.ProfileShortDescription = txtPSD.Text;
            candidateProfile.PostingId=cbPostingID.SelectedValue.ToString();
            candidateProfileService.Create(candidateProfile);
            var listCandidate = candidateProfileService.GetAll().Select(p => new {
                p.CandidateId,
                p.Fullname,
                p.Birthday,
                p.Posting.JobPostingTitle
            }).ToList();
            dgv.DataSource = listCandidate;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            
        }
    
        public bool Validation()
        {
            var fullname = txtFullname.Text;
            string pattern = @"^(?!.{21})[A-Z][a-z]{2,}(\s[A-Z][a-z]{2,})*$";
            if (!(new Regex(pattern)).Match(fullname).Success)
            {
                MessageBox.Show("Please enter Capital First letter of each word?", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            var candidateId = txtCandidateID.Text;
            var obj = candidateProfileService.GetAll().Where(p => p.CandidateId.Equals(candidateId)).FirstOrDefault();
            candidateProfileService = new CandidateProfileService();
            var dialog = MessageBox.Show("Do you want to delete it", "Warning", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                candidateProfileService.Delete(obj);
                var listCandidate = candidateProfileService.GetAll().Select(p => new {
                    p.CandidateId,
                    p.Fullname,
                    p.Birthday,
                    p.Posting.JobPostingTitle
                }).ToList();
                dgv.DataSource = listCandidate;
            }
            else
            {
                return;
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            if (!Validation())
            {
                return;
            }
            var dialog = MessageBox.Show("Do you want to update it", "Warning", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                candidateProfileService = new CandidateProfileService();
                CandidateProfile candidateProfile = new CandidateProfile();
                candidateProfile.CandidateId = txtCandidateID.Text;
                candidateProfile.Fullname = txtFullname.Text;
                candidateProfile.Birthday = dtpBirthday.Value;
                candidateProfile.ProfileUrl = txtProfileUrl.Text;
                candidateProfile.ProfileShortDescription = txtPSD.Text;
                candidateProfile.PostingId = cbPostingID.SelectedValue.ToString();
                candidateProfileService.Update(candidateProfile);
                var listCandidate = candidateProfileService.GetAll().Select(p => new {
                    p.CandidateId,
                    p.Fullname,
                    p.Birthday,
                    p.Posting.JobPostingTitle
                }).ToList();
                dgv.DataSource = listCandidate;
            }
            else
            {
                return;
            }
        }
    }
}
