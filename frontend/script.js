// посты

const postsEl = document.querySelector('.posts');
const addBtn = document.querySelector('.post-add');

function createpost(title, text){
    const postEl = document.createElement('div');
    postEl.classList.add('post')
    postEl.innerHTML =`
    <div class="post-header">
                <p id="post-title">${title}</p>
                <textarea id="post-title-input" class="hidden">${title}</textarea>
                <div>
                    <button class="post-edit" id="post-btns"><i class="fa-solid fa-pen-to-square"></i></button>
                    <button class="post-delete" "post-btns"><i class="fa-solid fa-trash"></i></button>
                </div>
            </div>
            <p id="post-text">${text}</p> 
            <textarea id="post-text-input" class="hidden" rows="16" cols="27" minlength="10" maxlength="270">${text}</textarea>
          `
          const editBtn = postEl.querySelector('.post-edit')
          const  deleteBtn = postEl.querySelector('.post-delete')
          const titleEl = postEl.querySelector('#post-title')
          const textEl = postEl.querySelector('#post-text')
          const titleInputEl = postEl.querySelector('#post-title-input')
          const textInputEl = postEl.querySelector('#post-text-input')


          editBtn.addEventListener('click', (e) => {
              titleEl.classList.toggle('hidden')
              textEl.classList.toggle('hidden')

              titleInputEl.classList.toggle('hidden')
              textInputEl.classList.toggle('hidden')

          })
          deleteBtn.addEventListener('click', (e) => {
              postEl.remove()
          })

          titleInputEl.addEventListener('input', (e) => {
            titleEl.innerText = e.target.value
          })

          textInputEl.addEventListener('input', (e) => {
            textEl.innerText = e.target.value
          })

          return postEl
}
addBtn.addEventListener('click', (e) => {
    const el = createpost('#Заголовок', 'Текст')
    postsEl.appendChild(el)
})