using FirstWebApi.Common;
using FirstWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApi.Repository
{
    public class ManagerCommentRepository
    {
        ProjectTrackContext db = new ProjectTrackContext();

        public List<ManagerComment> GetAllManagerComments()
        {
            return db.ManagerComments.Select(comment => comment).ToList();
        }

        public bool CreateNewManagerComment(ManagerComment comment)
        {
            db.ManagerComments.Add(comment);
            db.SaveChanges();
            return true;
        }

        public ManagerComment SearchManagerCommentById(int id)
        {
            return db.ManagerComments.Where(comment => comment.commentId == id).FirstOrDefault();
        }

        public List<ManagerComment> SearchManagerCommentByTaskId(int id)
        {
            return db.ManagerComments.Where(comment => comment.projTaskId == id).ToList();
        }

        public bool DeleteManagerCommentBy(int id)
        {
            ManagerComment comment = db.ManagerComments.Where(comnt => comnt.commentId == id).FirstOrDefault();
            db.ManagerComments.Remove(comment);
            db.SaveChanges();
            return true;
        }

        public bool EditManagerComment(int id, ManagerComment comment)
        {
            var mgrComment = db.ManagerComments.Where(comnt => comnt.commentId == id)
                .FirstOrDefault();

            if(mgrComment != null)
            {
                mgrComment.comment = comment.comment;
                mgrComment.projTaskId = comment.projTaskId;

                db.SaveChanges();
            }
            return true;
        }
    }
}