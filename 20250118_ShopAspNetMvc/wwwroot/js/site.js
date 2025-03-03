function confirmDeleteProduct(event) {
    const productId = event.target.getAttribute("data-id");
    let modalHtml = `
    <div class="modal fade" id="deleteModal" tabindex="-1" aria-labelledby="deleteModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="deleteModalLabel">Confirm Deletion</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    Are you sure you want to delete this product?
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancel</button>
                    <a href="/Manage/Delete/${productId}" class="btn btn-danger">Delete</a>
                </div>
            </div>
        </div>
    </div>
    `;

    const confirmDeleteContainer = document.querySelector(".confirm-delete-container");
    confirmDeleteContainer.innerHTML = modalHtml;

    const modal = new bootstrap.Modal(document.getElementById('deleteModal'));
    modal.show();
}

const DeleteProductButtons = document.querySelectorAll(".delete-product");
DeleteProductButtons.forEach(button => {
    button.addEventListener("click", confirmDeleteProduct);
});